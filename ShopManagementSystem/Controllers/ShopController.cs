using System;
using Microsoft.AspNetCore.Mvc;
using ShopManagementSystem.Models;
using ShopManagementSystem.Services;

namespace ShopManagementSystem.Controllers
{
    public class ShopController : Controller
    {
        private readonly ShopService _shopService;

        public ShopController(ShopService shopService)
        {
            _shopService = shopService;
        }
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
       [HttpPost] 

        public ActionResult<string> Register([FromForm]Shop shop)
        {
             _shopService.Create(shop);
            return "Shop added Successfully";
        }
        public ActionResult List()
        {
            var shops=_shopService.Get();

            return View(shops);
        }
        public ActionResult Detail([FromQuery]string id)
        {
             var shop=_shopService.Get(id);

            return View(shop);

        }
        public ActionResult Privacy()
        {
            return View();
        }
    }
}