using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;
using Logica;

namespace NorthWind_MVC.ViewModels
{
    /* Clase ViewModel, componente del patron MVVM, interactua con el modelo de datos, a traves de la Capa de Logica.
       y envia una respuesta a la vista a traves del controlador del patron MVC. */

    // Para objetos perzonalizados donde no tenemos toda la informacion en modelo de datos o queremos omitir informacion a enviar a la vista.

    public class CategoryViewModel
    {
        private readonly CategoryLogica objCategoriaLogica;
        private readonly ProductLogica objProductoLogica;

        public int ID { get; set; }
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public int NumeroProductos { get; set; }
        
                
        public CategoryViewModel() {
            this.objCategoriaLogica = new CategoryLogica();
            this.objProductoLogica = new ProductLogica();
        }



        // Todas las categorias.
        public List<CategoryViewModel> TraerCategoriasViewModel() {
            try {             
                var listaCategorias = this.objCategoriaLogica.TraerCategorias();
                var listaCategoryViewModel = (from categoria in listaCategorias
                                              select new CategoryViewModel() {                                               
                                                  ID = categoria.CategoryID,
                                                  NombreCategoria = categoria.CategoryName,
                                                  DescripcionCategoria = categoria.Description,                                                  
                                              }).ToList();

                return listaCategoryViewModel;
            }
            catch (InvalidOperationException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }



        // Categorias que tienen productos.

        public List<CategoryViewModel> TraerCategoriasViewModelRelacionadas() {            
            try {                
                var listaProductos = this.objProductoLogica.TraerProductos();
                var listaCategorias = this.objCategoriaLogica.TraerCategorias();
                var listaCategoriasViewModel = this.TraerCategoriasViewModelRelacionadas(listaCategorias, listaProductos);

                return listaCategoriasViewModel;
            }
            catch(InvalidOperationException ex) {throw ex;}
            catch(Exception ex) { throw ex; }
        }


        // Metodo Auxiliar privado. (Excepcion Controlada en el Metodo Publico).
        private List<CategoryViewModel> TraerCategoriasViewModelRelacionadas(List<Category> categorias, List<Product> productos) {
            var listaCategoryViewModel = (from categoria in categorias
                                          join producto in productos
                                          on categoria.CategoryID equals producto.CategoryID
                                          group producto.CategoryID by categoria into cat
                                          select new CategoryViewModel() {                                           
                                              ID = cat.Key.CategoryID,
                                              NombreCategoria = cat.Key.CategoryName,
                                              DescripcionCategoria = cat.Key.Description,
                                              NumeroProductos = cat.Count()
                                          }).ToList();
            return listaCategoryViewModel;
        } 


       

    }
}