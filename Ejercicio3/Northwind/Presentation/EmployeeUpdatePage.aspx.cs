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
    public partial class EmployeeUpdatePage : System.Web.UI.Page
    {
        private EmployeeLogic objEmployeLogic;
        private int idEmployee;

        protected void Page_Load(object sender, EventArgs e) {
            this.idEmployee = Convert.ToInt32(Request.QueryString["idEmployee"]);
            this.objEmployeLogic = new EmployeeLogic();  
            
            // Propiedad IsPostBack Retorna False, si la Pagina se Carga por primera vez. De lo contrario True.
            if (!Page.IsPostBack) {
                this.ShowEmployeeToModify();
            }            
            this.btnUpdate.Click += UpdateEmployee;
        }


        private void ShowEmployeeToModify() {
            var objEmployee = objEmployeLogic.GetEmployeeID(this.idEmployee);
            txtFirtsName.Text = objEmployee.FirstName;
            txtLastName.Text = objEmployee.LastName;
            txtCity.Text = objEmployee.City;
            txtRegion.Text = objEmployee.Region;
            txtCountry.Text = objEmployee.Country;
            DateTime hireDate = Convert.ToDateTime(objEmployee.HireDate);
            txtHireDate.Text = hireDate.ToShortDateString();
        }


        private void UpdateEmployee(object sender, EventArgs e) {
            try {
                var objEmployee = this.GetEmployeeFormUpdate();
                objEmployeLogic.UpdateEmployee(objEmployee);
                ClientScript.RegisterStartupScript(this.GetType(), null, "ShowModal()", true);
                ClearFieldsForm();
            }
            catch (Exception) {
                lblError.Text = "Update error. At the moment it is not possible";
                ClientScript.RegisterStartupScript(this.GetType(), null, "ShowAlert()", true);
            }
        }


        private Employee GetEmployeeFormUpdate() {
            var objEmployee = new Employee();
            objEmployee.EmployeeID = this.idEmployee;
            objEmployee.FirstName = txtFirtsName.Text;
            objEmployee.LastName = txtLastName.Text;
            objEmployee.City = txtCity.Text;
            objEmployee.Region = txtRegion.Text;
            objEmployee.Country = txtCountry.Text;
            objEmployee.HireDate = Convert.ToDateTime(txtHireDate.Text);
            
            return objEmployee;
        }


        private void ClearFieldsForm() {
            txtFirtsName.Text = null;
            txtLastName.Text = null;
            txtCity.Text = null;
            txtRegion.Text = null;
            txtCountry.Text = null;
            txtHireDate.Text = null;
        }

    }
}