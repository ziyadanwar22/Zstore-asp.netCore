using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Product.Pages
{

    [PageAuthorize(typeof(ProductRow))]
    public class ProductController : Controller
    {
        [Route("Product/Product")]
        public ActionResult Index()
        {
            return View("~/Modules/Product/Product/ProductIndex.cshtml");
        }
    }
}