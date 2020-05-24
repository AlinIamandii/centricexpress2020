using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Data.Entities
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public double Rating { get; set; }

        public bool HasWonOscar { get; set; }

        public ICollection<Character> Characters { get; set; }
    }
}