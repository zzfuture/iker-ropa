using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.IdCliente).HasColumnType("int");
            builder.Property(x => x.Nombre).HasMaxLength(50);
            builder.HasOne(x => x.TipoPersonas).WithMany(x => x.Clientes).HasForeignKey(x => x.IdTipoPersona);
            builder.Property(x => x.FechaRegistro).HasColumnType("date");
            builder.HasOne(x => x.Municipios).WithMany(x => x.Clientes).HasForeignKey(x => x.IdMunicipio);
        }
    }
}