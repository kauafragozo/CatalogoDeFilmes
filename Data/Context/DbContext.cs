using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CatalogoFilmes.Settings;
using CatalogoFilmes.Entities;


namespace CatalogoFilmes.Context
{
    public class AppDbContext : DbContext
    {

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Premio> Premios { get; set; }
        public DbSet<Premiacao> Premiacoes { get; set; }
        public DbSet<PremioProducao> PremioProducoes { get; set; }
        public DbSet<TipoPremio> TipoPremios { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Atuacao> Atuacoes { get; set; }
        public DbSet<TipoAtuacao> TipoAtuacoes { get; set; }
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

            modelBuilder.Entity<Premiacao>(entity =>
            {
                entity.HasKey(e => e.PremiacaoId);
                entity.Property(e => e.DataPremiacao)
                .IsRequired();

            });

            modelBuilder.Entity<PremioProducao>(entity =>
            {
                entity.HasKey(e => e.IdPremioProducao);

            });

            modelBuilder.Entity<TipoPremio>(entity =>
            {
                entity.HasKey(e => e.IdTipoPremio);
                entity.Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(100);
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(e => e.IdPessoa);              
                entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);
                entity.Property(e => e.CPF)
                .IsRequired()
                .HasMaxLength(14);
                entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50);
            });

            modelBuilder.Entity<Atuacao>(entity =>
            {
                entity.HasKey(e => e.IdAtuacao);
                entity.Property(e => e.Papel)
                .IsRequired()
                .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoAtuacao>(entity =>
            {
                entity.HasKey(e => e.IdTipoAtuacao);
                entity.Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(50);                
            });


        }

    }
}