using aspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            DateTime zaman = DateTime.Now;
            return View(zaman);
        }
        public ActionResult Liste()
        {
            int[] sayilar = new int[] { 1 , 2 , 3 , 4 , 5};
            return View("List" , sayilar);
        }
        public ActionResult Dersim()
        {
            int id = 101;
            string dersAdi = "Asp.Net 2 MVC Programlama";
            string dersEgitmeni = "Fatma Betül ";
            int dersKredi = 25;
            Ders model = new Ders();
            model.Id = id;
            model.Ad = dersAdi;
            model.Egitmen = dersEgitmeni;
            model.Kredi = dersKredi;
            return View(model);
        }
    }
}