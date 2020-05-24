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
        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var titanicId = Guid.NewGuid();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(new List<Movie>
            {
                new Movie
                {
                    Id = titanicId,
                    Title = "Titanic",
                    Year = 1997,
                    Rating = 7.8,
                    HasWonOscar = true,
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
            modelBuilder.Entity<Character>().HasData(new List<Character>
            {
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Rose",
                    MovieId = titanicId
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Jack",
                    MovieId = titanicId
                }
            });
        }
    }
}