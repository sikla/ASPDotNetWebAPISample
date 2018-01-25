using ASPDotNetWebAPISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInvokerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56900/");

                // Set the Accept header for BSON.
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/bson"));

                // Send GET request.
                var result = await client.GetAsync("api/books/1");
                result.EnsureSuccessStatusCode();

                // Use BSON formatter to deserialize the result.
                MediaTypeFormatter[] formatters = new MediaTypeFormatter[] {
                    new BsonMediaTypeFormatter()
                };

                var book = await result.Content.ReadAsAsync<Book>(formatters);
            }
        }
    }
}
