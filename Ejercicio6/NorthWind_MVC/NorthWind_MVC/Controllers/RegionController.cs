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
        // Solucion Temporaria, para mostrar POPUP. 
        private static bool validacion;
        private readonly RegionLogica objRegionLogica; 

        public RegionController() {
            this.objRegionLogica = new RegionLogica();
        }



        public ActionResult Index() {         
            var listaRegiones = objRegionLogica.TraerRegiones();
            return View(listaRegiones);
        }

        public ActionResult RegistrarRegion() {
            return View();
        }


        public ActionResult RegistrarRegionBD(Region region) {
            try {
                objRegionLogica.RegistrarRegion(region);
                validacion = true;
                return RedirectToAction("RegistrarRegion");                               
            }
            catch (Exception) { return View("ErrorOperacionRegion"); }                       
        }


        public ActionResult ModificarRegion(Region region) {
            return View(region);
        }

        public ActionResult ModificarRegionBD(Region region) {         
            try {
                objRegionLogica.ModificarRegion(region);           
                validacion = true;
                return RedirectToAction("ModificarRegion");
            }
            catch (Exception) { return View("ErrorOperacionRegion"); }            
        }



        [HttpPost]
        public ActionResult EliminarRegion(FormCollection formCollection) {
            try {
                int idRegion = Convert.ToInt32(formCollection["ID"]);
                objRegionLogica.EliminarRegion(idRegion);
                return RedirectToAction("Index");
            }
            catch (Exception) { return View("ErrorOperacionRegion"); }                        
        }



        // Metodos y Accion auxiliar para Mensajes.
        public ActionResult ErrorOperacionRegion() {
            return View();
        }

        public void InvalidarMensajeVista() {         
            validacion = false;
        }

        public bool ObtenerValidacionMensaje() {         
            return validacion;
        }



    }
}