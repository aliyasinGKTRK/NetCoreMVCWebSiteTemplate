using Microsoft.AspNetCore.Mvc;

namespace WebUIMVC.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
