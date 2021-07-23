using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Veenca.Models;
using Veenca.Dtos;
using Veenca.App_Start;
using AutoMapper;
using System.Data.Entity;
namespace Veenca.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _contex;
        public MoviesController()
        {
            _contex = new ApplicationDbContext();
        }
        public IEnumerable<MovieDto> GetMovies(string query = null)

        {
            var movieQuery = _contex.Movies.Include(c => c.Genere);
            if (!String.IsNullOrWhiteSpace(query)) {
                movieQuery = movieQuery.Where(m => m.name.Contains(query));
            }
            return movieQuery.ToList().Select(Mapper.Map<Movie, MovieDto>);
        }
        public IHttpActionResult GetMovie(int id)
        {
            var Movie = _contex.Movies.SingleOrDefault(c => c.id == id);
            if (Movie == null)
            {
                return NotFound();
            }


            return Ok(Mapper.Map<Movie, MovieDto>(Movie));


        }
        //POST/api/Movies
        [HttpPost]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult CreateMovie(MovieDto MovieDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var Movie = Mapper.Map<MovieDto, Movie>(MovieDto);
            _contex.Movies.Add(Movie);
            _contex.SaveChanges();
            MovieDto.id = Movie.id;
            return Created(new Uri(Request.RequestUri + "/" + Movie.id), MovieDto);
        }

        //PUT /api/Movies/1
        [HttpPut]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public void UpdateMovies(int id, MovieDto MovieDto)
        {

            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var MovieInDb = _contex.Movies.SingleOrDefault(c => c.id == id);
            if (MovieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(MovieDto, MovieInDb);

            _contex.SaveChanges();
        }
        //Delete /api/Movies/1
        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult DeleteMovie(int id)
        {
            var MovieInDb = _contex.Movies.SingleOrDefault(c => c.id == id);

            if (MovieInDb == null)
                return NotFound();

            _contex.Movies.Remove(MovieInDb);
            _contex.SaveChanges();

            return Ok();
        }

    }
}