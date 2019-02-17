using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WhatShouldWeEat.Business;

namespace WhatShouldWeEat.WebUI.ViewComponents
{
    public class FoodsViewComponent : ViewComponent
    {
        FoodManager _foodManager = new FoodManager();
       
        public IViewComponentResult Invoke(string tip)
        {
            if(tip == "TopEight")
            {
                return View("DropDown", _foodManager.ListQueryable().Take(8));
            }

            return View(_foodManager.List());
        }
    }
}
