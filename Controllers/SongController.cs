using Microsoft.AspNetCore.Mvc;
using MusicAPIJaron.Data;
using Microsoft.EntityFrameworkCore;
using MusicAPIJaron.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicAPIJaron.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public SongController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/<SongController>
        [HttpGet]
        public IActionResult Get()
        {
            var Songs = _context.Songs.ToList();
            return Ok(Songs);
        }

        // GET api/<SongController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Song = _context.Songs.Find(id);
            if (Song == null)
            {
                return NotFound();
            }
            return Ok(Song);
        }

        
             
        

        // POST api/<SongController>
        [HttpPost]
        public IActionResult Post([FromBody] Song Song)
        {
            _context.Songs.Add(Song);
            _context.SaveChanges();
            return StatusCode(201, Song);
        }

        // PUT api/<SongController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song Song)
        {
            var Song = _context.Songs.Find(id);
        }

        // DELETE api/<SongController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)

        {
            var Song = _context.Songs.Find(id);
            if (Song == null)
            {
                return NotFound();
            }
            _context.Songs.Remove(Song);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
