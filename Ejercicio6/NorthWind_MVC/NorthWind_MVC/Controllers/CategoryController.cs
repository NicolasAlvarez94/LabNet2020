﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI;
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
        public ActionResult RegistrarCategoria(Category categoria) {            
            try {             
                HttpPostedFileBase httpFile = Request.Files[0];
                WebImage imagen = new WebImage(httpFile.InputStream);                 
                categoria.Picture = imagen.GetBytes();

                objCategoriaLogica.RegistrarCategoria(categoria);
                IncrementarValorOperaciones();                
                return RedirectToAction("Index");
            }
            catch (Exception) { return ErrorOperacionCategoria(); }            
        }




        // Pasa los datos de la tabla a un formulario para luego ser modificados. 
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
                objCategoriaLogica.ModificarCategoria(categoria);
                IncrementarValorOperaciones();
                return RedirectToAction("Index");                                  
            }
            catch (Exception) { return RedirectToAction("ErrorOperacionCategoria"); }
        }



        [HttpPost]
        public ActionResult EliminarCategoria(FormCollection formCollection) {
            try {                
                var idCategoria = Convert.ToInt32(formCollection["ID"]);
                objCategoriaLogica.EliminarCategoria(idCategoria);
                IncrementarValorOperaciones();
                return RedirectToAction("Index");
            }
            catch (Exception) { return RedirectToAction("ErrorOperacionCategoria"); }            
        }



        public ActionResult ErrorOperacionCategoria() {
            return View();
        }


        // Problema con variable a nivel aplicacion, incrementa pero no se muestra en vista.
        private void IncrementarValorOperaciones() {         
            int cantidadOperacionesSession = 0;
            int cantidadOperacionesAplicacion = 0;
            bool validarSonNull = (Session["SessionOperaciones"] == null) && (HttpContext.Application["AplicacionOperaciones"] == null);

            if (validarSonNull) {             
                Session["SessionOperaciones"] = "1";
                HttpContext.Application["AplicacionOperaciones"] = "1";
            }
            else {                             
                cantidadOperacionesSession = Convert.ToInt32(Session["SessionOperaciones"]);
                cantidadOperacionesSession ++;
                cantidadOperacionesAplicacion = Convert.ToInt32(HttpContext.Application["AplicacionOperaciones"]);
                cantidadOperacionesAplicacion ++;

                Session["SessionOperaciones"] = cantidadOperacionesSession.ToString();
                HttpContext.Application["AplicacionOperaciones"] = cantidadOperacionesAplicacion.ToString();                
                ViewBag.operacionesApplicacion = HttpContext.Application["AplicacionOperaciones"];
            }            
        }





    }
}