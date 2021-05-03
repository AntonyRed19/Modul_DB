﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string InstagramUrl { get; set; }
        public List<Song> Employees { get; set; } = new List<Song>();
    }
}
