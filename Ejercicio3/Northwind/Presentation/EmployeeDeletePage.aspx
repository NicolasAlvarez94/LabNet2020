<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeDeletePage.aspx.cs" Inherits="Presentation.EmployeeDeletePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h4 class="bg-dark text-center text-white TitleViewPage">UPDATE EMPLOYEES</h4>
    <br />

    <table class="table TableViewPage">
      <thead class="thead-dark">
        <tr>
          <th scope="col">ID</th>
          <th scope="col">First Name</th>
          <th scope="col">Last Name</th>
          <th scope="col">City</th>
          <th scope="col">Region</th>
          <th scope="col">Country</th>
          <th scope="col">Hire Date</th>
          <th scope="col">Delete Employee</th>
        </tr>
      </thead>
      <tbody>
          <%--A traves de la Propiedad Text le Pasamos el Texto HTML de la Tabla con los Datos de Empleados--%> 
          <asp:Literal runat="server" ID="litTableEmployees"></asp:Literal>  
      </tbody>
    </table>
    

    <div class="alert alert-danger" role="alert" id="alertError" style="display:none; width:70%; margin:auto;margin-top:50px">
        <h4 class="alert-heading text-danger">ERROR!</h4>
            <asp:Label runat="server" ID="lblError" CssClass="text-danger"></asp:Label>               
        <hr>
    </div>

</asp:Content>
