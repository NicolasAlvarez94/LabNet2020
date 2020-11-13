using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.ImplementacionDAO;
using Datos.Interfaces;
using Entidades;

namespace Logica
{
    public class CategoryLogica
    {
        private readonly IEntidadDAO<Category> categoriaDAO;

        public CategoryLogica() {
            this.categoriaDAO = new CategoryImplementacionDAO();
        }

        public void RegistrarCategoria(Category pCategoria) {         
            this.categoriaDAO.RegistrarEntidad(pCategoria);
        }

        public void EliminarCategoria(int id) {
            this.categoriaDAO.EliminarEntidad(id);        
        }


        public List<Category> TraerCategorias() {
            return this.categoriaDAO.TraerDatos();            
        }


        public void ModificarCategoria(Category pCategoria) {
            this.categoriaDAO.ModificarEntidad(pCategoria);           
        }




    }
}
