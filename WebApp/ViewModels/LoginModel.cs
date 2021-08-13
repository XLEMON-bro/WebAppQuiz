using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels
{
    public class LoginModel
    {
        
        public string User_Name { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage ="Укажите Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Укажите пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
