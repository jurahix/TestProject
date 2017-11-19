using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncp.Cepre.Modelo
{
    public class Contacto
    {
    	public int ID {get;set;}
    	public string CodigoPersona { get; set; }
    	public int TipoContacto {get;set;}
    	public string DescripcionContacto {get;set;}
    	public Nullable<System.DateTime> FechaInicio { get; set; }
    	public Nullable<System.DateTime> FechaFinal { get; set; }
    	public string UbigeoContacto { get; set; }
    	public string EstadoContacto { get; set; }
    }
}

