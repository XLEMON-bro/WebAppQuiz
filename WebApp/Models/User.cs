using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class User
    {
        [Key]
        public int Id {get;set;}
        [Required]
        [MaxLength(60,ErrorMessage ="Email должен быть меньше 60 сиволов")]
        public string Email { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "Password должен быть меньше 25 сиволов")]

        public string Password { get; set; }
        
        [MaxLength(40, ErrorMessage = "User_Name должен быть меньше 40 сиволов")]

        public string User_Name { get; set; }

    }
}
