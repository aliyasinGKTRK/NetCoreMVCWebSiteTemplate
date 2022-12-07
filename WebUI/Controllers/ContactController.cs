using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class ContactController : Controller
    {
        IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
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
    }
}
