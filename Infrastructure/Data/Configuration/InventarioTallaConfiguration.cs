using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            builder.ToTable("inventariotalla");
            builder.HasKey(e => e.IdInv);
            builder.HasOne(e => e.Inventarios).WithMany(e => e.InventarioTallas).HasForeignKey(e => e.IdInv);
            builder.HasKey(e => e.IdTalla);
            builder.HasOne(e => e.Inventarios).WithMany(e => e.InventarioTallas).HasForeignKey(e => e.IdTalla);
        }
    }
}