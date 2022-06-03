using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        [MaxLength(50)]
        public string? Genre { get; set; }
        public int RunningTime { get; set; }
        public decimal Price { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public List<Country> Countries { get; set; }
    }
}
