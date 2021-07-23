using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Veenca.Models
{
    public class minDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;
            if (movie.dataRegistrazione.Year > 1900 && movie.dataRilascio.Year > 1900)
            {
                return ValidationResult.Success;

            }
            else {
                return new ValidationResult("il film deve essere stato prodotto dopo il 1900");
            }
           
        }
    }
}