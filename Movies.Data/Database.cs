using System;
using System.Collections.Generic;
using Movies.Data.Entities;

namespace Movies.Data
{
    public static class Database
    {
        public static List<Movie> Movies = new List<Movie>
        {
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
    }
}