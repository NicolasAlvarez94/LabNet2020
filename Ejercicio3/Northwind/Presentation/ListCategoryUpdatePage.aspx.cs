using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Logic;

namespace Presentation
{
    public partial class ListCategoryUpdatePage : System.Web.UI.Page
    {
        private CategoryLogic objCategoyLogic;

        protected void Page_Load(object sender, EventArgs e) {
            this.objCategoyLogic = new CategoryLogic();
            this.LoadCategoriesUpdateTable();
        }


        private void LoadCategoriesUpdateTable() {
            try {
                List<Category> listCategories = this.objCategoyLogic.ListCategories();
                var strHtmlTable = this.GetTextHtmlTable(listCategories);
                this.litTableCategories.Text = strHtmlTable;
            }
            catch (Exception) {             
                lblError.Text = "Error at the moment cannot see the data";
                ClientScript.RegisterStartupScript(this.GetType(), null, "ShowAlert()", true);
            }
        }


        private string GetTextHtmlTable(List<Category> categories) {         
            var strHtml = "";
            foreach (var category in categories) {             
                strHtml += "<tr>";
                strHtml += $"<th scope='row' >{category.CategoryID} </th>";
                strHtml += $"<td>{category.CategoryName}</td>";
                strHtml += $"<td>{category.Description}</td>";                                                          
                strHtml += $"<td><a class='btn btn-primary' href='CategoryUpdatePage.aspx?idCategory={category.CategoryID}'>UPDATE</a></td>";
            }
            return strHtml;
        }

    }
}