using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CreateDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.Status = true;
            comment.BlogId = 2;
            cm.Add(comment);
            return PartialView();
        }
        public PartialViewResult PartialCommentListByBlogId(int id)
        {
            var values = cm.GetAll(id);
            return PartialView(values);
        }
    }
}
