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
    public class ClienteRepository : GenericRepository<Cliente>, ICliente
    {
        private readonly ikerropaContext _context;

        public ClienteRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _context.Clientes
                .Include(x => x.Ventas)
                .Include(x => x.Ordenes)
                .ToListAsync();
        }

    }
}