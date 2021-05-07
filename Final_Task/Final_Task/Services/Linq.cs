using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;
using Microsoft.EntityFrameworkCore;

namespace Final_Task.Services
{
    public class Linq
    {
        private readonly ApplicationContext _context;

        public Linq(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Task1()
        {
            var result = await _context.SongandArtist
                .Select(s => new
                {
                    NameofArtist = s.Artist.Name,
                    NameofSong = s.Song.Title,
                    Genre = s.Song.Genre.Title
                }).ToListAsync();
            foreach (var item in result)
            {
                Console.WriteLine($"NameofSong - {item.NameofSong}, NameofArtist - {item.NameofArtist} Genre - {item.Genre}");
            }
        }

        public async Task Task2()
        {
            var result = await _context.Songs
               .GroupBy(g => g.Genre.Title)
               .Select(s => new
               {
                   NameofGenre = s.Key,
                   CountofSongs = s.Count()
               }).ToListAsync();
            foreach (var item in result)
            {
                Console.WriteLine($"Genre - {item.NameofGenre}, CountofSongs {item.CountofSongs}");
            }
        }

        public async Task Task3()
        {
            DateTime dateofbirth = _context.Artists.Max(m => m.DateofBirth);

            var result = await _context.Songs
                .Where(w => w.RealesDate < _context.Artists.Max(m => m.DateofBirth))
                .ToListAsync();

            foreach (var item in result)
            {
                Console.WriteLine($" NameofSong - {item}");
            }
        }
    }
}
