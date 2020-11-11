using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Logica;
using Entidades;

namespace NorthWind_MVC.ViewModels
{
    public class ProductViewModel
    {
        private readonly ProductLogica objProductoLogica = new ProductLogica();
        public int ID { get; set; }
        public string NombreProducto { get; set; }
        public int Stock { get; set; }

        public ProductViewModel() {
            this.objProductoLogica = new ProductLogica();
        }



        public List<ProductViewModel> TraerProductosViewModel(int id) {
            try {
                var listaProductos = objProductoLogica.TraerProductos();

                var listaProductosViewModel = (from producto in listaProductos
                                               where producto.CategoryID == id
                                               select new ProductViewModel () { 
                                                    ID = producto.ProductID,
                                                    NombreProducto = producto.ProductName,
                                                    Stock = Convert.ToInt32(producto.UnitsInStock)                                               
                                               }).ToList();
                return listaProductosViewModel;            
            }
            catch(InvalidOperationException ex) { throw ex; }
            catch(Exception ex) { throw ex; }
        }




    }
}