using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TipoEstado : BaseModel
    {
        public string Descripcion { get; set; }
        public ICollection<Estado> Estados { get; set; }
    }
}