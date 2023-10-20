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
    public class PrendaRepository : GenericRepository<Prenda>, IPrenda
    {
        private readonly ikerropaContext _context;

        public PrendaRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Prenda>> GetAllAsync()
        {
            return await _context.Prendas.ToListAsync();
        }

    }
}