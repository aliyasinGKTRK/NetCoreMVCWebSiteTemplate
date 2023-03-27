using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUIMVC.Controllers.Admin
{
	public class AdminController : Controller
	{ 
		ProductManager productManager = new ProductManager(new EfProductDal());
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
		ContactManager contactManager = new ContactManager(new EfContactDal());
		AboutManager aboutManager = new AboutManager(new EfAboutDal());
		SliderManager sliderManager = new SliderManager(new EfSliderDal());



		#region Product

		#endregion



		#region Category


		#endregion



		#region Contact

		#endregion



		#region About

		#endregion



		#region Slider

		#endregion


	}
}
