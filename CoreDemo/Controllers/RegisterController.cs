using BuisnessLayer.Concrete;
using BuisnessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		//HttpGet ve HttpPost attributelrinin tanımlandigi metotlar aynı adda olmalidir.
		//HttpGet --> Sayfa yüklenince
		//HttpPost--> Buton tetiklenince çalışır

		WriterManager wm = new WriterManager(new EfWriterRepository());
		[HttpGet]	
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidator wv = new WriterValidator();
			ValidationResult results = wv.Validate(p);
			if (results.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "deneme";
				wm.WriterAdd(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
