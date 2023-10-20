using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class DetalleVentaDto : BaseDto
    {
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int IdTalla { get; set; }
    }
}