using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouqStore.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult xyz()
        {
            return View();
        }
    }
}
