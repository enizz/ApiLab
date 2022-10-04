using ApiLab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieReviewController : ControllerBase
    {
        ApiLabDbContext _db = new ApiLabDbContext();
        [HttpPost("add")]
        public MovieReview AddReview(string reviewer, int stars, int movieId)
        {
            var m = new MovieReview { Reviewer = reviewer, Stars = stars, MovieId = movieId };
            _db.MovieReviews.Add(m);
            _db.SaveChanges();
            return m;
        }

        
    }
}
