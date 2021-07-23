using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Veenca.Models
{
    public class minAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeid == MembershipType.Unknown || customer.MembershipTypeid == MembershipType.nonPagah)
            {
                return ValidationResult.Success;
            }
            var age = DateTime.Today.Year - customer.Compleanno.Year;

            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("il cliente deve avere almeno 18 anni");
            }
        }
    }
