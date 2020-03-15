using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TECBoxService.Models;

namespace TECBoxService.DB
{
    public class JSONtoXML
    {
        public static void GenerateTop25Products()
        {
            List<Product> top25 = new List<Product>();
            var products = DataBaseManager.GetProduct();
            while (top25.Count < 25 && products.Count > 0)
            {
                Product top = products.MaxBy(t => t.Sells).First();
                top25.Add(top);
                products.Remove(top);
            }

            GenerateXML<Product>(top25, "Top25.xml");
        }

        private static void GenerateXML<T>(List<T> serializable, string filename)
        {
            const string subFolder = "DB";
            var rPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, subFolder, filename);
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (TextWriter writer = new StreamWriter(rPath))
            {
                serializer.Serialize(writer, serializable);
            }
        }
    }

}