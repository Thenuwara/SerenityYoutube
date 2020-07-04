
namespace SerenityApp.Market.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.VisitRow))]
    public class VisitController : Controller
    {
        [Route("Market/Visit")]
        public ActionResult Index()
        {
            return View("~/Modules/Market/Visit/VisitIndex.cshtml");
        }
    }
}