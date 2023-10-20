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
    public class MunicipioRepository : GenericRepository<Municipio>, IMunicipio
    {
        private readonly ikerropaContext _context;

        public MunicipioRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Municipio>> GetAllAsync()
        {
            return await _context.Municipios
                .Include(x => x.Proveedores)
                .Include(x => x.Empleados)
                .Include(x => x.Empresas)
                .Include(x => x.Clientes)
                .ToListAsync();
        }

    }
}