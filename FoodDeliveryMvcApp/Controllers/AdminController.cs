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
    public class AdminController : Controller
    {
        private readonly IRestorentService _service;
        public AdminController(IRestorentService service)
        {
            _service = service;
        }
        // GET: Admin
        public ActionResult GetRestorentDetails()
        {

            return View();
        }
        public ActionResult AddRestorents()
        {

            return View();
        }
        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddRestorents(Restorents restorent)
        {
            try
            {
                var restornets = await _service.RestorentCreateAsync(restorent);
            
                return RedirectToAction("GetRestorentDetails", "Admin");
            }
            catch
            {
                return View();
            }
        }

    }
}