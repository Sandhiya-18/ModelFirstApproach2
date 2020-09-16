using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelFirstApproach2.Controllers
{
    public class HomeController : Controller
    {
        EFModelFirstContainer context = new EFModelFirstContainer();
        public ActionResult Index()
        {

            return View(context.Products.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}