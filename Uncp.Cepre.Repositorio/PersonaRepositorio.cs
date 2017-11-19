using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uncp.Cepre.Modelo;
using System.Data;
using System.Linq.Expressions;
using System.Transactions;

namespace Uncp.Cepre.Repositorio
{
   public  class PersonaRepositorio: BaseSql,IRepositorio<Persona>
    {
       

        public PersonaRepositorio()
        {
            this.Conexion = new SqlConnection(base.CadenaConexion);
            this.EsConexionLocal = true;
        }
        public PersonaRepositorio(SqlConnection conexion)
        {
            this.Conexion = conexion;
            this.EsConexionLocal = false;
        }
    
       public List<Persona> BuscarPorCiclo(string cliclo)
       {
           List<Persona> items = new List<Persona>();
           try
           {
              
               }
           
           catch (Exception ex)
           {

               throw ex;
           }
           return items;
       }
        public static Persona Poblar(IDataReader dr)
        {
            Persona item = new Persona();
            item.Apellidos = dr.GetString(dr.GetOrdinal("Apellidos"));
            item.Dni = dr.GetString(dr.GetOrdinal("Dni"));
            item.CodigoRol = dr.GetString(dr.GetOrdinal("CodigoRol"));
            item.PrimerNombre = dr.GetString(dr.GetOrdinal("PrimerNombre"));
            item.SegundoNombre = dr.GetString(dr.GetOrdinal("SegundoNombre"));
            item.Apellidos = dr.GetString(dr.GetOrdinal("Apellidos"));
            item.Genero = dr.GetString(dr.GetOrdinal("Genero"));
            item.FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento"));
            item.UbigeoNacimiento = dr.GetString(dr.GetOrdinal("UbigeoNacimiento"));
            item.Clave = dr.GetString(dr.GetOrdinal("Clave"));
            item.Token = dr.GetString(dr.GetOrdinal("Token"));
            return item;
        }

        public Persona BuscarPorId(string id)
        {
            Persona item = new Persona();
            try
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Cepre_PersonaBuscarPorDni_SP";
                    cmd.CommandType = CommandType.StoredProcedure;
                   
                     cmd.Parameters.Add(new SqlParameter() { ParameterName = "@Dni", Value =id, Direction = ParameterDirection.Input });
                    cmd.Connection = this.Conexion;
                    if (this.EsConexionLocal)
                        cmd.Connection.Open();
                    SqlDataReader dr; 
                       dr= cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        item = Poblar(dr);
                    }

                }
            }

            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (this.EsConexionLocal)
                {
                    if (this.Conexion.State == ConnectionState.Open)
                    {
                        this.Conexion.Close();
                    }
                }
            }
            return item;
        }

        public IEnumerable<Persona> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persona> BuscarPorExpresion(Expression<Func<Persona, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Persona entity)
        {
            using (SqlCommand cmd=new SqlCommand ())
            {
                try
                {
                    cmd.CommandText = "Cepre_ManPersona_SP";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Connection = this.Conexion;
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@Dni             ", Value = entity.Dni, Direction = ParameterDirection.Input });
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@CodigoRol       ", Value = entity.CodigoRol, Direction = ParameterDirection.Input });
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@PrimerNombre    ", Value = entity.PrimerNombre, Direction = ParameterDirection.Input });
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@SegundoNombre   ", Value = entity.SegundoNombre, Direction = ParameterDirection.Input });
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@Apellidos       ", Value = entity.Apellidos, Direction = ParameterDirection.Input });
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@Genero          ", Value = entity.Genero, Direction = ParameterDirection.Input });
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@FechaNacimiento ", Value = entity.FechaNacimiento, Direction = ParameterDirection.Input });
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@UbigeoNacimiento", Value = entity.UbigeoNacimiento, Direction = ParameterDirection.Input });
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@Clave           ", Value = entity.Clave, Direction = ParameterDirection.Input });
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@Token           ", Value = entity.Token, Direction = ParameterDirection.Input });

                    if (this.EsConexionLocal)
                        cmd.Connection.Open();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally {
                    if (this.EsConexionLocal)
                    {
                        if (this.Conexion.State == ConnectionState.Open)
                        {
                            this.Conexion.Close();
                        }
                    }
                }
            }
        }

        public void GuardarLista(IEnumerable<Persona> entities)
        {
            SqlTransaction trx = null;
            this.EsConexionLocal = false;
            if(this.Conexion.State ==ConnectionState.Closed)
                    this.Conexion.Open();
            try
            {
                trx = this.Conexion.BeginTransaction();
                foreach (var item in entities)
                {
                    this.Guardar(item);
                }
                trx.Commit();
            }
            catch (Exception ex)
            {
                trx.Rollback();
                throw ex;
            }
            finally
            {
                trx.Dispose();
                if (this.Conexion.State == ConnectionState.Open)
                {
                    this.Conexion.Close();
                }
            }

        }
        

        public void Eliminar(Persona entity)
        {
            throw new NotImplementedException();
        }

        public void EliminarLista(IEnumerable<Persona> entities)
        {
            throw new NotImplementedException();
        }
    }
}
