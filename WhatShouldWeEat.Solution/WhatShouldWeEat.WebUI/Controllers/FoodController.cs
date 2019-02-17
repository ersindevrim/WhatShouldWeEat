using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WhatShouldWeEat.Business;
using WhatShouldWeEat.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WhatShouldWeEat.WebUI.Controllers
{
    public class FoodController : Controller
    {
        private FoodManager _foodManager = new FoodManager();
        private CategoryManager _categoryManager = new CategoryManager();
        private RateManager _rateManager = new RateManager();

        private Int16 say = 0;
        private Double puan = 0;

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(_foodManager.List());
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.Categories = _categoryManager.List();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(foods food)
        {
            if (ModelState.IsValid)
            {
                food.id = null;
                _foodManager.Insert(food);
                return RedirectToAction("Index");
            }

            return View(food);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return StatusCode(400);
            }
            foods food = _foodManager.Find(x => x.id == id.Value);
            ViewBag.Categories = _categoryManager.List();
            if (food == null)
            {
                return StatusCode(404);
            }
            return View(food);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(foods food)
        {
            if (ModelState.IsValid)
            {
                foods findFood = _foodManager.Find(x => x.id == food.id);
                findFood.foodkey = food.foodkey;
                findFood.foodname = food.foodname;
                findFood.categorykey = food.categorykey;
                findFood.isapproved = food.isapproved;

                _foodManager.Update(findFood);

                return RedirectToAction("Index");
            }
            return View(food);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return StatusCode(400);
            }
            foods food = _foodManager.Find(x => x.id == id.Value);
            if (food == null)
            {
                return StatusCode(404);
            }
            return View(food);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            foods food = _foodManager.Find(x => x.id == id);
            _foodManager.Delete(food);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return StatusCode(400);
            }

            foods food = _foodManager.Find(x => x.id == id.Value);
            ViewBag.Categories = _categoryManager.List();
            IQueryable<stars> rate = _rateManager.ListQueryable().Where(x => x.fokey == food.foodkey); // TODO: Var i değiştir.

            foreach (var item in rate)
            {
                puan = puan + item.rate;
                say++;
            }
            ViewBag.Rate = puan / say;
           
            if (food == null)
            {
                return StatusCode(404);
            }
            return View(food);
        }
    }
}
