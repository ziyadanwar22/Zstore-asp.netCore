using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Review.Pages
{

    [PageAuthorize(typeof(ReviewRow))]
    public class ReviewController : Controller
    {
        [Route("Review/Review")]
        public ActionResult Index()
        {
            return View("~/Modules/Review/Review/ReviewIndex.cshtml");
        }
    }
}