using FormValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidation.Models
{
	public class Student
	{
        [Required(ErrorMessage = "Please provide name")]
        [RegularExpression(@"^[a-zA-Z.-]+$", ErrorMessage = "Name can only contain alphabets, dots, and hyphens.")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please provide ID")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]$", ErrorMessage = "ID must be in the format XX-XXXXX-X, where X is a number and the last X is between 1 and 3.")]
        public string id { get; set; }

        [Required(ErrorMessage = "Please provide date of birth")]
        [AgeValidation]
        public string dob { get; set; }

        [Required(ErrorMessage = "Please provide email")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]@student\.aiub\.edu$", ErrorMessage = "Email must be in the format XX-XXXXX-X@student.aiub.edu.")]
        [MatchIdEmail]
        public string email { get; set; }

        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
    }
}