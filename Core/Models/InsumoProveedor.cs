using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class InsumoProveedor : BaseModel
    {
        public int IdInsumo { get; set; }
        public Insumo Insumos { get; set; }
        public int IdProveedor { get; set; }
        public Proveedor Proveedores { get; set; }
    }
}