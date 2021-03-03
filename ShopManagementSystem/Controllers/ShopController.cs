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
        public ActionResult LogIn()
        {
            return View();
        }
         [HttpPost] 
        public ActionResult LogIn(string Id,string password)
        {
            
            _shopService.Get(Id);
        }
        public ActionResult List()
        {
            var shops=_shopService.Get();

            return View(shops);
        }
    }
}