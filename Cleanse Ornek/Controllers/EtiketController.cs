using Cleanse_Ornek.Models.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cleanse_Ornek.Controllers
{
    public class EtiketController : Controller
    {
        // GET: Etiket
        DataContext con = new DataContext();
        public ActionResult Index(int id)
        {
            return View(id);
        }
        public ActionResult MakaleListele(int id)
        {
            var etiket = con.Makales.Where(x => x.Etikets.Any(y => y.id == id));

            return View("MakaleListele",etiket);
        }

    }
}