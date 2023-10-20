using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("insumoprenda");
            builder.HasKey(x => x.IdInsumo);
            builder.HasOne(e => e.Insumos).WithMany(e => e.InsumoPrendas).HasForeignKey(e => e.IdInsumo);
            builder.HasKey(x => x.IdPrenda);
            builder.HasOne(e => e.Prendas).WithMany(e => e.InsumoPrendas).HasForeignKey(e => e.IdPrenda);
            builder.Property(x => x.Cantidad);
        }
    }
}