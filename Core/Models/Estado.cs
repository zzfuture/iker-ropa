using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Estado : BaseModel
    {
        public string Descripcion { get; set; }
        public int IdTipoEstado { get; set; }
        public TipoEstado TipoEstados { get; set; }
        public ICollection<Prenda> Prendas { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
    }
}