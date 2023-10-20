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
    public class CargoRepository : GenericRepository<Cargo>, ICargo
    {
        private readonly ikerropaContext _context;

        public CargoRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Cargo>> GetAllAsync()
        {
            return await _context.Cargos
                .Include(c => c.Empleados)
                .ToListAsync();
        }
    }
}