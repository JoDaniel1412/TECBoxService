using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Net.Http.Headers;
using TECBoxService.Reports;

namespace TECBoxService.Controllers
{
    public class ReportController : ApiController
    {
        private const string SubFolder = "DB";
        
        /**
         * GET api/report?type={type}
         * types:
         *     top25
         *     route 
         *     delivered
         */
        public HttpResponseMessage Get(string type)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            switch (type)
            {
                case "top25":
                    GetTop25(response);
                    break;
                case "route":
                    var routeId = Convert.ToInt64(Request.Headers.GetValues("routeId").First());
                    GetRoute(response, routeId);
                    break;
                case "delivered":
                    var startDate = Convert.ToDateTime(Request.Headers.GetValues("startDate").First());
                    var finalDate = Convert.ToDateTime(Request.Headers.GetValues("finalDate").First());
                    GetDelivered(response, startDate, finalDate);
                    break;
                default:
                    response = Request.CreateResponse(HttpStatusCode.BadRequest);
                    break;
            }
            
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
            return response;
        }

        private static void GetTop25(HttpResponseMessage response)
        {
            const string filename = "TopProductsReport.pdf";
            DB.JSONtoXML.GenerateTop25Products();
            ReportGenerator.ExportPdf(filename, new TopProductsReport());
            FindPdf(response, filename);
        }

        private static void GetRoute(HttpResponseMessage response, long routeId)
        {
            const string filename = "RouteReport.pdf";
            DB.JSONtoXML.GenerateRoutes(routeId);
            ReportGenerator.ExportPdf(filename, new RouteReport());
            FindPdf(response, filename);
        }
        
        private static void GetDelivered(HttpResponseMessage response, DateTime startDate, DateTime finalDate)
        {
            const string filename = "DeliveredReport.pdf";
            DB.JSONtoXML.GenerateDelivered(startDate, finalDate);
            ReportGenerator.ExportPdf(filename, new DeliveredReport());
            FindPdf(response, filename);
        }

        private static void FindPdf(HttpResponseMessage response, string filename)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SubFolder, filename);
            var pdf = File.OpenRead(path);
            response.Content = new StreamContent(pdf);
        }
    }
}