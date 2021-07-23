using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Veenca.Models
{
    public class Genere
    {   
        [Required]
        public int id { get; set; }
        [Required]
        [StringLength(60)]
        public string name { get; set; }

    }
}