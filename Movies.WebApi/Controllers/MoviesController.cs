using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.WebApi.Models;

namespace Movies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> _movies = new List<Movie>{
            new Movie
            {
                Id = Guid.NewGuid(),
                Title = "Titanic",
                Year = 1997,
                Rating = 7.8,
                HasWonOscar = true
            },
            new Movie
            {
                Id = Guid.NewGuid(),
                Title = "The Notebook",
                Year = 2004,
                Rating = 7.8,
                HasWonOscar = false
            },
            new Movie
            {
                Id = Guid.NewGuid(),
                Title = "Avatar",
                Year = 2009,
                Rating = 6.8,
                HasWonOscar = true
            }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_movies);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Movie movie)
        {
            _movies.Add(movie);
            return Ok();
        }
    }
}