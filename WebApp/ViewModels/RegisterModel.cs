using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels
{
    public class RegisterModel
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [EmailAddress(ErrorMessage = "Формат вводе емейл адреса не верен")]
        public string Email { get; set; }
        
        public string User_Name { get; set; }
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [DataType(DataType.Password)]
        [StringLength(25, MinimumLength = 7, ErrorMessage = "Введите пароль от 8 до 25 символов")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", ErrorMessage = "Пароль должен содержать хотя бы 1 цифру и 1 букву вверхнего регистра.")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Пароли не совпадают")]
        public string ConfPassword { get; set; }
    }
}
