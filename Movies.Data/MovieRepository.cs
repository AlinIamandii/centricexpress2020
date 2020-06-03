using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Movies.Data.Entities;

namespace Movies.Data
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DatabaseContext _dbContext;

        public MovieRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual IEnumerable<Movie> Get()
        {
            return _dbContext.Set<Movie>()
	            .AsNoTracking()
	            .Include(movie => movie.Characters).AsEnumerable();
        }

        public Movie Get(Guid id)
        {
            return _dbContext.Set<Movie>()
	            .Include(movie => movie.Characters)
                .SingleOrDefault(m => m.Id == id);
        }

        public void Add(Movie entity)
        {
            _dbContext.Set<Movie>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var movie = _dbContext.Set<Movie>().FirstOrDefault(m => m.Id == id);
            _dbContext.Entry(movie).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Edit(Movie entity)
        {
            _dbContext.SaveChanges();
        }

        public bool Exists(Guid id)
        {
	        return _dbContext.Set<Movie>().AsNoTracking().Any(m => m.Id == id);
        }
    }
}
