using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProjesi.Models;

namespace TestProjesi.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Urunler
        Context c = new Context();
        UrunYorum uy = new UrunYorum();
        public ActionResult Index()
        {
            uy.Deger1 = c.Urunlers.ToList();
            uy.Deger3 = c.Urunlers.OrderByDescending(x => x.UrunID).Take(3).ToList();
            return View(uy);
        }

        [AllowAnonymous]
        public ActionResult UrunDetay(int id)
        {
            uy.Deger1 = c.Urunlers.Where(x => x.UrunID == id).ToList();
            uy.Deger2 = c.Yorumlars.Where(x => x.UrunKategoriID == id).ToList();
            return View(uy);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }

        public PartialViewResult Partial1()
        {
            var deger = c.Urunlers.OrderByDescending(x => x.UrunID).ToList();
            return PartialView(deger);
        }
    }
}