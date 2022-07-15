using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agence.Models;
namespace Agence.Controllers
{
    public class VoitureController : Controller
    {
        // GET: Voiture
        public ActionResult Index()
        {
            return View();
        }
    public ActionResult SaveV()
        {
            return View();
        }
       static List<Voiture> car = new List<Voiture>();
    public ActionResult Saved()
        {
            Voiture voiture = new Voiture();
           int  sId = Convert.ToInt32(Request.Form["Id"]);
            string sMatricule = Request.Form["Matricule"];
            string sMarque = Request.Form["Marque"];
            double sPrix = Convert.ToDouble(Request.Form["Prix"]);
            DateTime sDate = DateTime.Now;

           voiture.Id = sId;
           voiture.Matricule = sMatricule;
           voiture.Marque = sMarque;
           voiture.Prix = sPrix;
           voiture.Date_ajout = sDate;
            car.Add(voiture);
            
            /*ViewBag.sId = sId;
            ViewBag.sMatricule = sMatricule;
            ViewBag.sMarque = sMarque;
            ViewBag.sPrix = sPrix;
            ViewBag.sDate = sDate;*/
            return View();
        }
        public ActionResult See()
        {
            ViewBag.car = car;
            return View();
        }
        public ActionResult Find()
        {
            int b=0;
            int fId = Convert.ToInt32(Request.Form["Id"]);
            foreach (var c in car)
            {if(c.Id== fId)
                { ViewBag.fId = c.Id;
            ViewBag.fMatricule = c.Matricule;
            ViewBag.fMarque = c.Marque;
            ViewBag.fPrix = c.Prix;
            ViewBag.fDate = c.Date_ajout;
                    b = 1;
            ViewBag.b = b;
                }
                
            }
            if (b == 0) {
                ViewBag.b = b;
            ViewData["message"] = "Il n'existe pas de vehicule avec cet ID";
            } 
            return View();

        }
        public ActionResult Deleted()
        {
            int dId = Convert.ToInt32(Request.Form["Id"]);
            Voiture v = new Voiture();
            for (int i = 0; i < car.Count; i++)
            {
                if (car[i].Id == dId)
                {
                    v = car[i];
                }
            }
                car.Remove(v);


            return View();
        }
        public ActionResult Recup()
        {
            int uId = Convert.ToInt32(Request.Form["Id"]);
            for (int i = 0; i < car.Count; i++)
            {
                if (car[i].Id == uId)
                {
                    ViewBag.sId = car[i].Id;
                    ViewBag.sMatricule = car[i].Matricule;
                    ViewBag.sMarque = car[i].Marque;
                    ViewBag.sPrix = car[i].Prix;
                    car.Remove(car[i]);

                }
            }
            return View();
        }
        public ActionResult Update()
        {
            Voiture voiture = new Voiture();
            int sId = Convert.ToInt32(Request.Form["Id"]);
            string sMatricule = Request.Form["Matricule"];
            string sMarque = Request.Form["Marque"];
            double sPrix = Convert.ToDouble(Request.Form["Prix"]);
            DateTime sDate = DateTime.Now;

            voiture.Id = sId;
            voiture.Matricule = sMatricule;
            voiture.Marque = sMarque;
            voiture.Prix = sPrix;
            voiture.Date_ajout = sDate;
            car.Add(voiture);
            return View();
        }
       
    }
}