using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OSRS_Charts.Controllers
{
    public class ItemTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}