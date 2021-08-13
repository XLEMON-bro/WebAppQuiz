using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class QuizUser
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(60, ErrorMessage = "User_Name должен быть меньше 40 сиволов")]
        public string UserName { get; set; }
        [Required]
        public DateTime LoginTime { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
