using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uncp.Cepre.Dominio;
using Uncp.Cepre.Modelo;
using Uncp.Cepre.Web.Models;

namespace Uncp.Cepre.Web.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        [HttpPost]
        public JsonResult BuscarPorDni(string id)
        {
            // Estudiante item = new Persona() as Estudiante;
            
            ResponseModel result = new ResponseModel();
            try
            {
                result.State = "OK";
                result.Message = "";
                PersonaDominio oPersonDom = new PersonaDominio();
                Persona p = new Persona();
                p= oPersonDom.BuscarPorId(id);

               var item = oPersonDom.BuscarPorId(id);
                result.Result = item;
            }
            catch (Exception ex)
            {
                result.State = "ERROR";
                result.Message = "Error ..." + ex.Message;
                result.Result = null;
            }
            
            return Json(result);
        }
        public JsonResult Guardar(Persona item) {
            // item.FechaNacimiento == null ? Convert.ToDateTime("1900.01.01") : item.FechaNacimiento;

            item.FechaNacimiento = DateTime.Now;
            ResponseModel result = new ResponseModel();
            try
            {
                result.State = "OK";
                result.Message = "";
                PersonaDominio oPersonDom = new PersonaDominio();
                Persona p = new Persona();
                oPersonDom.Guardar(item);
                result.Result = item;
            }
            catch (Exception ex)
            {
                result.State = "ERROR";
                result.Message = "Error ..." + ex.Message;
                result.Result = null;
            }

            return Json(result);
        }
    }
}