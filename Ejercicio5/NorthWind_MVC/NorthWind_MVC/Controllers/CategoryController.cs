using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Entidades;
using Logica;
using NorthWind_MVC.ViewModels;

namespace NorthWind_MVC.Controllers
{
    public class CategoryController : Controller
    {     
        
        private readonly CategoryLogica objCategoriaLogica = new CategoryLogica();
        private readonly CategoryViewModel objCategoriaVistaModelo = new CategoryViewModel();

        public ActionResult Index() {
            List<CategoryViewModel> categoriasModeloVista = objCategoriaVistaModelo.TraerCategoriasViewModel();
            return View(categoriasModeloVista);
        }

        public ActionResult RegistrarCategoria() {
            return View();                        
        }



        [HttpPost]
        public ActionResult RegistrarCategoria(FormCollection formCollection) {            
            try {
                HttpPostedFileBase httpFile = Request.Files["Imagen"];
                WebImage imagen = new WebImage(httpFile.InputStream);

                var objCategoria = new Entidades.Category();                           
                objCategoria.CategoryName = formCollection["Nombre"];
                objCategoria.Description = formCollection["Descripcion"];
                objCategoria.Picture = imagen.GetBytes();
                objCategoriaLogica.RegistrarCategoria(objCategoria);
                return RedirectToAction("Index");
            }
            catch (Exception) { return RedirectToAction("ErrorOperacionCategoria"); }
        }



        public ActionResult ModificarCategoria(CategoryViewModel categoria) {         
            Entidades.Category objCategoria = new Category();
            objCategoria.CategoryID = categoria.ID;
            objCategoria.CategoryName = categoria.NombreCategoria;
            objCategoria.Description = categoria.DescripcionCategoria;

            return View(objCategoria);
        }



        [HttpPost]
        public ActionResult ModificarCategoria(Category categoria) {
            try {           
                var objCategoria = new Entidades.Category();
                objCategoria.CategoryID = categoria.CategoryID;
                objCategoria.CategoryName = categoria.CategoryName;
                objCategoria.Description = categoria.Description;

                objCategoriaLogica.ModificarCategoria(objCategoria);
                return RedirectToAction("Index");                                  
            }
            catch (Exception) { return RedirectToAction("ErrorOperacionCategoria"); }
        }


        [HttpPost]
        public ActionResult EliminarCategoria(FormCollection formCollection) {
            try {
                var idCategoria = Convert.ToInt32(formCollection["ID"]);
                objCategoriaLogica.EliminarCategoria(idCategoria);
                return RedirectToAction("Index");
            }
            catch (Exception) { return RedirectToAction("ErrorOperacionCategoria"); }            
        }


        public ActionResult ErrorOperacionCategoria() {
            return View();
        }

     

    }
}