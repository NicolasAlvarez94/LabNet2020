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
    public partial class CategoryUpdatePage : System.Web.UI.Page
    {
        private int idCategory;
        private CategoryLogic objCategoryLogic;

        protected void Page_Load(object sender, EventArgs e) {
            this.idCategory = Convert.ToInt32(Request.QueryString["idCategory"]);
            this.objCategoryLogic = new CategoryLogic();

            // Propiedad IsPostBack Retorna False, si la Pagina se Carga por primera vez. De lo contrario True.
            if (!Page.IsPostBack) {             
                this.ShowEmployeeToModify();
            }
            this.btnUpdate.Click += UpdateCategory;
        }


        private void ShowEmployeeToModify() {         
            var objCategory = objCategoryLogic.GetCategoryID(this.idCategory);
            txtCategoryName.Text = objCategory.CategoryName;
            txtDescription.Text = objCategory.Description;            
        }


        private void UpdateCategory(object sender, EventArgs e) {
            try {
                var objCategory = this.GetCategoryFormUpdate();
                objCategoryLogic.UpdateCategory(objCategory);
                ClientScript.RegisterStartupScript(this.GetType(), null, "ShowModal()", true);
                ClearFieldsForm();
            }
            catch (Exception) {             
                lblError.Text = "Update error. At the moment it is not possible";
                ClientScript.RegisterStartupScript(this.GetType(), null, "ShowAlert()", true);
            }
        }


        private Category GetCategoryFormUpdate() {         
            var objCategory = new Category();
            objCategory.CategoryID = this.idCategory;
            objCategory.CategoryName = txtCategoryName.Text;
            objCategory.Description = txtDescription.Text;

            return objCategory;
        }


        private void ClearFieldsForm() {         
            txtCategoryName.Text = null;
            txtDescription.Text = null;           
        }


    }
}