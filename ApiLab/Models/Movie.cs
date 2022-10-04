using System;
using System.Collections.Generic;

namespace ApiLab.Models
{
    public partial class Movie
    {
        public Movie()
        {
            MovieReviews = new HashSet<MovieReview>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public string? Rating { get; set; }
        public int? Runtime { get; set; }

        public virtual ICollection<MovieReview> MovieReviews { get; set; }
    }
}
