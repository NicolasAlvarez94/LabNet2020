<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListCategoryUpdatePage.aspx.cs" Inherits="Presentation.ListCategoryUpdatePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <h4 class="bg-dark text-center text-white TitleViewPage">VIEW CATEGORIES</h4>

    <br />

    <table class="table TableViewPage">
      <thead class="thead-dark">
        <tr>
          <th scope="col">ID</th>
          <th scope="col">Category Name</th>
          <th scope="col">Description</th>          
          <th scope="col">Update</th>
        </tr>
      </thead>
      <tbody>
          <%--A traves de la Propiedad Text le Pasamos el Texto HTML de la Tabla con los Datos de las Categorias--%> 
          <asp:Literal runat="server" ID="litTableCategories"></asp:Literal>  
      </tbody>
    </table>

    <div class="alert alert-danger" role="alert" id="alertError" style="display:none; width:70%; margin:auto;margin-top:50px">
        <h4 class="alert-heading text-danger">ERROR!</h4>
            <asp:Label runat="server" ID="lblError" CssClass="text-danger"></asp:Label>               
        <hr>
    </div>  



</asp:Content>
