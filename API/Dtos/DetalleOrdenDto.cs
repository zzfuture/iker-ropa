using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class DetalleOrdenDto : BaseDto
    {
        public int IdOrden { get; set; }
        public int IdPrenda { get; set; }
        public int cantidadProducir { get; set; }
        public int IdColor { get; set; }
        public int cantidadProducida { get; set; }
        public int IdEstado { get; set; }
    }
}