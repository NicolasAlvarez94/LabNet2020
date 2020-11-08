using Datos.InterfaceDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using Datos.Contexto;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;

namespace Datos.ImplementacionDAO
{
    public class ContactoImplementacionDAO : BaseContext, IEntidadDAO<Contacto>
    {
        public void Registrar(Contacto registro) {
            try {
                bdContext.Contactos.Add(registro);
                bdContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        public List<Contacto> ListarDatos() {
            try {             
                var listaContactos = (from contacto in bdContext.Contactos
                                      select contacto).ToList();
                return listaContactos;
            }
            catch(InvalidOperationException ex) { throw ex; }
            catch(Exception ex) { throw ex; }
        }
    }
}