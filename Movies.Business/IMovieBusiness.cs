using System;
using System.Collections.Generic;
using Movies.Business.Model;

namespace Movies.Business
{
    public interface IMovieBusiness
    {
        List<MovieModel> Get();

        MovieModel Get(Guid id);

        void Delete(Guid id);

        void Add(MovieModel movieModel);

        void AsignOscar(MovieModel movieModel);

        void Edit(MovieModel movieModel);

        bool Exists(Guid id);
    }
}