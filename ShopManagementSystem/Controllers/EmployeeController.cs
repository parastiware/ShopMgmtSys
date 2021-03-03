/* using System;
using Microsoft.AspNetCore.Mvc;
using ShopManagementSystem.Models;
using ShopManagementSystem.Services;

namespace ShopManagementSystem.Controllers
{
    public class ShopController : Controller
    {
        private readonly ShopService _empService;

        public ShopController(ShopService empService)
        {
            _empService = empService;
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

        public ActionResult<string> Register([FromForm]Shop employee)
        {
            _empService.Create(employee);
            return "Shop added Successfully";
        }
        public ActionResult List()
        {
            var employees=_empService.Get();

            return View(employees);
        }
        public ActionResult Detail([FromQuery]string id)
        {
             var employee=_empService.Get(id);

            return View(employee);

        }
    }
} */