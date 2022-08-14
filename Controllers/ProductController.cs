using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SouqStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouqStore.Controllers
{
    public class ProductController : Controller
    {
        ZSTOREContext db = new ZSTOREContext();

        public IActionResult Index()
        {
            var list = db.Category.Select(x => new { x.Id, x.Name }).ToList();
            ViewBag.Catlist = new SelectList(list, "Id", "Name");
            return View();
        }
        //https://localhost:44356/Product/getAllProducts
        public IActionResult getAllProducts()
        {
           
            return Ok(db.Product.Select(x => new { x.Name, x.Price, x.Quntity }).ToList());
        }
        public IActionResult Charts()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductVm model)
        {
            if (ModelState.IsValid)
            {
                ZSTOREContext db = new ZSTOREContext();
                Category c = new Category();
                c.Name = model.CatName;
                db.Category.Add(c);

                db.Product.Add(new Product
                {
                    Name = model.ProName,
                    Price = model.Proprice,
                    Quntity = (int?)model.ProQty,
                    Cat = c
                }) ;
                db.SaveChanges();
                return View("Index");
            }
            return View("Index",model);
        }
    }
}
