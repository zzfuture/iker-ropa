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
    public class InsumoRepository : GenericRepository<Insumo>, IInsumo
    {
        private readonly ikerropaContext _context;

        public InsumoRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Insumo>> GetAllAsync()
        {
            return await _context.Insumos
                .Include(i => i.InsumoPrendas)
                .ToListAsync();
        }

    }
}