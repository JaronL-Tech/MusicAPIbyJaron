using System.ComponentModel.DataAnnotations;

namespace MusicAPIJaron.Models
{
    public class Music
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }

        public DateTime ReleaseDate { get; set; }

        public String Genre { get; set; }
    }
}
