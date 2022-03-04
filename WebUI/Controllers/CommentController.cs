using Businness.Concrete;
using DataAccess.EntityFramework;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class CommentController : Controller
    {
        private CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PartialAddComment()
        {
            return View();
        }

        public IActionResult CommentListByBlog(int id)
        {
            var values = cm.GetAllById(id);
            return View(values);
        }
    }
}
