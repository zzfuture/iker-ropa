using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("insumoproveedor");
            builder.HasKey(x => x.IdInsumo);
            builder.HasOne(e => e.Insumos).WithMany(e => e.InsumoProveedores).HasForeignKey(e => e.IdInsumo);
            builder.HasKey(x => x.IdProveedor);
            builder.HasOne(e => e.Proveedores).WithMany(e => e.InsumoProveedores).HasForeignKey(e => e.IdProveedor);
        }
    }
}