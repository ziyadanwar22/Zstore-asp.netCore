using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SouqStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SouqStore.Controllers
{
    public class HomeController : Controller
    {
        ZSTOREContext db = new ZSTOREContext();
        public IActionResult Index()
        {
            indrxVm res = new indrxVm();
             res.products = db.Product.ToList();
             res.Reviews = db.Review.ToList();
             res.Categories = db.Category.ToList();
            res.LatestProduct = db.Product.OrderByDescending(x => x.EntryDate).Take(4).ToList();
            return View(res);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Review()
        {
            return View();
        }
        public IActionResult Categories()
        {
             var res=db.Category.ToList();
            ViewBag.isAdmin = true;
            return View(res);
        }

        public IActionResult Products(int id)
        {
            var res = db.Product.Where(x=> x.Catid==id).ToList();
            return View(res);
        }
        public IActionResult currentProduct(int id)
        {
            var res = db.Product.Include(x=>x.Cat).Include(x=>x.ProductImage).FirstOrDefault(x => x.Id == id);
            return View(res);
        }
        [HttpGet]
        public IActionResult ProductSearch(string xname)
        {
            var products = new List<Product>();

            if (string.IsNullOrEmpty(xname))
                products = db.Product.ToList();
            else
            products = db.Product.Where(x => x.Name.Contains(xname)).ToList();
            return View(products);
        }
       
        [HttpPost]
        public IActionResult SaveContact(Review model)
        {
            db.Review.Add(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
