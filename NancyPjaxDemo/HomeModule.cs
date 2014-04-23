using System.Linq;
using Nancy;

namespace NancyPjaxDemo
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Before += ctx =>
            {
                ViewBag.IsPjax = Request.Headers.Keys.Contains("X-PJAX");
                return null;
            };

            Get["/"] = p =>
            {
                return View["Index"];
            };

            Get["/first/"] = p =>
            {
                return View["First"];
            };

            Get["/second/"] = p =>
            {
                return View["Second"];
            };
        }
    }
}