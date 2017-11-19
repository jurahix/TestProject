using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncp.Cepre.Modelo
{
    public class Persona
    {
        public string Dni { get; set; }
        public string CodigoRol { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public string CodigoCiclo { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string UbigeoNacimiento { get; set; }
        public string Clave { get; set; }
        public string Token { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
