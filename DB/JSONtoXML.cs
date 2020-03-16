using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using TECBoxService.Models;

namespace TECBoxService.DB
{
    public static class JSONtoXML
    {
        // Generates xml with the top 25 selled products
        public static void GenerateTop25Products()
        {
            var top25 = new List<Product>();
            var products = DataBaseManager.GetProduct();
            while (top25.Count < 25 && products.Count > 0)
            {
                var top = products.MaxBy(t => t.Sells).First();
                top25.Add(top);
                products.Remove(top);
            }

            GenerateXml(top25, "Top25.xml");
        }
        
        // Generates xml with the packages ready to deliver in certain routeId
        public static void GenerateRoutes(long routeId)
        {
            var route = DataBaseManager.GetRoute()
                .Where(t => t.Id == routeId);
            var packages = DataBaseManager.GetPackage()
                .Where(t => t.RouteId.Equals(routeId) && t.State.Equals("ready"))
                .ToList();
            GenerateXml(packages, "Routes.xml");
        }
        
        // Generates xml with the delivered packages between two dates
        public static void GenerateDelivered(DateTime startDate, DateTime finalDate)
        {
            var packages = DataBaseManager.GetPackage();
            var delivered = packages.Where(t => 
                t.State.Equals("delivered") && 
                t.Deliver > startDate &&
                t.Deliver < finalDate)
                .ToList();
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