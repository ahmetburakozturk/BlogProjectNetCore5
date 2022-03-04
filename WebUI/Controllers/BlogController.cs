using Businness.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class BlogController : Controller
    {
        private BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetListWithCategories();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            var value = bm.Get(id);
            return View(value);
        }
    }
}
