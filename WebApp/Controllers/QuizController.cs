using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.ViewModels;
using System.Web;
using Microsoft.AspNetCore.Http.Extensions;
using Newtonsoft.Json;

namespace WebApp.Controllers
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) :
                JsonConvert.DeserializeObject<T>(value);
        }
    }
    [Authorize]
    public class QuizController : Controller
    {
        private MyDBContext _db;
        public QuizController(MyDBContext context)
        {
            _db = context;
        }
        [HttpGet]
        public IActionResult QuizDetail()
        {
            //Список доступных категорий и их имена
            QuizCategoryModel quizCategoryModel = new QuizCategoryModel();
            /*quizCategoryModel.CategoryList = (from obj in _db.Categories
                                              select new SelectListItem()
                                              {
                                                  Value = obj.CategoryId.ToString(),
                                                  Text = obj.CategoryName.ToString()
                                              }).ToList();*/

            quizCategoryModel.CategoryList = _db.Categories.Select(s => new SelectListItem()
            {
                Value = s.CategoryId.ToString(),
                Text = s.CategoryName.ToString()
            }).ToList();

            return View(quizCategoryModel);
        }
        [HttpPost]
        public async Task<IActionResult> QuizDetail(int CategoryId)
        {
            int i = 1;
            //регистрация пользователя в бд который проходил тетс
            QuizUser user = new QuizUser();
            user.UserName = User.Identity.Name;
            user.LoginTime = DateTime.Now;
            user.CategoryId = CategoryId;
            await _db.QuizUsers.AddAsync(user);
            await _db.SaveChangesAsync();
            List<Question> questions = _db.Questions.Where(e=>e.CategoryId==CategoryId).OrderBy(r => Guid.NewGuid()).Take(5).ToList();//рандомно 5 вопросов по теме

            HttpContext.Session.SetString("UserName", User.Identity.Name);
            HttpContext.Session.SetInt32("CategoryId", CategoryId);
            HttpContext.Session.SetInt32("pageNumbe", i);
            HttpContext.Session.SetInt32("UserId",user.UserId);
            HttpContext.Session.Set<List<Question>>("Questions",questions);
            return View("Question");
        }

        public PartialViewResult UserQuestionAnswer(UserAnswer userAnswer)
        {
            bool IsLast = false;
            if(userAnswer.AnswerText != null)
            {
                List<UserAnswer> CandidateAnswers = HttpContext.Session.Get<List<UserAnswer>>("CadQuestionAnswer");
                if(CandidateAnswers == null)
                {
                    CandidateAnswers = new List<UserAnswer>();
                }
                CandidateAnswers.Add(userAnswer);
                HttpContext.Session.Set<List<UserAnswer>>("CadQuestionAnswer", CandidateAnswers);
            }
            int pageSize = 1;
            int pageNumber = (int)HttpContext.Session.GetInt32("pageNumbe");
            int CategoryId =(int)HttpContext.Session.GetInt32("CategoryId");
            if(HttpContext.Session.GetString("CadQuestionAnswer") == null)
            {
                HttpContext.Session.SetInt32("pageNumbe",pageNumber+1);
            }
            else
            {
                List<UserAnswer> canAnswer = HttpContext.Session.Get<List<UserAnswer>>("CadQuestionAnswer");
                HttpContext.Session.SetInt32("pageNumbe", pageNumber + 1);

            }

            List<Question> listOfQuestion = new List<Question>();
            listOfQuestion = HttpContext.Session.Get<List<Question>>("Questions");// 5 рандом вопросов по теме 

            if (pageNumber == listOfQuestion.Count)
            {
                IsLast = true;
            }

            QuestionAnswerModel questionAnswerModel = new QuestionAnswerModel();
            Question question = new Question();
            question = listOfQuestion.Skip((pageNumber - 1) * pageSize).Take(pageSize).FirstOrDefault();

            questionAnswerModel.IsLast = IsLast;
            questionAnswerModel.QuestionId = question.QuestionId;
            questionAnswerModel.QuestionName = question.QuestionText;
            /*questionAnswerModel.ListOfOptionsForQuiz = (from obj in _db.Options
                                                        where obj.QuestionId == question.QuestionId
                                                        select new QuizOption()
                                                        {
                                                            OptionName = obj.OptionName,
                                                            OptionId = obj.OptionId
                                                        }).ToList();*/

            questionAnswerModel.ListOfOptionsForQuiz = _db.Options.Where(w => w.QuestionId == question.QuestionId)
                                                       .Select(s => new QuizOption()
                                                       {
                                                           OptionName = s.OptionName,
                                                           OptionId = s.OptionId
                                                       }).ToList();

            return PartialView("QuestionOption", questionAnswerModel);
        }
        public async Task<JsonResult> SaveCandidateAnswer(UserAnswer userAnswer)
        {
            List<UserAnswer> canAnswer;
            if (userAnswer.AnswerText != null)
            {
                canAnswer = HttpContext.Session.Get<List<UserAnswer>>("CadQuestionAnswer") as List<UserAnswer>;

                canAnswer.Add(userAnswer);
                HttpContext.Session.Set<List<UserAnswer>>("CadQuestionAnswer", canAnswer);
            }
            canAnswer = HttpContext.Session.Get<List<UserAnswer>>("CadQuestionAnswer") as List<UserAnswer>;
            foreach(var item in canAnswer)
            {
                Result result = new Result();
                result.AnswerText = item.AnswerText;
                result.QuestionId = item.QuestionId;
                result.UserId = (int)HttpContext.Session.GetInt32("UserId");
                await _db.Results.AddAsync(result);
                await _db.SaveChangesAsync();
            }
            return Json(new {message = "Данные успешно добавлены.",success = true });
        }
        public IActionResult GetFinalResult()
        {
            List<UserAnswer> listOfAnswers;
            listOfAnswers = HttpContext.Session.Get<List<UserAnswer>>("CadQuestionAnswer") as List<UserAnswer>;
            var UserResult = (from result in listOfAnswers
                              join answer in _db.Answers on result.QuestionId equals answer.QuestionId
                              join question in _db.Questions on result.QuestionId equals question.QuestionId
                              select new ResultModel()
                              {
                                  Question = question.QuestionText,
                                  Answer = answer.AnswerText,
                                  AnswerByUser = result.AnswerText,
                                  Status = answer.AnswerText == result.AnswerText ? "+":"-"
                              }).ToList();

            HttpContext.Session.Clear();
            return View(UserResult);
        }
    }
}
