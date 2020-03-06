using System;

namespace Movies.MVC.Models
{
    public class Movie
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public double Rating { get; set; }

        public bool HasWonOscar { get; set; }
    }
}
