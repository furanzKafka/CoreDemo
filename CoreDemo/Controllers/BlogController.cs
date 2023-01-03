using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetAllWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            ViewBag.Id = id;
            var values = bm.Get(id);
            return View(values);
        }

	}
}
