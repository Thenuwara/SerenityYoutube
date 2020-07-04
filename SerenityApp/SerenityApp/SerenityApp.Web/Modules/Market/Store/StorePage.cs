
namespace SerenityApp.Market.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.StoreRow))]
    public class StoreController : Controller
    {
        [Route("Market/Store")]
        public ActionResult Index()
        {
            return View("~/Modules/Market/Store/StoreIndex.cshtml");
        }
    }
}