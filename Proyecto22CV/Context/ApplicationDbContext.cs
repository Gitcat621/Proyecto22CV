using Microsoft.EntityFrameworkCore;
using Proyecto22CV.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22CV.Context
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=LAPTOP-TUAC5KFP;Database=Proyecto;Trusted_Connection=True;");
        }

        public DbSet<Actores> Actores { get; set; }
        public DbSet<Directores> Directores { get; set; }
        public DbSet<Peliculas> Peliculas { get; set; }
    }
}
