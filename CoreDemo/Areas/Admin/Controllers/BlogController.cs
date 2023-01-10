using BusinessLayer.Concrete;
using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("blog listtesi");
                workSheet.Cell(1, 1).Value = "blog id";
                workSheet.Cell(1, 2).Value = "blog adi";

                int blogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    workSheet.Cell(blogRowCount, 1).Value = item.BlogId;
                    workSheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"dnn{DateTime.Now.TimeOfDay.ToString()}.xlsx");
                }
            }
        }
        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
            new BlogModel{BlogId=1,BlogName="qweqwe" } ,
            new BlogModel{BlogId=2,BlogName="qweqwqeqwe" }
            };
            return bm;
        }
        public IActionResult BlogListExcel()
        {
            return View();
        }
        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("blog listesi");

                workSheet.Cell(1, 1).Value = "blof id";
                workSheet.Cell(1, 2).Value = "blag adi";

                int blogRowCount = 2;

                foreach (var item in BlogTitleList())
                {
                    workSheet.Cell(blogRowCount, 1).Value = item.BlogId;
                    workSheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"dnn{DateTime.Now.TimeOfDay.ToString()}.xlsx");
                }
            }
        }
        public List<BlogModel> BlogTitleList()
        {
            List<BlogModel> bm = new List<BlogModel>();
            bm = blogManager.GetAll().Select(x => new BlogModel
            {
                BlogId = x.Id,
                BlogName = x.Title
            }).ToList();
            return bm;
        }
    }
}
