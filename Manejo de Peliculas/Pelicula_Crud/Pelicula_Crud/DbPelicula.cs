using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Pelicula_Crud
{
    public partial class DbPelicula : DbContext
    {
        public DbPelicula()
            : base("name=DbPelicula1")
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.Cate_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Peliculas)
                .WithOptional(e => e.Categoria)
                .HasForeignKey(e => e.Peli_Categoria);

            modelBuilder.Entity<Pelicula>()
                .Property(e => e.Peli_Nombre)
                .IsUnicode(false);
        }
    }
}
