using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("orden");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Fecha).HasColumnType("date");
            builder.HasOne(e => e.Empleados).WithMany(e => e.Ordenes).HasForeignKey(e => e.IdEmpleado);
            builder.HasOne(e => e.Clientes).WithMany(e => e.Ordenes).HasForeignKey(e => e.IdCliente);
            builder.HasOne(e => e.Estados).WithMany(e => e.Ordenes).HasForeignKey(e => e.IdEstado);
        }
    }
}