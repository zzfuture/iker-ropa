using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Empleado : BaseModel
    {
        public int IdEmp { get; set; }
        public string Nombre { get; set; }
        public int IdCargo { get; set; }
        public Cargo Cargos { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public int IdMunicipio { get; set; }
        public Municipio Municipios { get; set; }
        public ICollection<Venta> Ventas { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
    }
}