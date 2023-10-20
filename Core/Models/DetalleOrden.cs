using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DetalleOrden : BaseModel
    {
        public int IdOrden { get; set; }
        public Orden Ordenes { get; set; }
        public int IdPrenda { get; set; }
        public Prenda Prendas { get; set; }
        public int cantidadProducir { get; set; }
        public int IdColor { get; set; }
        public Color Colores { get; set; }
        public int cantidadProducida { get; set; }
        public int IdEstado { get; set; }
        public Estado Estados { get; set; }
    }
}