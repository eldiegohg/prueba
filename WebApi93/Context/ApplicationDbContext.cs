using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApi93.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        //Modelos a mapear
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //insertar datos en tabla roles
            modelBuilder.Entity<Usuario>().HasData(
                    new Usuario
                    {
                        PkUsuario = 1,
                        Nombre = "Dieguin",
                        User= "Dieguin23",
                        Password= "123456789",
                        FkRol= 1 //Poner rol correspondiente
                    }
                );

            //insertar datos en tabla usuarios
            modelBuilder.Entity<Rol>().HasData(
                    new Rol
                    {
                        PkRol = 1,
                        Nombre= "diegon"
                  
                    }
                );
        }
    }
}
