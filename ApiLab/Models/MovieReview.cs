using System;
using System.Collections.Generic;

namespace ApiLab.Models
{
    public partial class MovieReview
    {
        public int Id { get; set; }
        public string? Reviewer { get; set; }
        public int? Stars { get; set; }
        public int? MovieId { get; set; }

        public virtual Movie? Movie { get; set; }
    }
}
