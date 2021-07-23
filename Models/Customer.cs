using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace   Veenca.Models
{
    public class Customer
    {
       
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nome")]
        public string name{ get; set; }

    
       [minAge]
       [Display(Name = "Data di nascita")]
        public DateTime Compleanno { get; set; }
        public bool IsSubscribedToNewsLetter  { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Abbonamento")]
        public byte MembershipTypeid { get; set; }



    }
}