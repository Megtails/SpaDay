using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {

            if (newUser.Password == verify)
            {
                ViewBag.user = newUser.Name;
                return View("/index");
            }
            else
            {
                return View("/add");
            }
        }
    }

}