using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uncp.Cepre.Web.Models
{
    public class ResponseModel
    {
        public string State { get; set; }
        public string Message { get; set; }
        public Object Result { get; set; }
    }
}