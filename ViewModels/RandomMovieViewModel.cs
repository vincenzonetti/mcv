using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Veenca.Models;

namespace Veenca.ViewModels
{
    public class RandomMovieViewModel

    {
       
        public Movie Movie { get; set; }
       
        public List<Movie> Movies { get; set; }

        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }
        public MembershipType membershipType { get; set; }
       
    }
}