using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncp.Cepre.Modelo
{
    public class Matricula
    {
    	public int ID { get; set; }
        public string CodigoEstudiante { get; set; }
        public int TipoCiclo { get; set; }
        public string CodigoCiclo { get; set; }
        public string Turno { get; set; }
        public string CodigoArea { get; set; }
        public int CodigoFacultad { get; set; }
        public int CodigoCarrera { get; set; }
        public int CodigoLocal { get; set; }
        public int CodigoAuala { get; set; }
        public string Grupo { get; set; }
        public string Voucher { get; set; }
        public string Estado { get; set; }
    }
}

