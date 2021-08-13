using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels
{
    public class QuestionAnswerModel
    {
        public bool IsLast { get; set; }
        public int OptionId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }

        public List<QuizOption> ListOfOptionsForQuiz { get; set; }
    }
}
