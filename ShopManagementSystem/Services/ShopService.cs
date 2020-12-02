using ShopManagementSystem.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace ShopManagementSystem.Services
{
    public class ShopService
    {
        private readonly IMongoCollection<Shop> _shops;

        public ShopService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("ShopManagementSystemDB"));
            var database = client.GetDatabase("ShopManagementSystemDB");

            _shops = database.GetCollection<Shop>("ShopManagementSystemCollection");
        }

        public List<Shop> Get() =>
            _shops.Find(shop => true).ToList();

        public Shop Get(string id) =>
            _shops.Find<Shop>(shop => shop.Id == id).FirstOrDefault();

        public Shop Create(Shop shop)
        {
            _shops.InsertOne(shop);
            return shop;
        }

        public void Update(string id, Shop shopIn) =>
            _shops.ReplaceOne(shop => shop.Id == id, shopIn);

        public void Remove(Shop shopIn) =>
            _shops.DeleteOne(shop => shop.Id == shopIn.Id);

        public void Remove(string id) => 
            _shops.DeleteOne(shop => shop.Id == id);
    }
}