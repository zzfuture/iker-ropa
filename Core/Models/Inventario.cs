using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Inventario : BaseModel
    {
        public int CodInv { get; set; }
        public int IdPrenda { get; set; }
        public Prenda Prendas { get; set; }
        public int valorVtaCop { get; set; }
        public int valorVtaUsd { get; set; }
        public ICollection<InventarioTalla> InventarioTallas { get; set; }
        public ICollection<DetalleVenta> DetalleVentas { get; set; }

        public Task GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}