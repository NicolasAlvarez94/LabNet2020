using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Logic;


namespace Presentation.ViewPages
{
    public partial class CategoryViewPage : System.Web.UI.Page
    {
        private CategoryLogic objCategoryLogic;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.objCategoryLogic = new CategoryLogic();
            this.LoadCategoriesTable();
        }


        private void LoadCategoriesTable() {
            try {
                List<Category> listCategories = this.objCategoryLogic.ListCategories();
                var strHtmlTable = this.GetTextHtmlTable(listCategories);
                this.litTableCategories.Text = strHtmlTable;
            }
            catch (Exception) {
                lblError.Text = "Error at the moment cannot see the data";
                ClientScript.RegisterStartupScript(this.GetType(), null, "ShowAlert()", true);
            }            
        }


        // Metodo Auxiliar para Mostrar Empleados en Tabla.
        private string GetTextHtmlTable(List<Category> categories) {         
            var strHtml = "";            
            foreach (var category in categories) {             
                strHtml += "<tr>";
                strHtml += $"<th scope='row' >{category.CategoryID} </th>";
                strHtml += $"<td>{category.CategoryName}</td>";
                strHtml += $"<td>{category.Description}</td>";
                strHtml += $"<td>{category.Picture}</td>";
            }
            return strHtml;
        }


    }
}