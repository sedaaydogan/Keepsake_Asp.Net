using Cleanse_Ornek.Models.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cleanse_Ornek.Controllers
{
    public class HomeController : Controller
    {
        DataContext con = new DataContext(); 
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryTag()
        {
            var cat = con.Kategoris.ToList();

            return View(cat);
        }

        public ActionResult LastPost()
        {
            ViewBag.fresh = con.Makales.OrderByDescending(m => m.goruntulenme).Take(5);
            ViewBag.populer =con.Makales.OrderByDescending(m=>m.yayinTarihi).Take(5);

            return View();
        }
        public ActionResult BlogTag()
        {
            var tag = con.Etikets.ToList();

            return View(tag);
        }

        public ActionResult TumMakaleGetir()
        {
            var mak = con.Makales.ToList();
            return View("MakaleListele",mak);
        }
    }
}