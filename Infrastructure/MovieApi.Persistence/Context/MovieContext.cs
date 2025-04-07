﻿using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Persistence.Context
{
    public class MovieContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AV376HC\\SQLEXPRESS;Database=ApiMovieDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Cast> Casts{ get; set; }
        public DbSet<Movie> Movies{ get; set; }
        public DbSet<Review> Reviews{ get; set; }
        public DbSet<Tag> Tags{ get; set; }
    }
}
