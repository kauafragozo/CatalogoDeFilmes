using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CatalogoFilmes.Settings;
using CatalogoFilmes.Entities;


namespace  CatalogoFilmes.Context
{
    public class AppDbContext: DbContext
    {

        public DbSet<Pais> Paises { get; set;}
        public DbSet<Premio> Premios { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppSettings.GetConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.IdPais);
                entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.Nacionalidade)
                .IsRequired()
                .HasMaxLength(50);
            });

            modelBuilder.Entity<Premio>(entity =>
            {
                entity.HasKey(e => e.IdPremio);
                entity.Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(100);
            });
        }

    }
}