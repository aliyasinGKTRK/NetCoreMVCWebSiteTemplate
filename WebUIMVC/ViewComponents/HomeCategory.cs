using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUIMVC.ViewComponents
{
	public class HomeCategory:ViewComponent
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

		public IViewComponentResult Invoke()
		{
			var result = categoryManager.GetAll();
			return View(result);
		}
	}
}
