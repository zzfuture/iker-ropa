using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("detalleorden");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.HasOne(x => x.Ordenes).WithMany(x => x.DetalleOrdenes).HasForeignKey(x => x.IdOrden);
            builder.HasOne(x => x.Prendas).WithMany(x => x.DetalleOrdenes).HasForeignKey(x => x.IdPrenda);
            builder.HasOne(x => x.Colores).WithMany(x => x.DetalleOrdenes).HasForeignKey(x => x.IdColor);
            builder.HasOne(x => x.Estados).WithMany(x => x.DetalleOrdenes).HasForeignKey(x => x.IdEstado);
            builder.Property(x => x.cantidadProducida).HasColumnType("int");
        }
    }
}