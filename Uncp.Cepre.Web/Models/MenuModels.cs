using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uncp.Cepre.Web.Models
{
    public class MenuModels
    {

        public string CodigoMenu { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }
        public string CodigoPadre { get; set; }
        public string Icon { get; set; }
        public string Label { get; set; }
        public string LabelIcon { get; set; }

    }
}