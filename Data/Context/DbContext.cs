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
        public DbSet<ProducaoCinematografica> ProducoesCinematograficas { get; set;}
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
                entity.HasOne(e => e.Premio)
                .WithMany(e => e.Premiacoes)
                .HasForeignKey(e => e.PremioId)
                .OnDelete(DeleteBehavior.Restrict);
                
            });

            modelBuilder.Entity<PremioProducao>(entity =>
            {
                entity.HasKey(e => e.IdPremioProducao);
                entity.HasOne(e => e.Premiacao)
                .WithMany(e => e.PremioProducoesP)
                .HasForeignKey(e => e.PremiacaoId)
                .OnDelete(DeleteBehavior.Restrict);
                entity.Property(e => e.PremiacaoId)
                .IsRequired();
                entity.HasOne(e => e.TipoPremio)
                .WithMany(e => e.PremioProducoesT)
                .HasForeignKey(e => e.TipoPremioId)
                .OnDelete(DeleteBehavior.Restrict);
                entity.Property(e => e.TipoPremioId)
                .IsRequired();

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
                entity.HasOne(e => e.PaisMoradia)
                .WithMany(e => e.PessoasMoradoras)
                .HasForeignKey(e => e.PaisMoradiaId);  
                entity.HasOne(e => e.PaisNacenca)
                .WithMany(e => e.PessoasNascenca)
                .HasForeignKey(e => e.PaisNascencaId)
                .OnDelete(DeleteBehavior.Restrict);
                entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(50);
                entity.HasOne(e => e.Usuario)
                .WithMany(e => e.Pessoas)
                .HasForeignKey(e => e.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);
                
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
                entity.HasOne(e => e.Pessoa);
                entity.Property(e => e.Papel)
                .IsRequired()
                .HasMaxLength(50);
                entity.HasOne(e => e.ProducaoCinematografica)
                .WithMany( e => e.Atuacoes)
                .HasForeignKey(e => e.ProducaoCinematograficaId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<TipoAtuacao>(entity =>
            {
                entity.HasKey(e => e.IdTipoAtuacao);
                entity.Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(50);                
            });

            modelBuilder.Entity<ProducaoCinematografica>(entity =>
            {
                entity.HasKey(e => e.IdProdCinematografica);
                entity.Property(e => e.Ano)
                .IsRequired()
                .HasMaxLength(4);
                entity.Property(e => e.Duracao)
                .IsRequired();
                entity.Property(e => e.Serie)
                .HasMaxLength(100);

            });


        }

    }
}