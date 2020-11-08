using Datos.ImplementacionDAO;
using Datos.InterfaceDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contactos.Controllers
{
    public class ContactoController : Controller
    {
        private readonly IEntidadDAO<Models.Contacto> contactoDAO = new ContactoImplementacionDAO();
        

        public ActionResult ListarContactos() {
            List<Models.Contacto> listaContactos = contactoDAO.ListarDatos();
            return View(listaContactos);
        }

                
        public ActionResult Registrar() {
            return View();
        }


        public ActionResult RegistrarContacto() {
            try {             
                Models.Contacto objContacto = new Models.Contacto();
                objContacto.Nombre = Request.Form["nombre"].ToString();
                objContacto.Apellido = Request.Form["apellido"].ToString();
                objContacto.Edad = Convert.ToInt32(Request.Form["edad"]);
                objContacto.Genero = Request.Form["genero"].ToString();
                objContacto.Empresa = Request.Form["empresa"].ToString();

                contactoDAO.Registrar(objContacto);
                return View(objContacto);
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }                             
        }

      
    }
}