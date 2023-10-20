using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TipoProteccion : BaseModel
    {
        public string Descripcion { get; set; }
        public ICollection<Prenda> Prendas { get; set; }
    }
}