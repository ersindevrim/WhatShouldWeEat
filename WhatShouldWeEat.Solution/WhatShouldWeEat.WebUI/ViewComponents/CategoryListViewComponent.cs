using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WhatShouldWeEat.Business;
using WhatShouldWeEat.Entities;

namespace WhatShouldWeEat.WebUI.ViewComponents
{
	public class CategoryListViewComponent : ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager();
       
        public IViewComponentResult Invoke(string tip)
        {
            if(tip == "DropDown")
            {
                return View("DropDown",categoryManager.List());
            }

            return View(categoryManager.List());
        }
    }
}
