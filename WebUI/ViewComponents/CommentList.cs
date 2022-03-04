using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment()
                {
                    Id = 1,
                    Username = "ztrkabrk"
                },
                new UserComment()
                {
                    Id = 2,
                    Username = "darksoldier"
                },
                new UserComment()
                {
                    Id = 3,
                    Username = "merveyalin"
                }
            };
            return View(commentValues);
        }
    }
}
