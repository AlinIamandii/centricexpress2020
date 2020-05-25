using System.Collections.Generic;
using Movies.Business.Model;

namespace Movies.Business
{
    public interface IMovieBusiness
    {
        List<MovieModel> Get();

        void Add(MovieModel movieModel);
    }
}