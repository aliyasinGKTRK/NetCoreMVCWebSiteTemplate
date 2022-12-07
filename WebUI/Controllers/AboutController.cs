using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AboutController : Controller
    {
       IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexDe()
        {
            return View();
        }

        public IActionResult IndexEng()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AboutAdd()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AboutAdd(About about)
        {
            return RedirectToAction("AdminList","About");
        }

        public IActionResult AdminList()
        {
            return View();
        }




    }
}
