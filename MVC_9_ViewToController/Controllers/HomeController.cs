using MVC_9_ViewToController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_9_ViewToController.Controllers
{
    public class HomeController : Controller
    {
        static List<Urun> urunListesi;
        public HomeController()
        {
            if (urunListesi != null)
            {
                return;
            }
            urunListesi = new List<Urun>
            {
                new Urun{urunID=1,urunAdi="Gofret", fiyat=2, stokMiktari=20 },
                new Urun{urunID=2, urunAdi="Kraker", fiyat=1, stokMiktari=5 },
                new Urun{urunID=3, urunAdi="Kek", fiyat=3, stokMiktari=5 },
            };
        }

        public ActionResult Index()
        {
            return View(urunListesi);
        }

        public ActionResult Ekle()
        {
            return View();
        }

        public ActionResult UrunEkle(Urun model)
        {
            urunListesi.Add(model);
            return RedirectToAction("Index");
        }
    }
}