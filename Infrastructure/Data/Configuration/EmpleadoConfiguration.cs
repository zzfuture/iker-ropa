using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("empleado");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            builder.Property(e => e.IdEmp).HasColumnType("int");
            builder.Property(e => e.Nombre).HasMaxLength(50);
            builder.HasOne(e => e.Cargos).WithMany(e => e.Empleados).HasForeignKey(e => e.IdCargo);
            builder.Property(e => e.FechaIngreso).HasColumnType("date");
            builder.HasOne(e => e.Municipios).WithMany(e => e.Empleados).HasForeignKey(e => e.IdMunicipio);
        }
    }
}