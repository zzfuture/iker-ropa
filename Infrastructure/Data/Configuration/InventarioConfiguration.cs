using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("inventario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.CodInv).HasColumnType("int");
            builder.HasOne(e => e.Prendas).WithMany(e => e.Inventarios).HasForeignKey(e => e.IdPrenda);
            builder.Property(x => x.valorVtaCop).HasColumnType("int");
            builder.Property(x => x.valorVtaUsd).HasColumnType("int");
        }
    }
}