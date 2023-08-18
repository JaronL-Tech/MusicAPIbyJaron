using Microsoft.EntityFrameworkCore;
using MusicAPIJaron.Models;

namespace MusicAPIJaron.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Music> Musics { get; set; }
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
