using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class ProductListComponent:ViewComponent
    {
        IProductService _productService;

        public ProductListComponent(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _productService.GetAll();
            return View(result);
        }
    }
}
