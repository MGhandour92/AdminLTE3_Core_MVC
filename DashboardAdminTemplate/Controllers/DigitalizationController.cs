using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardAdminTemplate.Controllers
{
    public class DigitalizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
