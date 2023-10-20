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
    public class ColorRepository : GenericRepository<Color>, IColor
    {
        private readonly ikerropaContext _context;

        public ColorRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Color>> GetAllAsync()
        {
            return await _context.Colores
                .Include(x => x.DetalleOrdenes)
                .ToListAsync();
        }

    }
}