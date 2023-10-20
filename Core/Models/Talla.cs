using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Talla : BaseModel
    {
        public string Nombre { get; set; }
        public ICollection<InventarioTalla> InventarioTallas { get; set; }
        public ICollection<DetalleVenta> DetalleVentas { get; set; }
    }
}