using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Movies.Data.Entities;

namespace Movies.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(new List<Movie>
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
            });
        }
    }
}