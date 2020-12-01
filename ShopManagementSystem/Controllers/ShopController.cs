using System;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using ShopManagementSystem.Models;
namespace ShopManagementSystem.Controllers
{
    class ShopController : Controller
    {
        private IMongoCollection<Shop> _shop;

        public ShopController(IShopManagementSystemDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _shop = database.GetCollection<Shop>(settings.CollectionName);
        }
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Register()
        {

            return View();
        }
        public ActionResult List()
        {

            return View();
        }
    }
}