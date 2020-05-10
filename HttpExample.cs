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
        [FunctionName("LocalFunctionProj")]
        public static HttpResponseMessage Run(HttpRequestMessage req, TraceWriter log)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            var stream = new FileStream(@"d:\home\site\wwwroot\LocalFunctionProj\index.html", FileMode.Open);
            response.Content = new StreamContent(stream);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}
