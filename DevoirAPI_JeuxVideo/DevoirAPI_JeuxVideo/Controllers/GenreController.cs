using DevoirApi.Entities;
using DevoirApi.Repositories;
using DevoirAPI.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static DevoirAPI.EF.JeuxContext;

namespace DevoirAPI_JeuxVideo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase


    {

        private readonly JeuxVideoContext _context;

        public GenreController()
        {
            _context = new JeuxVideoContext();
        }

        // POST api/genres
        [HttpPost]
        public IActionResult CreerGenre(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
            return Ok();
        }

        // GET api/genres
        public IActionResult GetGenres()
        {
            var genres = _context.Genres.ToList();
            return Ok(genres);
        }
    }
}