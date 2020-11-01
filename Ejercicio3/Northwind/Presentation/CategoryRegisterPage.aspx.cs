using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Logic;

namespace Presentation
{
    public partial class CategoryRegisterPage : System.Web.UI.Page
    {
        private CategoryLogic objCategoryLogic;

        protected void Page_Load(object sender, EventArgs e) {         
            this.objCategoryLogic = new CategoryLogic();
            this.btnRegister.Click += RegisterCategory;
        }


        private void RegisterCategory(object sender, EventArgs e) {
            bool validatePage = Page.IsValid;
            try {             
                if (validatePage) {
                    var objCategory = this.GetRegisteredCategory();
                    objCategoryLogic.RegisterCategory(objCategory);
                    ClientScript.RegisterStartupScript(this.GetType(), null, "ShowModal()", true);
                    ClearFieldsForm();
                }
                else {                 
                    lblError.Text = "Error Incomplete Fields";
                    ClientScript.RegisterStartupScript(this.GetType(), null, "ShowAlert()", true);
                }
            }
            catch (Exception) {             
                lblError.Text = "Registration error. At the moment it is not possible";
                ClientScript.RegisterStartupScript(this.GetType(), null, "ShowAlert()", true);
            }
        }


        private Category GetRegisteredCategory() {
            BinaryReader reader = new BinaryReader(this.imgCategory.PostedFile.InputStream);
            byte[] image = reader.ReadBytes(this.imgCategory.PostedFile.ContentLength);

            var objCategory = new Category() {             
                CategoryName = this.txtCategoryName.Text,
                Description = this.txtDescription.Text,
                Picture = image
            };
            return objCategory;
        }


        private void ClearFieldsForm() {         
            this.txtCategoryName.Text = null;
            this.txtDescription.Text = null;
            this.imgCategory = null;
        }

    }
}