using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WhatShouldWeEat.Entities;
using WhatShouldWeEat.Business;

namespace WhatShouldWeEat.WebUI.ViewComponents
{
    public class CommentsViewComponent : ViewComponent
    {
        CommentManager _commentManager = new CommentManager();
        

        public IViewComponentResult Invoke(string foodKey)
        {
            IQueryable<comments> comments = _commentManager.ListQueryable().Where(x => x.fokey == foodKey);
            return View(comments);
        }
    }
}
