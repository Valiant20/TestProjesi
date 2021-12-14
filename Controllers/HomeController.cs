using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProjesi.Models;

namespace TestProjesi.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var deger = c.Urunlers.OrderByDescending(x=>x.UrunID).Take(4).ToList();
            return PartialView(deger);
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