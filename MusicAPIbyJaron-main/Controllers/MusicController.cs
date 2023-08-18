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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MusicController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
        public void Delete(int id)
        {
        }
    }
}
