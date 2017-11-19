using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncp.Cepre.Repositorio
{
    public  class BaseSql
    {
        
        public bool EsConexionLocal { get; set; }
        public SqlConnection Conexion { get; set; }
        public string CadenaConexion { get { return "Data Source=.;Initial Catalog=DBCEPREV2;Integrated Security=True"; } }
    }
}
