using ASPDotNetWebAPISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace ASPDotNetWebAPISample.Controllers
{
    public class ParameterBinderController : ApiController
    {
        public void Put([ModelBinder] GeoPoint location) {

        }
    }
}