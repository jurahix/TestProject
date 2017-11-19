using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncp.Cepre.Modelo
{
    public class PagoBN
    {
    	public Int64 IDPago { get; set; }
        public string CodigoPersona { get; set; }
        public string NumeroVoucher { get; set; }
        public string Trabajador { get; set; }
        public double Con { get; set; }
        public string Oficina {get; set;}
    }
}
