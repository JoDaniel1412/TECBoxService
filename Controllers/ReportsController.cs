using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Net.Http.Headers;

namespace TECBoxService.Controllers
{
    public class ReportsController : ApiController
    {
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            DB.JSONtoXML.GenerateTop25Products();
            Reports.ReportGenerator.ExportPDF();

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB", "TopProductsReport.pdf");
            var pdf = File.OpenRead(path);

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StreamContent(pdf);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
            return response;
        }

    }
}