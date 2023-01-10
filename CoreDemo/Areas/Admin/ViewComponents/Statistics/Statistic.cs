using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        ContactManager cm=new ContactManager(new EfContactRepository());
        CommentManager commentManager=new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.blogCount = bm.GetAll().Count;
            ViewBag.contactCount = cm.GetAll().Count;
            ViewBag.commentCount = commentManager.GetAll().Count;

            string myWeatherAPI = "7b054f311eb8bfb41a0a80d056c01a79";
            //string myConnection = "https://api.openweathermap.org/data/2.5/weather?q=London&appid="+myWeatherAPI;
            string myConnection = "https://api.openweathermap.org/data/2.5/weather?q=London&mode=xml";
            XDocument document=XDocument.Load(myConnection);
            ViewBag.temperature = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}
