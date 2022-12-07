using Business.Abstract;
using Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class SliderComponent : ViewComponent
    {
        ISliderService _sliderService;
        public SliderComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
