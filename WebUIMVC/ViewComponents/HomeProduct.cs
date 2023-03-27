using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUIMVC.ViewComponents
{
	public class HomeProduct:ViewComponent
	{
		ProductManager productManager = new ProductManager(new EfProductDal());

		public IViewComponentResult Invoke()
		{
			var result = productManager.GetAll();
			return View(result);
		}
	}
}
