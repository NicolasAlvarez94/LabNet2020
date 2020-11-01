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
    public partial class ConfirmDeleteEmployee : System.Web.UI.Page
    {
        private EmployeeLogic objEmployeeLogic;
        private int idEmployee;

        protected void Page_Load(object sender, EventArgs e) {
            this.objEmployeeLogic = new EmployeeLogic();
            this.idEmployee = Convert.ToInt32(Request.QueryString["idEmployee"]);
            
            ClientScript.RegisterStartupScript(this.GetType(), null, "ShowModalDelete()", true);
            ShowEmployeeToDelete();
            btnDelete.Click += DeleteEmployee;
        }


        private void ShowEmployeeToDelete() {
            var objEmployee = objEmployeeLogic.GetEmployeeID(this.idEmployee);
            txtFirtsName.Text = objEmployee.FirstName;
            txtLastName.Text = objEmployee.LastName;
            txtCity.Text = objEmployee.City;
            txtRegion.Text = objEmployee.Region;
            txtCountry.Text = objEmployee.Country;
            DateTime hireDate = Convert.ToDateTime(objEmployee.HireDate);
            txtHireDate.Text = hireDate.ToShortDateString();

            DisableFields();
        }


        private void DisableFields() {
            txtFirtsName.Enabled = false;
            txtLastName.Enabled = false;
            txtCity.Enabled = false;
            txtRegion.Enabled = false;
            txtCountry.Enabled = false;            
            txtHireDate.Enabled = false;
        }


        // Solo se pueden Eliminar Empleados que no estas Relacionados con otra Tabla por la Integridad Referencial. 
        private void DeleteEmployee(object sender, EventArgs e) {
            try {
                objEmployeeLogic.DeleteEmployee(this.idEmployee);
                ClearFieldsForm();
                lblMessageDelete.ForeColor = System.Drawing.Color.Green;
                lblMessageDelete.Text = "SUCCESSFUL DELETE";               
            }
            catch (Exception) {
                ClearFieldsForm();
                lblMessageDelete.ForeColor = System.Drawing.Color.Red;
                lblMessageDelete.Text = "ERROR DELETE";
            }
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