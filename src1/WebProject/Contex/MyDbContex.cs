using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Contex
{
    public class MyDbContex : DbContext
    {
        DbSet<Actor> Actors { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<Director> Directors { get; set; }
        DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-3E8OOLTV\\MSSQLSERVER02;database=MovieDb;trusted_connection=true;");
        }
    }
}
