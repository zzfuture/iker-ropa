using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Insumo : BaseModel
    {
        public string Nombre { get; set; }
        public int valorUnit { get; set; }
        public int stockMin { get; set; }
        public int stockMax { get; set; }
        public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
        public ICollection<InsumoProveedor> InsumoProveedores { get; set; }
    }
}