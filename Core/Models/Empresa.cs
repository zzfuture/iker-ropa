using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Empresa : BaseModel
    {
        public int Nit { get; set; }
        public string RazonSocial { get; set; }
        public string RepresentanteLegal { get; set; }
        public DateOnly FechaCreacion { get; set; }
        public int IdMun { get; set; }
        public Municipio Municipios { get; set; }
    }
}