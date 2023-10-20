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
    public class ProveedorRepository : GenericRepository<Proveedor>, IProveedor
    {
        private readonly ikerropaContext _context;

        public ProveedorRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Proveedor>> GetAllAsync()
        {
            return await _context.Proveedores
                .Include(x => x.InsumoProveedores)
                .ToListAsync();
        }

    }
}