using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using TECBoxService.Models;
using TECBoxService.DB;

namespace TECBoxService.DB
{
    public static class JSONtoXML
    {
        // Generates xml with the top 25 selled products
        public static void GenerateTop25Products()
        {
            var top25 = DataBaseManager.GetTop25Products();
            GenerateXml(top25, "Top25.xml");
        }
        
        // Generates xml with the packages ready to deliver in certain routeId
        public static void GenerateRoutes(long routeId)
        {
            var packages = DataBaseManager.GetRoutesReport(routeId);
            GenerateXml(packages, "Routes.xml");
        }
        
        // Generates xml with the delivered packages between two dates
        public static void GenerateDelivered(DateTime startDate, DateTime finalDate)
        {
            var delivered = DataBaseManager.GetDelivered(startDate, finalDate);
            GenerateXml(delivered, "Delivered.xml");
        }
        
        private static void GenerateXml<T>(List<T> serializable, string filename)
        {
            const string subFolder = "DB";
            var rPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, subFolder, filename);
            var serializer = new XmlSerializer(typeof(List<T>));
            using (TextWriter writer = new StreamWriter(rPath))
            {
                serializer.Serialize(writer, serializable);
            }
        }
    }

}