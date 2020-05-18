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
            return _dbContext.Set<Movie>().AsEnumerable();
        }

        public void Add(Movie entity)
        {
            _dbContext.Set<Movie>().Add(entity);
            _dbContext.SaveChanges();
        }
    }
}
