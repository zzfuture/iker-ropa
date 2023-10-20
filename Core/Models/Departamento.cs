using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Departamento : BaseModel
    {
        public string Nombre { get; set; }
        public int IdPais { get; set; }
        public Pais Paises { get; set; }
        public ICollection<Municipio> Municipios { get; set; }
    }
}