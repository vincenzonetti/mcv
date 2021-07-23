using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Veenca.Models;
namespace Veenca.ViewModels
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Movie> Movies { get; set; }
        public Genere Genere { get; set; }
        public List<Genere> Generei { get; set; }
        public IEnumerable<Genere> Generi { get; set; }
    }
}