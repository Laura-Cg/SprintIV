using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ProySprintIII.Shared.Entity;
using System;

namespace ProySprintIII.Server
{
    public class ApplicationDbContext:DbContext
    {
        /* Cada DbSet es una tabla que crearemos a partir de una entidad */
        public DbSet<Movie> Movies {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Cast> Casts {get;set;}
        public DbSet<CategoryMovie> CategoriesMovie {get;set;}
        public DbSet<MovieCast> MoviesCast {get;set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){
        }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        /* Establecemos los tipos de relaciones entre las tablas que se van a crear 1 - 1, 1 - *, N - M
        Creamos una llave primaria compuesta para la tabla CategoryMovie*/
        modelBuilder.Entity<CategoryMovie>().HasKey(x=> new {x.CategoryId, x.MovieId});
        modelBuilder.Entity<MovieCast>().HasKey(x=> new {x.MovieId, x.CastId});
        base.OnModelCreating(modelBuilder);
        }
    }
}