using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FoodDeliveryMvcApp.BusinessLayer.Interface;
using FoodDeliveryMvcApp.Entities;

namespace FoodDeliveryMvcApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        /// <summary>
        /// return to view user login form
        /// </summary>
        /// <returns></returns>
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// return to View user signup form
        /// </summary>
        /// <returns></returns>

        // GET: User/SignUp
        public ActionResult SignUp()
        {
            return View();
        }

        /// <summary>
        /// Send User login details to service\
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        // POST: User/LoginUser
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoginUser(Login login)
        {
            try
            {
                await _service.UserloginReadAsync(login);

                return RedirectToAction("GetRestorentDetails", "Admin");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// Send Userregister details to service
        /// </summary>
        /// <param name="signup"></param>
        /// <returns></returns>

        // POST: User/RegisterUser
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SignUp(SignUp signup)
        {
            try
            {
                // TODO: Add insert logic here
                await _service.UserSignUpCreateAsync(signup);

                return RedirectToAction("Login", "User");
            }
            catch
            {
                return View();
            }
        }
    }
}