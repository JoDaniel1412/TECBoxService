using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TECBoxService.Reports
{
    public class ReportGenerator
    {
        private const string path = "";
        public static void ExportPDF()
        {

            TopProductsReport CrReport = new TopProductsReport();

            DiskFileDestinationOptions dest = new DiskFileDestinationOptions();
            dest.DiskFileName = getPath("TopProductsReport.pdf");

            PdfFormatOptions formatOpt = new PdfFormatOptions();
            formatOpt.FirstPageNumber = 0;
            formatOpt.LastPageNumber = 0;
            formatOpt.UsePageRange = false;
            formatOpt.CreateBookmarksFromGroupTree = false;

            ExportOptions ex = new ExportOptions();
            ex.ExportDestinationType = ExportDestinationType.DiskFile;
            ex.ExportDestinationOptions = dest;
            ex.ExportFormatType = ExportFormatType.PortableDocFormat;
            ex.ExportFormatOptions = formatOpt;

            CrReport.Export(ex);
            Console.WriteLine("TopProductsReport");
        }

        private static string getPath(string filename)
        {
            const string subFolder = "DB";
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, subFolder, filename);
        }
    }
}