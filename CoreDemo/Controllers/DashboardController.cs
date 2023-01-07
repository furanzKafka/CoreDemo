using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            ViewBag.totalBlogCount = bm.GetAll().Count();
            ViewBag.yourBlogCount = bm.GetAllByWriter(1).Count();
            ViewBag.totalCategories = cm.GetAll().Count();
            return View();
        }
    }
}
