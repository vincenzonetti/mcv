using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Veenca.Models;
namespace Veenca.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genere> Generi { get; set; }
        public Movie Movie { get; set; }
    }

}