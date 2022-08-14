using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Admin.souqcom.Pages
{

    [PageAuthorize(typeof(CartRow))]
    public class CartController : Controller
    {
        [Route("souqcom/Cart")]
        public ActionResult Index()
        {
            return View("~/Modules/souqcom/Cart/CartIndex.cshtml");
        }
    }
}