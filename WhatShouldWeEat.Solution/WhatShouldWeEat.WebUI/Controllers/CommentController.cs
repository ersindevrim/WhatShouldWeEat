using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WhatShouldWeEat.Business;
using WhatShouldWeEat.Entities;

namespace WhatShouldWeEat.WebUI.Controllers
{
    public class CommentController : Controller
    {
        CommentManager _commentManager = new CommentManager();

        public IActionResult Index()
        {
            return View();
        }

		public ActionResult GetComments(string foodKey)
        {
            IQueryable<comments> comments = _commentManager.ListQueryable().Where(x => x.fokey == foodKey);
            return View(comments);
		}

    }
}
