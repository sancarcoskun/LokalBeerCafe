using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LokaLBeer.Models;

namespace LokaLBeer.Controllers
{
    
    public class HomeController : Controller
    {
       // [AllowCrossDomain]
        LokalBeerCafeContext lokal_context = new LokalBeerCafeContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";
            var iletisim_liste = lokal_context.iletisims.ToList();

            return View(iletisim_liste);
        }

        [HttpPost]
        public ActionResult Contact(kullanici_iletisim_mesaj ilet)
        {
          //  context.Kategori.Add(kat);
            lokal_context.kullanici_iletisim_mesaj.Add(ilet);
            lokal_context.SaveChanges();
            return RedirectToAction("/Contact");
        }
        // sasasasa


    }
}