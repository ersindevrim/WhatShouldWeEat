using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WhatShouldWeEat.Business;
using WhatShouldWeEat.Entities;

namespace WhatShouldWeEat.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DimensionController : Controller
    {
        DimesionManager _dimensionManager = new DimesionManager();

        public ActionResult Index()
        {
            return View(_dimensionManager.List());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(dimensions dimension)
        {
            if (ModelState.IsValid)
            {
                dimension.id = null;
                _dimensionManager.Insert(dimension);
                return RedirectToAction("Index");
            }

            return View(dimension);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return StatusCode(400);
            }
            dimensions dimension = _dimensionManager.Find(x => x.id == id.Value);
            if (dimension == null)
            {
                return StatusCode(404);
            }
            return View(dimension);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(dimensions dimension)
        {
            if (ModelState.IsValid)
            {
                dimensions findDimension = _dimensionManager.Find(x => x.id == dimension.id);
                findDimension.dimkey = dimension.dimkey;
                findDimension.dimname = dimension.dimname;

                _dimensionManager.Update(findDimension);

                return RedirectToAction("Index");
            }
            return View(dimension);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return StatusCode(400);
            }
            dimensions dimension = _dimensionManager.Find(x => x.id == id.Value);
            if (dimension == null)
            {
                return StatusCode(404);
            }
            return View(dimension);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dimensions dimension = _dimensionManager.Find(x => x.id == id);
            _dimensionManager.Delete(dimension);
            return RedirectToAction("Index");
        }
    }
}
