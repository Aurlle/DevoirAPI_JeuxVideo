using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using static DevoirAPI.EF.JeuxContext;

namespace DevoirAPI_JeuxVideo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Route("api/jeux")]
    public class JeuxController : ControllerBase

    {
        private readonly JeuxVideoContext _context;

        public JeuxController()
        {
            _context = new JeuxVideoContext();
        }

        // GET api/jeux
        public IActionResult GetJeux()
        {
            var jeux = _context.Jeux.ToList();
            return Ok(jeux);
        }

        // GET api/jeux/{id}
        [Route("{id}")]
        public IActionResult GetJeu(int id)
        {
            var jeu = _context.Jeux.FirstOrDefault(j => j.Id == id);
            if (jeu == null)
                return NotFound();

            return Ok(jeu);
        }

        // GET api/jeux/search/{keyword}
        [Route("search/{keyword}")]
        public IActionResult SearchJeux(string keyword)
        {
            var jeux = _context.Jeux.Where(j => j.Titre.Contains(keyword) || j.Descriptif.Contains(keyword)).ToList();
            return Ok(jeux);
        }

        // POST api/jeux
        [HttpPost]
        public IActionResult AjouterJeu(Jeu jeu)
        {
            _context.Jeux.Add(jeu);
            _context.SaveChanges();
            return Ok();
        }
    }
}

