using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApiProject.Persistence.Context
{
    public class MovieContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-363RU31\\SQLEXPRESS;initial Catalog=ApiMovieDb;integrated security=true;TrustServerCertificate=True");
        }

        public DbSet<Category> Categorys { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Cast> Casts { get; set; }
    }
}
