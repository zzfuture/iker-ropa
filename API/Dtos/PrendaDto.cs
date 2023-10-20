using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PrendaDto : BaseDto
    {
        public int IdPrenda { get; set; }
        public string Nombre { get; set; }
        public int valorUnitCop { get; set; }
        public int valorUnitUsd { get; set; }
        public int IdEstado { get; set; }
        public int IdTipoProteccion { get; set; }
        public int IdGenero { get; set; }
    }
}