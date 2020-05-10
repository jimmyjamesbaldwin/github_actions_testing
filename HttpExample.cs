using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.IO;

namespace LocalFunctionProj
{
    public static class HttpExample
    {
        [FunctionName("HttpExample")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            //return new ContentResult { Content = "<html><body>Hello <b>world</b></body></html>", ContentType = "text/html" };



                var result = new HttpResponseMessage(HttpStatusCode.OK);
                var stream = new FileStream(@"d:\home\site\wwwroot\HttpExample\index.html", FileMode.Open);
                result.Content = new StreamContent(stream);
                result.Content = new ByteArrayContent(System.Text.Encoding.UTF8.GetBytes(html));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            
                return result;

        }
    }
}
