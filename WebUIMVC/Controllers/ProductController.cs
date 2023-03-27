using Microsoft.AspNetCore.Mvc;

namespace WebUIMVC.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
