using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class EstadoDto : BaseDto
    {
        public string Descripcion { get; set; }
        public int IdTipoEstado { get; set; }
    }
}