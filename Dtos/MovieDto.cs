using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Veenca.Models;
namespace Veenca.Dtos
{
    public class MovieDto
    {
        [Required]
        public int id { get; set; }
        [Required]
        [StringLength(45)]
     
        public string name { get; set; }
        [Required]
     //   [minDate]
        public DateTime dataRilascio { get; set; }

     
      //  [minDate]
        public DateTime dataRegistrazione { get; set; }
        [Required]
        [Range(1, 100)]
     
        public int stock { get; set; }
        public Genere Genere { get; set; }
     
        public int genereID { get; set; }

        public GeneriDto generi { get; set; }
    }
}