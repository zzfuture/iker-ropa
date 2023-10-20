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
    public class GeneroRepository : GenericRepository<Genero>, IGenero
    {
        private readonly ikerropaContext _context;

        public GeneroRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Genero>> GetAllAsync()
        {
            return await _context.Generos
                .Include(g => g.Prendas)
                .ToListAsync();
        }

    }
}