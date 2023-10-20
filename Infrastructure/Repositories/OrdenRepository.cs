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
    public class OrdenRepository : GenericRepository<Orden>, IOrden
    {
        private readonly ikerropaContext _context;

        public OrdenRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Orden>> GetAllAsync()
        {
            return await _context.Ordenes
                .Include(x => x.DetalleOrdenes)
                .ToListAsync();
        }

    }
}