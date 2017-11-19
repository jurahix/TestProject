using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Uncp.Cepre.Web.Models;

namespace Uncp.Cepre.Web.Services
{
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario
        [HttpGet]
        [Route("api/Menus/ListarMenus")]
        public IEnumerable<MenuModels> ListarMenus()
        {
            List<MenuModels> menus = new List<MenuModels>()
            { new MenuModels()
             {
                CodigoMenu = "3",
                Nombre= "Listar",
                Url= "Estudiante.Listar",
                CodigoPadre= "0",
                Icon= "",
                Label= "",
                LabelIcon= ""
            },
           new MenuModels() {
        CodigoMenu= "4",
        Nombre= "Nuevo",
        Url= "Estudiante.Nuevo",
        CodigoPadre= "0",
        Icon= "",
        Label= "",
        LabelIcon= ""
    },
    new MenuModels(){
        CodigoMenu= "5",
        Nombre= "Validar",
        Url= "Estudiante.Validar",
        CodigoPadre= "0",
        Icon= "",
        Label= "",
        LabelIcon= ""
}
            };

            return menus;
        }

        
    }
}
