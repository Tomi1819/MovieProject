using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models
{
    public class DataModels
    {
        public ICollection<Actor> Actors { get; set; }
        public ICollection<Country> Countries { get; set; }
        public ICollection<Director> Directors { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}
