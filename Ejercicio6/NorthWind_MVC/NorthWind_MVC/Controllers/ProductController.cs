using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthWind_MVC.ViewModels;

namespace NorthWind_MVC.Controllers
{
    public class ProductController : Controller
    {        
        private readonly ProductViewModel objProductoViewModel = new ProductViewModel();

        public ActionResult Index(int id) {
            try {
                var listaProductosViewModel = objProductoViewModel.TraerProductosViewModel(id);
                return View(listaProductosViewModel);
            }
            catch (Exception) { return RedirectToAction("ErrorOperacionProducto"); }
        }

        // Falta Implementar!!!, herencia para todos los controladores que puedan tener errores.
        public ActionResult ErrorOperacionProducto() {         
            return View();
        }
    }
}