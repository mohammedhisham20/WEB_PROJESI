using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_PROJESI.Models;

namespace WEB_PROJESI.Controllers
{
    
    public class AdminController : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
