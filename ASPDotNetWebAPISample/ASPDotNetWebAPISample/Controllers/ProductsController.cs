using ASPDotNetWebAPISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace ASPDotNetWebAPISample.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        [Route]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        [Route("{id}")]
        public Product GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return null;
            }

            return product;
        }
    }
}