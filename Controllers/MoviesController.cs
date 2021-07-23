using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veenca.Models;
using Veenca.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _contex;
        public MoviesController()
        {
            _contex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }
        // GET: Movies/Random
        
        public ActionResult index() {

            if (User.IsInRole(RoleName.CanManageMovies)) {
                return View("List");
            }
            else
            return View("ReadOnlyList");
        }

        public ActionResult Details(int?id)
        {

            if (!id.HasValue)
            {
                id = 1;
            }
            var get = _contex.Movies.Include(c => c.Genere).SingleOrDefault(c => c.id == id);

            if (get == null)
            {
                return HttpNotFound();
            }

            var film = new Movie {
            id= get.id,
            name= get.name,
            dataRilascio= get.dataRilascio,
            dataRegistrazione=get.dataRegistrazione,
            stock= get.stock,
            genereID= get.genereID,
            Genere=get.Genere
            };




            var films = new MovieViewModel
            {
              
            };


            return View(film);
        }
        public ActionResult Movie() {
            var movies = new List<Movie> {
                new Movie { name= "UP" },
                new Movie { name = "John Wick 3" },
            };
            var viewModel = new RandomMovieViewModel
            {
                Movies = movies
            };
            return View(viewModel);
        }
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            var listaGeneri = _contex.Generi.ToList();
            var ciao = new Movie {id=0 };
            var viewModel = new NewMovieViewModel
            {
                Generi = listaGeneri,
              Movie = ciao

            };
           
            return View("MovieForm",viewModel);
        }
     //   [Authorize(Roles = RoleName.CanManageMovies)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Movie movie)
        {
            if (!ModelState.IsValid)
            {

                var viewModel = new NewMovieViewModel
                {
                    Movie = movie,
                    Generi = _contex.Generi.ToList()
                };
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                var errorList = (from item in ModelState
                                 where item.Value.Errors.Any()
                                 select item.Value.Errors[0].ErrorMessage).ToList();
                // return Content(errorList[0]);
                return View("MovieForm", viewModel);
            }

            if (movie.id == 0)
            {
                _contex.Movies.Add(movie);

            }
            else
            {
                var customerInDb = _contex.Movies.Single(c => c.id == movie.id);
                customerInDb.name = movie.name;
                customerInDb.dataRilascio = movie.dataRilascio;
                customerInDb.dataRegistrazione = movie.dataRegistrazione;
                customerInDb.genereID = movie.genereID;
                customerInDb.stock = movie.stock;
            }
            _contex.SaveChanges();
            return RedirectToAction("index", "Movies");
        }
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            //return Content("ciao");
            var customer = _contex.Movies.SingleOrDefault(c => c.id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            var viewModel = new NewMovieViewModel
            {

                Movie = customer,
                Generi = _contex.Generi.ToList()
            };
            return View("MovieForm", viewModel);
        }


    }
}