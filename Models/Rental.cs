using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veenca.Models
{
    public class Rental
    {
        public int id { get; set; }
        public DateTime dataPreso { get; set; }
        public DateTime? dataRilascio { get; set; }
     
        [Required]
        public Movie movie { get; set; }
      
        [Required]
        public Customer customer { get; set; }
    }
}