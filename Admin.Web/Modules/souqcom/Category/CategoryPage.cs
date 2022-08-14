using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Admin.souqcom.Pages
{

    [PageAuthorize(typeof(CategoryRow))]
    public class CategoryController : Controller
    {
        [Route("souqcom/Category")]
        public ActionResult Index()
        {
            return View("~/Modules/souqcom/Category/CategoryIndex.cshtml");
        }
    }
}