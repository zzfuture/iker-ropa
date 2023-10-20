using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class FormaPago : BaseModel
    {
        public string Descripcion { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}