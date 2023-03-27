using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System.Globalization;
using System.IO;
using WebUI.Models;
using static System.Net.WebRequestMethods;

namespace WebUI.Controllers.Admin
{
    public class AdminController : Controller
    {
        DataAccess.AppContext context= new DataAccess.AppContext();
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        ContactManager contactManager = new ContactManager(new EfContactDal());
        GalleryManager galleryManager = new GalleryManager(new EfGalleryDal());
        ProductManager productManager = new ProductManager(new EfProductDal());
        ReferanceManager referanceManager = new ReferanceManager(new EfReferanceDal());
        BySeviceManager serviceManager = new BySeviceManager(new EfServiceDal());
        SliderManager sliderManager = new SliderManager(new EfSliderDal());


        //About
        #region About
        // About Start
        public IActionResult AboutList()
        {
            var result = aboutManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult AboutAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AboutAdd(About about)
        {

            aboutManager.Add(about);

            return RedirectToAction("AboutList", "Admin");
        }

        public IActionResult AboutDelete(int id)
        {

            var result = aboutManager.GetById(id);
            aboutManager.Delete(result);
            return RedirectToAction("AboutList", "Admin");
        }

        [HttpGet]
        public IActionResult AboutEdit(int id)
        {
            var result = aboutManager.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult AboutEdit(About about)
        {
            aboutManager.Update(about);
            return View("AboutList", "Admin");
        }
        #endregion


        // Category 
        #region Category

        public IActionResult CategoryList()
        {
            var result = categoryManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }



        [HttpPost]
        public IActionResult CategoryAdd(CategoryAdd item)
        {
            Category category = new Category();
            if (item.ImagePath != null)
            {
                var extension = Path.GetExtension(item.ImagePath.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/urunler/" + newguid);

                var stream = new FileStream(location, FileMode.Create);

                item.ImagePath.CopyTo(stream);
                category.ImagePath = newguid;

            }
            category.Name=item.Name;


            categoryManager.Add(category);
            return RedirectToAction("CategoryList");
        }

        public IActionResult CategoryDelete(int id)
        {
            var result = categoryManager.GetById(id);
            categoryManager.Delete(result);
            return View("CategoryList");
        }

        public IActionResult CategoryEdit()
        {
            return View();
        }
        #endregion


        //Contact 
        #region Contact

        public IActionResult ContactList()
        {
            var result = categoryManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult ContactAdd()
        {

            return View();
        }

        [HttpPost]
        public IActionResult ContactAdd(Contact contact)
        {
            contactManager.Add(contact);
            return RedirectToAction("ContactList");
        }


        public IActionResult ContactDelete(int id)
        {
            var result = contactManager.GetById(id);
            contactManager.Delete(result);
            return RedirectToAction("ContactList");
        }

        #endregion

        // Gallery
        #region Gallery
        public IActionResult GalleryList()
        {
            var result = galleryManager.GetAll();

            return RedirectToAction("result");
                 
        }

        [HttpGet]
        public IActionResult GalleryAdd( )
        {

            return View();
        }

        [HttpPost]
        public IActionResult GalleryAdd(Gallery gallery)
        {
            galleryManager.Add(gallery);
            return RedirectToAction("GalleryList");
        }


        public IActionResult GalleryDelete(int id)
        {
            var result = galleryManager.GetById(id);
            return View(result);
        }

        #endregion

        // Products

        #region Products
        public IActionResult ProductAdminList()
        {
            var result = productManager.GetAll();
            return View(result);
        }


        [HttpGet]
        public IActionResult ProductAdd()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> categoryValues = (from x in cm.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }



        [HttpPost]
        public IActionResult ProductAdd(ProductAdd product)
        {

            Product p = new Product();
            if (product.ImagePath != null)
            {
                var extension = Path.GetExtension(product.ImagePath.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/urunler/" + newguid);

                var stream = new FileStream(location, FileMode.Create);

                product.ImagePath.CopyTo(stream);
                p.ImagePath = newguid;

            }


            p.ProductName = product.ProductName;
            productManager.Add(p);
            return RedirectToAction("ProductAdminList", "Admin");

        }




        public async Task<ActionResult> ProductEdit(int id)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> categoryValues = (from x in cm.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            Product item = await context.Products.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);

        }
        [HttpPost]
        public async Task<ActionResult> ProductEdit(ProductAdd item)
        {
            Product product = new Product();
            if (ModelState.IsValid)
            {
                if (item.ImagePath != null)
                {
                    var extension = Path.GetExtension(item.ImagePath.FileName);
                    var newguid = Guid.NewGuid() + extension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/urunler/" + newguid);

                    var stream = new FileStream(location, FileMode.Create);

                    item.ImagePath.CopyTo(stream);
                    product.ImagePath = newguid;

                }


                product.ProductName = item.ProductName;
                context.Update(product);
                await context.SaveChangesAsync();

                TempData["Success"] = "The item has been updated!";

                return RedirectToAction("ProductAdminList");
            }

            return View(item);
        }

        public IActionResult ProductDelete(int id)
        {

            var result =productManager.GetById(id);
            productManager.Delete(result);
            return RedirectToAction("ProductAdminList");
        }

        #endregion
    }
}
