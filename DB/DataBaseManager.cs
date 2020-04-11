using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TECBoxService.Models;

namespace TECBoxService.DB
{
    // Class to deserialize the DB to Modules
    public static class DataBaseManager
    {
        public static List<Employee> GetEmployees() => Deserialize<List<Employee>>("Employee.json");
        public static List<Seller> GetSellers() => Deserialize<List<Seller>>("Seller.json");
        public static List<Client> GetClient() => Deserialize<List<Client>>("Client.json");
        public static List<Place> GetPlace() => Deserialize<List<Place>>("Place.json");
        public static List<Role> GetRole() => Deserialize<List<Role>>("Role.json");
        public static List<Subsidiary> GetSubsidiary() => Deserialize<List<Subsidiary>>("Subsidiary.json");
        public static List<Bill> GetBill() => Deserialize<List<Bill>>("Bill.json");
        public static List<Route> GetRoute() => Deserialize<List<Route>>("Route.json");
        public static List<Product> GetProduct() => Deserialize<List<Product>>("Product.json");
        public static List<Package> GetPackage() => Deserialize<List<Package>>("Package.json");

        // Generates xml with the top 25 selled products
        public static List<Product> GetTop25Products()
        {
            var top25 = new List<Product>();
            var products = DataBaseManager.GetProduct();
            while (top25.Count < 25 && products.Count > 0)
            {
                var top = products.MaxBy(t => t.Sells).First();
                top25.Add(top);
                products.Remove(top);
            }

            return top25;
        }

        public static List<Package> GetRoutesReport(long routeId)
        {
            var route = GetRoute()
                .Where(t => t.Id == routeId);
            var packages = GetPackage()
                .Where(t => t.RouteId.Equals(routeId) && t.State.Equals("ready"))
                .ToList();
            return packages;
        }

        public static List<Package> GetDelivered(DateTime startDate, DateTime finalDate)
        {
            var packages = DataBaseManager.GetPackage();
            var delivered = packages.Where(t =>
                t.State.Equals("delivered") &&
                t.Deliver > startDate &&
                t.Deliver < finalDate)
                .ToList();
            return delivered;
        }

        private static T Deserialize<T>(string path)
        {
            const string subFolder = "DB";
            var rPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, subFolder, path);
            var json = File.ReadAllText(rPath);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }
    }
}