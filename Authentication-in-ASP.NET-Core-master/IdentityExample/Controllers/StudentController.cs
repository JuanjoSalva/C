using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using IdentityExample.Data;

namespace IdentityExample.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
    }
}