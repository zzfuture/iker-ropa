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
    public class TipoProteccionRepository : GenericRepository<TipoProteccion>, ITipoProteccion
    {
        private readonly ikerropaContext _context;

        public TipoProteccionRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<TipoProteccion>> GetAllAsync()
        {
            return await _context.TipoProtecciones
                .Include(x => x.Prendas)
                .ToListAsync();
        }

    }
}