using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncp.Cepre.Modelo
{
    public class Parentesco
    {
    	public Int64 ID { get; set; }
        public string CodigoPersona1 { get; set; }
        public int TipoParentesco { get; set; }
        public string CodigoPersona2 { get; set; }
    }
}
