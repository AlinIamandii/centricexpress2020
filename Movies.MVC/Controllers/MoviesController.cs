using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies.MVC.Models;

namespace Movies.MVC.Controllers
{
    public class MoviesController : Controller
    { 
        public IActionResult MoviesOverview()
        {
            var movies = new List<Movie>{
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

            return View(movies);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}