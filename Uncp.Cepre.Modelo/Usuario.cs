using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncp.Cepre.Modelo
{
    public class Usuario
    {
        public Int64 ID { get; set; }
        public string User{ get; set; }
        public string Clave { get; set; }
        public string Administrador { get; set; }
    }
}
