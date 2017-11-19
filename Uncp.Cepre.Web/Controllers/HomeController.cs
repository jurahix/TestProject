using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uncp.Cepre.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Title = "Home Page";
            // RedirectToAction()
            return Redirect("/Html/");
        }
    }
}
