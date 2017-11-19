using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Uncp.Cepre.Dominio;
using Uncp.Cepre.Modelo;
using Uncp.Cepre.Web.Models;

namespace Uncp.Cepre.Web.Controllers
{
    public class EstudianteControllerX : ApiController
    {
        [Route("api/Estudiante/GetBuscarPorDni/")]
        [HttpPost]
        public Estudiante BuscarPorDni([FromBody]  string id)
        {
            Estudiante item = new Estudiante();
            ResponseModel result = new ResponseModel();
            try
            {
                result.State = "OK";
                result.Message = "";
                PersonaDominio oPersonDom = new PersonaDominio();
                item=(Estudiante)oPersonDom.BuscarPorId(id);
                result.Result = item;
            }
            catch (Exception ex)
            {
                result.State = "ERROR";
                result.Message = "Error ..." +ex.Message;
                result.Result = null;
            }
           
            return item;
        }
    }
}
