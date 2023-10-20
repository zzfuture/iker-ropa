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
    public class TallaRepository : GenericRepository<Talla>, ITalla
    {
        private readonly ikerropaContext _context;

        public TallaRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Talla>> GetAllAsync()
        {
            return await _context.Tallas
                .Include(x => x.InventarioTallas)
                .Include(x => x.DetalleVentas)
                .ToListAsync();
        }

    }
}