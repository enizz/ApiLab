using ApiLab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        ApiLabDbContext _db = new ApiLabDbContext();
        [HttpPost("add")]
        public Movie AddMovie(string name, string genre, string rating, int runtime)
        {
            var m = new Movie { Name = name, Genre = genre, Rating = rating, Runtime = runtime };
            _db.Movies.Add(m);
            _db.SaveChanges();
            return m;
        }

        [HttpGet]
        public List<Movie> GetAll()
        {
            return _db.Movies.ToList();
        }
    }
}
