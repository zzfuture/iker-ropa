using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Prenda : BaseModel
    {
        public int IdPrenda { get; set; }
        public string Nombre { get; set; }
        public int valorUnitCop { get; set; }
        public int valorUnitUsd { get; set; }
        public int IdEstado { get; set; }
        public Estado Estados { get; set; }
        public int IdTipoProteccion { get; set; }
        public TipoProteccion TipoProtecciones { get; set; }
        public int IdGenero { get; set; }
        public Genero Generos { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
        public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
        public ICollection<Inventario> Inventarios { get; set; }
    }
}