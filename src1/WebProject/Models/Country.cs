using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        public string CountryName { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public List<Actor> Actors { get; set; } 
    }
}
