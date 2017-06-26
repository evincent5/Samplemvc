using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Schoolmc1.Common;


namespace Samplemvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult About(List<string> countryNames)
        {
            ViewBag.Message = "Your application description page.";

            return View(countryNames);
        }

        [OutputCache(CacheProfile = "1MinuteCache")]
        public PartialViewResult Contact()
        {
            //System.Threading.Thread.Sleep(3000);
            ViewBag.Message = "Your contact page.";

            return PartialView();
        }
        [RequireHttps]
        public string Test()
        {
            return "This method should be accessed only using HTTPS protocol";
        }

        [TrackExecutionTime]
        public string Track()
        {
            return "Track action invoked";
        }

        [TrackExecutionTime]
        public string Welcome()
        {
            throw new Exception("Exception Occured");
        }

    }
}