using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class InventarioRepository : GenericRepository<Inventario>, IInventario
    {
        private readonly ikerropaContext _context;

        public InventarioRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Inventario>> GetAllAsync()
        {
            return await _context.Inventarios
                .Include(x => x.InventarioTallas)
                .Include(x => x.DetalleVentas)
                .ToListAsync();
        }

    }
}