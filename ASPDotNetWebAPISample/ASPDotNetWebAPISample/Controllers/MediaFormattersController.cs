using ASPDotNetWebAPISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ASPDotNetWebAPISample.Controllers
{
    [RoutePrefix("api/media")]
    public class MediaFormattersController : ApiController
    {
        [Route("csv")]
        public HttpResponseMessage GetCSV()
        {
            var product = new Product { Id = 1, Name = "BMW", Category = "Race", Price = 99999999 };
            var response = Request.CreateResponse(HttpStatusCode.OK, product);
            return response;
        }
    }
}