using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        public async Task<IActionResult> Index(Writer writer)
        {
            Context c = new Context();
            var dataValue = c.Writers.FirstOrDefault(x => x.Mail == writer.Mail && x.Password == writer.Password);
            if (dataValue != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, writer.Mail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View();
            }
            //         Context c = new Context();
            //         var dataValue=c.Writers.FirstOrDefault(x=>x.Mail==writer.Mail&& x.Password==writer.Password);
            //         if (dataValue!=null)
            //         {
            //             HttpContext.Session.SetString("username", writer.Mail);
            //             return RedirectToAction("Index","Blog");
            //         }
            //         else
            //         {
            //	return View();
            //}
        }
    }
}
