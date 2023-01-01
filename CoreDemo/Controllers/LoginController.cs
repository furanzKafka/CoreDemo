using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
		[AllowAnonymous]
		[HttpPost]
        public IActionResult Index(Writer writer)
        {
            Context c = new Context();
            var dataValue=c.Writers.FirstOrDefault(x=>x.Mail==writer.Mail&& x.Password==writer.Password);
            if (dataValue!=null)
            {
                HttpContext.Session.SetString("username", writer.Mail);
                return RedirectToAction("Index","Blog");
            }
            else
            {
				return View();
			}
		}
    }
}
