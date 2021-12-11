using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProjesi.Models;

namespace TestProjesi.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Urunlers.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniUrun()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Urunler p)
        {
            c.Urunlers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunGetir(int id)
        {
            var ur = c.Urunlers.Find(id);
            return View("UrunGetir", ur);
        }

        public ActionResult UrunSil(int id)
        {
            var u = c.Urunlers.Find(id);
            u.UrunDurum = false;
            return RedirectToAction("Index");
        }

        public ActionResult UrunGuncelle(Urunler p)
        {
            var ur = c.Urunlers.Find(p.UrunID);
            ur.UrunAciklama = p.UrunAciklama;
            ur.UrunBaslik = p.UrunAciklama;
            ur.UrunResimURL = p.UrunResimURL;
            ur.UrunKategoriID = p.UrunKategoriID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}