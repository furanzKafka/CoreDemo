using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
