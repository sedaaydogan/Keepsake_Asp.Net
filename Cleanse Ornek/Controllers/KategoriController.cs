using Cleanse_Ornek.Models.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cleanse_Ornek.Controllers
{
    public class KategoriController : Controller
    {
        DataContext con = new DataContext();
        // GET: Kategori
     
        public ActionResult Index(int id)
        {
          
            return View(id);
        }
        public ActionResult MakaleListele(int id)
        {
            var cat = con.Makales.Where(m => m.kategoriId == id);
            return View("MakaleListele", cat);
        }
    }
}