using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WhatShouldWeEat.Business;
using WhatShouldWeEat.Entities;

namespace WhatShouldWeEat.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private CategoryManager _categoryManager = new CategoryManager();

        public ActionResult Index()
        {
            return View(_categoryManager.List());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(categories category)
        {
            if (ModelState.IsValid)
            {
                category.id = null;
                _categoryManager.Insert(category);
                return RedirectToAction("Index");
            }

            return View(category);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return StatusCode(400);
            }
            categories category = _categoryManager.Find(x => x.id == id.Value);
            if (category == null)
            {
                return StatusCode(404);
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(categories category)
        {
            if (ModelState.IsValid)
            {
                categories findCategory = _categoryManager.Find(x => x.id == category.id);
                findCategory.categorykey = category.categorykey;
                findCategory.categoryname = category.categoryname;
                findCategory.categorydesc = category.categorydesc;

                _categoryManager.Update(findCategory);

                return RedirectToAction("Index");
            }
            return View(category);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return StatusCode(400);
            }
            categories category = _categoryManager.Find(x => x.id == id.Value);
            if (category == null)
            {
                return StatusCode(404);
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            categories category = _categoryManager.Find(x => x.id == id);
            _categoryManager.Delete(category);
            return RedirectToAction("Index");
        }
    }
}
