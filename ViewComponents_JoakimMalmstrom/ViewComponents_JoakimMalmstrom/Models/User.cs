using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents_JoakimMalmstrom.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Enter a valid Email-Adress")]
        [EmailAddress]
        public string UserName { get; set; }
    }
}
