using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WhatShouldWeEat.Business;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WhatShouldWeEat.WebUI.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RecepyController : Controller
    {
		RecepyManager _recepyManager = new RecepyManager();

        public IActionResult Index()
        {
            return View(_recepyManager.List());
        }
    }
}
