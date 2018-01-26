using ASPDotNetWebAPISample.Binder;
using ASPDotNetWebAPISample.Formatters;
using ASPDotNetWebAPISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.ModelBinding.Binders;

namespace ASPDotNetWebAPISample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var bson = new BsonMediaTypeFormatter();
            bson.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/vnd.contoso"));
            config.Formatters.Add(bson);

            config.Formatters.Add(new ProductCsvFormatter());

            var provider = new SimpleModelBinderProvider(typeof(GeoPoint), new GeoPointModelBinder());
            config.Services.Insert(typeof(ModelBinderProvider), 0, provider);
        }
    }
}
