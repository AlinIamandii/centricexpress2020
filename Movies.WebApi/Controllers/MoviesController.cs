using Microsoft.AspNetCore.Mvc;
using Movies.Business;
using Movies.Business.Model;
using System;

namespace Movies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieBusiness _movieBusiness;

        public MoviesController(IMovieBusiness movieBusiness)
        {
            _movieBusiness = movieBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var movies = _movieBusiness.Get();
            return Ok(movies);
        }

        [HttpGet("GetById")]
        public IActionResult Get(Guid id)
        {
	        var movie = _movieBusiness.Get(id);

	        if (movie == null)
	        {
		        return NotFound();
	        }

	        return Ok(movie);
        }

        [HttpPost]
        public IActionResult Create([FromBody] MovieModel movie)
        {
            _movieBusiness.Add(movie);
            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(Guid id, [FromBody] MovieModel movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            var exists = _movieBusiness.Exists(id);

            if (!exists)
            {
	            return NotFound();
            }

            _movieBusiness.Edit(movie);

            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery]Guid id)
        {
            _movieBusiness.Delete(id);
            return Ok();
        }
    }
}