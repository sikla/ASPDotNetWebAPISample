using ASPDotNetWebAPISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ASPDotNetWebAPISample.Controllers
{
    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        [Route("{id}")]
        public IHttpActionResult GetBook(int id)
        {
            var book = new Book()
            {
                Id = id,
                Author = "Charles Dickens",
                Title = "Great Expectations",
                Price = 9.95M,
                PublicationDate = new DateTime(2014, 1, 20)
            };

            return Ok(book);
        }
    }
}