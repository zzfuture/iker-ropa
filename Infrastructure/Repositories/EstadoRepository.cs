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
    public class EstadoRepository : GenericRepository<Estado>, IEstado
    {
        private readonly ikerropaContext _context;

        public EstadoRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Estado>> GetAllAsync()
        {
            return await _context.Estados
                .Include(x => x.Prendas)
                .Include(x => x.DetalleOrdenes)
                .Include(x => x.Ordenes)
                .ToListAsync();
        }

    }
}