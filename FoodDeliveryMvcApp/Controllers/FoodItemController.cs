using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryMvcApp.BusinessLayer.Interface;
using FoodDeliveryMvcApp.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryMvcApp.Controllers
{
    public class FoodItemController : Controller
    {
        private readonly IRestorentService _service;
        public FoodItemController(IRestorentService service)
        {
            _service = service;
        }
        // GET: FoodItem
        public ActionResult OrderFood()
        {
            return View();
        }
        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> OrderFood(FoodIteam fooditem)
        {
            try
            {
                await _service.FooditemCreateAsync(fooditem);
                return RedirectToAction("GetRestorentDetails", "Admin");
            }
            catch
            {
                return View();
            }
        }

    }
}