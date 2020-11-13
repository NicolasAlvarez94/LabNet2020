using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Contexto;
using Datos.Interfaces;
using Entidades;

namespace Datos.ImplementacionDAO
{
    public class ProductImplementacionDAO : BaseContextDAO, IEntidadDAO<Product>
    {

        #region Metodos Publicos

        public void RegistrarEntidad(Product producto) {
            try {             
                bdContext.Products.Add(producto);
                bdContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public void EliminarEntidad(int id) {
            try {
                var objProducto = (from producto in bdContext.Products
                                   where producto.ProductID == id
                                   select producto).First();
                bdContext.Products.Remove(objProducto);
            }
            catch(InvalidOperationException ex) {throw ex;}
            catch (Exception ex) { throw ex; }
        }


        public List<Product> TraerDatos() {
            try {             
                var listaProductos = (from producto in bdContext.Products
                                      select producto).ToList();
                return listaProductos;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }



        public void ModificarEntidad(Product pProducto) {
            try {             
                var objProducto = (from producto in bdContext.Products
                                    where producto.CategoryID == pProducto.CategoryID
                                    select producto).First();

                objProducto.ProductName = pProducto.ProductName;
                objProducto.SupplierID = pProducto.SupplierID;
                objProducto.CategoryID = pProducto.CategoryID;
                objProducto.QuantityPerUnit = pProducto.QuantityPerUnit;
                objProducto.UnitPrice = pProducto.UnitPrice;
                objProducto.UnitsInStock = pProducto.UnitsInStock;
                objProducto.UnitsOnOrder = pProducto.UnitsOnOrder;
                objProducto.ReorderLevel = pProducto.ReorderLevel;
                objProducto.Discontinued = pProducto.Discontinued;
                bdContext.SaveChanges();
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        #endregion

    }
}
