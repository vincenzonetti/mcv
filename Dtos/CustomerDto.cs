using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Veenca.Models;

namespace Veenca.Dtos
{
    public class CustomerDto
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]

        public string name { get; set; }


      //  [minAge]
       
        public DateTime Compleanno { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
    
        public byte MembershipTypeid { get; set; }
        public membershipTypeDto membershipType { get; set; }
        /*  public MembershipType membershipType { get; set; } Opzione sconsigliata perchè legherebbe 
        questa classe con un'altra 

          */
    }
}