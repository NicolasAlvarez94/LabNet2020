using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Interfaces;
using Datos.ImplementacionDAO;
using Entidades;

namespace Logica
{
    public class ProductLogica
    {
        private readonly IEntidadDAO<Product> productoDAO;

        public ProductLogica() { 
            this.productoDAO = new ProductImplementacionDAO();
        }

        #region Metodos Publicos

        public void RegistrarProducto(Product producto) {
            this.productoDAO.RegistrarEntidad(producto);        
        }

        public void EliminarProducto(int id) {
            this.productoDAO.EliminarEntidad(id);
        }

        public void ModificarProducto(Product producto) {
            this.productoDAO.ModificarEntidad(producto);
        }

        public List<Product> TraerProductos() {
            List<Product> listaProductos = this.productoDAO.TraerDatos();
            return listaProductos;
        }

        #endregion
    }
}
