using Microsoft.AspNetCore.Mvc;
using MusicAPIJaron.Data;
using Microsoft.EntityFrameworkCore;
using MusicAPIJaron.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicAPIJaron.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public MusicController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/<MusicController>
        [HttpGet]
        public IActionResult Get()
        {
            var Musics = _context.Musics.ToList();
            return Ok(Musics);
        }

        // GET api/<MusicController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Music = _context.Musics.Find(id);
            if (Music == null)
            {
                return NotFound();
            }
            return Ok(Music);
        }

        
             
        

        // POST api/<MusicController>
        [HttpPost]
        public IActionResult Post([FromBody] Music music)
        {
            _context.Musics.Add(music);
            _context.SaveChanges();
            return StatusCode(201, music);
        }

        // PUT api/<MusicController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusicController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)

        {
            var Music = _context.Musics.Find(id);
            if (Music == null)
            {
                return NotFound();
            }
            _context.Musics.Remove(Music);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
