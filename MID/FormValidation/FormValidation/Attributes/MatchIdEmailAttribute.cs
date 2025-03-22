using FormValidation.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidation.Attributes
{
	public class MatchIdEmailAttribute : ValidationAttribute
    {
        public MatchIdEmailAttribute()
        {
            ErrorMessage = "Email must match the ID format (XX-XXXXX-X@student.aiub.edu).";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var student = (Student)validationContext.ObjectInstance;

            // Check if both id and email are not null or empty
            if (!string.IsNullOrEmpty(student.id) && !string.IsNullOrEmpty(student.email))
            {
                // Check if email follows the same pattern as the ID and ends with @student.aiub.edu
                string idPattern = @"^\d{2}-\d{5}-[1-3]$";
                string emailPattern = @"^\d{2}-\d{5}-[1-3]@student\.aiub\.edu$";

                // Compare the id and email (excluding domain)
                if (System.Text.RegularExpressions.Regex.IsMatch(student.id, idPattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(student.email, emailPattern) &&
                    student.email.StartsWith(student.id.Split('-')[0] + "-" + student.id.Split('-')[1] + "-" + student.id.Split('-')[2]))
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult(ErrorMessage);
        }
    }
}