using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidation.Attributes
{
	public class AgeValidationAttribute : ValidationAttribute
	{
        public AgeValidationAttribute()
        {
            ErrorMessage = "You must be at least 18 years old.";
        }
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            DateTime date;
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(18) <= DateTime.Now;
            }
            return false;
        }
    }
}