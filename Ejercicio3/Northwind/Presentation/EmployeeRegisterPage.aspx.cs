using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Logic;

namespace Presentation.RegistrationPages
{
    public partial class EmployeeRegisterPage : System.Web.UI.Page
    {
        private EmployeeLogic objEmployeeLogic;

        protected void Page_Load(object sender, EventArgs e) {         
            this.objEmployeeLogic = new EmployeeLogic();
            this.btnRegister.Click += RegisterEmployee;            
        }


        private void RegisterEmployee(object sender, EventArgs e) {         
            bool validatePage = Page.IsValid;
            try {
                if (validatePage) {
                    var objEmployee = this.GetRegisteredEmployee();
                    objEmployeeLogic.RegisterEmployee(objEmployee);
                    ClientScript.RegisterStartupScript(this.GetType(), null, "ShowModal()", true);
                    ClearFieldsForm();
                }
                else {                    
                    lblError.Text = "Error Incomplete Fields";
                    ClientScript.RegisterStartupScript(this.GetType(), null, "ShowAlert()", true); 
                }
            }
            catch(Exception) {
                lblError.Text = "Registration error. At the moment it is not possible";
                ClientScript.RegisterStartupScript(this.GetType(), null, "ShowAlert()", true);
            }                       
        }


        private Employee GetRegisteredEmployee() {
            var objEmployee = new Employee() {
                FirstName = this.txtFirtsName.Text,
                LastName = this.txtLastName.Text,
                City = this.txtCity.Text,
                Region = this.txtRegion.Text,
                Country = this.txtCountry.Text,
                HireDate = Convert.ToDateTime(this.txtHireDate.Text)
            };
            return objEmployee;
        }


        private void ClearFieldsForm() {
            this.txtFirtsName.Text = null;
            this.txtLastName.Text = null;
            this.txtCity.Text = null;
            this.txtRegion.Text = null;
            this.txtCountry.Text = null;
            this.txtHireDate.Text = null;
        }

    }
}