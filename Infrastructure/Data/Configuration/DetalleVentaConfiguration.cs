using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("detalleventa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.HasOne(x => x.Ventas).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdVenta);
            builder.HasOne(x => x.Inventarios).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdProducto);
            builder.HasOne(x => x.Tallas).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdTalla);
        }
    }
}