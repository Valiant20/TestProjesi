using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProjesi.Models;

namespace TestProjesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Urunlers.Take(4).ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();
        }


    }
}