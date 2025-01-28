using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiUserMinimalista.Models
{
    public partial class METEOROLOGIAContext : DbContext
    {
        public METEOROLOGIAContext()
        {
        }

        public METEOROLOGIAContext(DbContextOptions<METEOROLOGIAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clima> Climas { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-F9LJC9T;Database=METEOROLOGIA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clima>(entity =>
            {
                entity.ToTable("CLIMA");

                entity.Property(e => e.Localizacion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LOCALIZACION");

                entity.Property(e => e.Precipitacion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("PRECIPITACION");

                entity.Property(e => e.Temperatura)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TEMPERATURA");

                entity.Property(e => e.TipoClima)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CLIMA");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDO");

                entity.Property(e => e.Correo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Edad).HasColumnName("EDAD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Pass)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("PASS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
