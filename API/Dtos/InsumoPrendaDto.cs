using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class InsumoPrendaDto
    {
        public int IdInsumo { get; set; }
        public int IdPrenda { get; set; }
        public int Cantidad { get; set; }
    }
}