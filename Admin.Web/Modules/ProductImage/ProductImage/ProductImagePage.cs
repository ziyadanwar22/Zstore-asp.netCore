using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Admin.ProductImage.Pages
{

    [PageAuthorize(typeof(ProductImageRow))]
    public class ProductImageController : Controller
    {
        [Route("ProductImage/ProductImage")]
        public ActionResult Index()
        {
            return View("~/Modules/ProductImage/ProductImage/ProductImageIndex.cshtml");
        }
    }
}