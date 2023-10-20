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
    public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleado
    {
        private readonly ikerropaContext _context;

        public EmpleadoRepository(ikerropaContext context) : base(context)
        {
            _context = context;
        }        
        public override async Task<IEnumerable<Empleado>> GetAllAsync()
        {
            return await _context.Empleados
                .Include(e => e.Ventas)
                .Include(e => e.Ordenes)
                .ToListAsync();
        }

    }
}