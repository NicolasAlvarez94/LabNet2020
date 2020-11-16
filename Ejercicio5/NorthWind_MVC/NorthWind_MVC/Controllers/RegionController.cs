using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Logica;


namespace NorthWind_MVC.Controllers
{
    public class RegionController : Controller
    {
        private readonly RegionLogica objRegionLogica = new RegionLogica(); 

        public ActionResult Index() {         
            var listaRegiones = objRegionLogica.TraerRegiones();
            return View(listaRegiones);
        }

        public ActionResult RegistrarRegion() {
            return View();
        }


    }
}