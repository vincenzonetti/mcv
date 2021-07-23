using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Veenca.Models;
using System.ComponentModel.DataAnnotations;
namespace Veenca.Models
{
    public class Movie
    {
        [Required]
        public int id { get; set; }
        [Required]
        [StringLength(45)]
        [Display(Name = "Titolo")]
        public string name { get; set; }
        [Required]
        [minDate]
        public DateTime dataRilascio { get; set; }
    
        [Display(Name = "Data di registrazione")]
        [minDate]
        public DateTime dataRegistrazione { get; set; }
        [Required]
        [Range(1,100)]
        [Display(Name = "Film in stock")]
        public int stock { get; set; }
        public int Disponibilità { get; set; }
        public Genere Genere { get; set; }
        [Display(Name = "Genere")]
        public int genereID { get; set; }
    }
}