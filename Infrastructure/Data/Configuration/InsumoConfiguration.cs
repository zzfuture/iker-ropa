using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.ToTable("insumo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Nombre).HasMaxLength(50);
            builder.Property(x => x.valorUnit).HasColumnType("int");
            builder.Property(x => x.stockMin).HasColumnType("int");
            builder.Property(x => x.stockMax).HasColumnType("int");
        }
    }
}