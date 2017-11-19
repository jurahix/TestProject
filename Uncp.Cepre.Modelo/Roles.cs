using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncp.Cepre.Modelo
{
    public partial class Roles
    {
      
       
        public string CodigoRol { get; set; }
        public string Descripcion { get; set; }
        public Nullable<byte> Estado { get; set; }
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
