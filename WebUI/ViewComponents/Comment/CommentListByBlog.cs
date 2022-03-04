using Businness.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        private CommentManager cm = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke()
        {
            var comments = cm.GetAllById(1);
            return View(comments);
        }
    }
}
