using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using CoreDemo.Models;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var writerValues = wm.Get(1);
            return View(writerValues);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidator validationRules = new WriterValidator();
            ValidationResult result = validationRules.Validate(writer);
            if (result.IsValid)
            {
                wm.Update(writer);
                return RedirectToAction("Dashboard", "Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage addProfileImage)
        {
            Writer writer=new Writer();
            if (addProfileImage.Image!=null)
            {
                var extension = Path.GetExtension(addProfileImage.Image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/WriterImageFiles", newImageName);
                var stream=new FileStream(location, FileMode.Create);
                addProfileImage.Image.CopyTo(stream);
                writer.Image = newImageName;
            }
            writer.Mail=addProfileImage.Mail;
            writer.Name=addProfileImage.Name;
            writer.Password=addProfileImage.Password;
            writer.Status=addProfileImage.Status;
            writer.About=addProfileImage.About;

            wm.Add(writer);
            return RedirectToAction("Index", "Dashboard");            
        }
    }
}
