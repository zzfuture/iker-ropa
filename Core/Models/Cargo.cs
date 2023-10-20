using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Cargo : BaseModel
    {
        public string Descripcion { get; set; }
        public int SueldoBase { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}