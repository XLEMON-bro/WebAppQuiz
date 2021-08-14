using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Option
    {
        [Key]
        public int OptionId { get; set; }
        [Required]
        public int QuestionId { get; set; }
        [Required]
        public string OptionName { get; set; }

        public Question Question { get; set; }
    }
}
