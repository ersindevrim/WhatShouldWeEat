using Microsoft.AspNetCore.Mvc;
using WhatShouldWeEat.Business;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WhatShouldWeEat.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private CategoryManager cm = new CategoryManager();

        public IActionResult Index()
        {
            return View(cm.List());
        }
    }
}
