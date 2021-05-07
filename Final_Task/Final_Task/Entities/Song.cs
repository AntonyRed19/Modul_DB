using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime RealesDate { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<SongandArtist> SongArtists { get; set; } = new List<SongandArtist>();
    }
}
