using Microsoft.EntityFrameworkCore;
using MusicAPIJaron.Models;

namespace MusicAPIJaron.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        
        

        
    }
}
