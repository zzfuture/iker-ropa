using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Color : BaseModel
    {
        public string Descripcion { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
    }
}