﻿using System;
using System.Collections.Generic;

namespace Movies.Business.Model
{
    public class MovieModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public double Rating { get; set; }

        public bool HasWonOscar { get; set; }
        public ICollection<CharacterModel> Characters { get; set; }
    }
}