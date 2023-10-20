using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("proveedor");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.NitProveedor).HasColumnType("int");
            builder.HasIndex(x => x.NitProveedor).IsUnique();
            builder.Property(x => x.Nombre).HasMaxLength(50);
            builder.HasOne(x => x.TipoPersonas).WithMany(x => x.Proveedores).HasForeignKey(x => x.IdTipoPersona);
            builder.HasOne(x => x.Municipios).WithMany(x => x.Proveedores).HasForeignKey(x => x.IdMunicipio);
        }
    }
}