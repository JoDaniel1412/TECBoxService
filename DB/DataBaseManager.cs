using System;
using System.Collections.Generic;
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
        public static List<Subsidiary> GetSubsidiary() => Deserialize<List<Subsidiary>>("Subsidiary.json");
        public static List<Bill> GetBill() => Deserialize<List<Bill>>("Bill.json");
        public static List<Route> GetRoute() => Deserialize<List<Route>>("Route.json");
        public static List<Product> GetProduct() => Deserialize<List<Product>>("Product.json");
        public static List<Package> GetPackage() => Deserialize<List<Package>>("Package.json");
        public static T Deserialize<T>(string file) => Newtonsoft.Json.JsonConvert.DeserializeObject<T>(file);
    }
}