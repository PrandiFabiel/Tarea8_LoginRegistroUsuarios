using LoginRegistroUsuarios.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegistroUsuarios.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = DATA\Usuarios.db"); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 1,
                Nombres = "Prandi Fabiel",
                Apellidos = "Cortorreal Reynoso",
                NombreUsuario = "Rougue",
                Contrasena = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4"//clave: 1234
            });
        }
    }
}
