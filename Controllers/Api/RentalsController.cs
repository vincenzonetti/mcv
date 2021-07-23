using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Veenca.Dtos;
using AutoMapper;
using System.Data.Entity;
using Veenca.Models;

namespace Veenca.Controllers.Api
{

    public class RentalsController : ApiController
    { private ApplicationDbContext _contex;
        public RentalsController()
        {
            _contex = new ApplicationDbContext();
        }



        [HttpPost]
        public IHttpActionResult NewRental(RentalDto rental)
        {
            if (rental.MovieIds.Count == 0)
                return BadRequest("Non sono stati forniti informazioni su alcun film");
            
            var cliente = _contex.Customers.SingleOrDefault(c => c.id == rental.customerId);
           
            var movies = _contex.Movies.Where(m => rental.MovieIds.Contains(m.id)).ToList();

            if (cliente == null) {
                return BadRequest("L'Id del cliente non è valido");
            }
            if (movies.Count != rental.MovieIds.Count)
                return BadRequest("uno o più id dei film non sono validi");
           
            foreach (var movie in movies)
            {
                if (movie.Disponibilità == 0)
                    return BadRequest("film non disponibile");
                
                movie.Disponibilità--;
                var newRentail = new Rental
                {
                    customer = cliente,
                    movie = movie,
                    dataPreso = DateTime.Now

                };
                _contex.Rentals.Add(newRentail);
            }

            _contex.SaveChanges();

            return Ok();
        } 
             

        }
    }

