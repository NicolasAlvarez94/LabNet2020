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


        public JsonResult RegistrarRegionBD(Region region) {
            try {
                objRegionLogica.RegistrarRegion(region);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch (Exception) { return Json(false, JsonRequestBehavior.AllowGet); }                       
        }


        public ActionResult ModificarRegion(Region region) {
            return View(region);
        }

        public JsonResult ModificarRegionBD(Region region) {         
            try {
                objRegionLogica.ModificarRegion(region);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch (Exception) { return Json(false, JsonRequestBehavior.AllowGet);}            
        }



        [HttpPost]
        public ActionResult EliminarRegion(FormCollection formCollection) {
            try {
                int idRegion = Convert.ToInt32(formCollection["ID"]);
                objRegionLogica.EliminarRegion(idRegion);
                return RedirectToAction("Index");
            }
            catch (Exception) { return ErrorOperacionRegion(); }                        
        }



        public ActionResult ErrorOperacionRegion() {
            return View();
        }


    }
}