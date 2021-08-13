using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebApp.ViewModels
{
    public class QuizCategoryModel
    {
        [Display(Name ="Category")]
        [Required(ErrorMessage ="Категория не указана")]
        public int CategoryId { get; set; }
        [Display(Name ="User")]
        [Required(ErrorMessage ="Поьзователь не указан")]
        public string UserName { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
