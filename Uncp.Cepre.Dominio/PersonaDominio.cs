using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uncp.Cepre.Modelo;
using Uncp.Cepre.Repositorio;

namespace Uncp.Cepre.Dominio
{
    public class PersonaDominio
    {
        private PersonaRepositorio oPersonaRep = null;
        public PersonaDominio()
        {
            oPersonaRep = new PersonaRepositorio();
        }
        public Persona BuscarPorId(string id)
        {
            Persona item = new Persona();
            try
            {
                item = oPersonaRep.BuscarPorId(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return item;
        }
        public void Guardar(Persona item)
        {
           
            try
            {
                 oPersonaRep.Guardar(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}