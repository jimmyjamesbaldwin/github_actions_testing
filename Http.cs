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
using System.Text;

namespace Website
{
    public static class Http
    {
        [FunctionName("Http")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            string readContents;
            using (StreamReader streamReader = new StreamReader(@"d:\home\site\wwwroot\src\index.html", Encoding.UTF8))
            {
                readContents = streamReader.ReadToEnd();
            }
            return new ContentResult { Content = readContents, ContentType = "text/html" };

        }
    }
}
