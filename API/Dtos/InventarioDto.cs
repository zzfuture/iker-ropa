using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class InventarioDto : BaseDto
    {
        public int CodInv { get; set; }
        public int IdPrenda { get; set; }
        public int valorVtaCop { get; set; }
        public int valorVtaUsd { get; set; }
    }
}