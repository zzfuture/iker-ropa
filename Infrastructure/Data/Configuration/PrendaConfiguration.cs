using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            builder.ToTable("prenda");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.IdPrenda).HasColumnType("int");
            builder.HasIndex(x => x.IdPrenda).IsUnique();
            builder.Property(x => x.Nombre).HasMaxLength(50);
            builder.Property(x => x.valorUnitCop).HasColumnType("int");
            builder.Property(x => x.valorUnitUsd).HasColumnType("int");
            builder.HasOne(x => x.Estados).WithMany(x => x.Prendas).HasForeignKey(x => x.IdEstado);
            builder.HasOne(x => x.TipoProtecciones).WithMany(x => x.Prendas).HasForeignKey(x => x.IdTipoProteccion);
            builder.HasOne(x => x.Generos).WithMany(x => x.Prendas).HasForeignKey(x => x.IdGenero);
        }
    }
}