using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class EmpleadoDto : BaseDto
    {
        public int IdEmp { get; set; }
        public string Nombre { get; set; }
        public int IdCargo { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public int IdMunicipio { get; set; }
    }
}