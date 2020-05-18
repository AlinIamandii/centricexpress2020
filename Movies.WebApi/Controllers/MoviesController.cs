﻿using Microsoft.AspNetCore.Mvc;
using Movies.Business;
using Movies.Business.Model;

namespace Movies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieBusiness _movieBusiness;

        public MoviesController(MovieBusiness movieBusiness)
        {
            _movieBusiness = movieBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var movies = _movieBusiness.Get();
            return Ok(movies);
        }

        [HttpPost]
        public IActionResult Create([FromBody] MovieModel movie)
        {
            _movieBusiness.Add(movie);
            return Ok();
        }
    }
}