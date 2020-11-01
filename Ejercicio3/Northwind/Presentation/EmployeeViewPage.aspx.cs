using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Logic;


namespace Presentation.ViewPages
{
    public partial class EmployeeViewPage : System.Web.UI.Page
    {
        private EmployeeLogic objEmployeeLogic;
        protected void Page_Load(object sender, EventArgs e) {         
            this.objEmployeeLogic = new EmployeeLogic();
            this.LoadEmployeesTable();
        }

        private void LoadEmployeesTable() {
            try {
                List<Employee> listEmployees = this.objEmployeeLogic.ListEmployees();
                var strHtmlTable = this.GetTextHtmlTable(listEmployees);
                this.litTableEmployees.Text = strHtmlTable;
            }
            catch (Exception) {
                lblError.Text = "Error at the moment cannot see the data";
                ClientScript.RegisterStartupScript(this.GetType(), null, "ShowAlert()", true);
            }            
        }
        

        // Metodo Auxiliar para Mostrar Empleados en Tabla.
        private string GetTextHtmlTable(List<Employee> employees) {
            var strHtml = "";
            foreach (var employee in employees) {             
                strHtml += "<tr>";
                strHtml += $"<th scope='row' >{employee.EmployeeID} </th>";
                strHtml += $"<td>{employee.FirstName}</td>";
                strHtml += $"<td>{employee.LastName}</td>";
                strHtml += $"<td>{employee.City}</td>";
                strHtml += $"<td>{employee.Region}</td>";
                strHtml += $"<td>{employee.Country}</td>";
                strHtml += $"<td>{employee.HireDate}</td>";
            }
            return strHtml;
        }


    }
}