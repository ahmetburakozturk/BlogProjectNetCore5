using Businness.ValidationRules;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        
        public IActionResult Index()
        {
            var values= cm.GetAll();
            return View(values);
        }
    }
}
