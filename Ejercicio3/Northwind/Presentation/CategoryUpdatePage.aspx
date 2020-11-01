<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CategoryUpdatePage.aspx.cs" Inherits="Presentation.CategoryUpdatePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <br />
    <h4 class="bg-dark text-center text-white TitleViewPage">UPDATE CATEGORY</h4>
    <br />

    <div class="FormRegisterPage">
        <form>            
            <div class="form-group">
                 <label>Category Name</label>
                 <asp:TextBox ID="txtCategoryName" runat="server" placeholder="Enter Category Name" CssClass="form-control" MaxLength="15" onKeypress="OnlyText(event);" onfocus=" HideMessage()"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfvCategoryName" runat="server" ControlToValidate="txtCategoryName" ErrorMessage="The Field (Category Name) is Required" Font-Bold="True" Font-Size="XX-Small" ForeColor="#FF3300" EnableClientScript="false"></asp:RequiredFieldValidator>
            </div>
         
            <div class="form-group">
                 <label>Description</label>
                 <asp:TextBox ID="txtDescription" runat="server" placeholder="Enter Description" CssClass="form-control" MaxLength="20" onKeypress="return OnlyText(event);" onfocus=" HideMessage()"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfvDescription" runat="server" ControlToValidate="txtDescription" ErrorMessage="The Field (Description) is Required" Font-Bold="True" Font-Size="XX-Small" ForeColor="#FF3300" EnableClientScript="False"></asp:RequiredFieldValidator>
            </div>   
                             
                                       
            <div class="alert alert-danger" role="alert" style="display:none; margin-top: 20px;" id="alertError">
                <h4 class="alert-heading text-danger">ERROR!</h4>
                <asp:Label runat="server" ID="lblError" CssClass="text-danger"></asp:Label>                
                <hr>
            </div>  

            <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" CssClass="btn btn-success" />            
            <a href="ListCategoryUpdatePage.aspx"><input type="button" value="PREVIOUS" class="btn btn-primary" /></a>
            
                                     
        </form>
     </div>


     <div class="modal" tabindex="-1" role="dialog" id="ModalPage">
         <div class="modal-dialog" role="document">

            <div class="modal-content">
                <div class="modal-header bg-dark">
                  <h5 class="modal-title text-white">UPDATE</h5>
                  <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                  </button>
                </div>
            
                <div class="modal-body">
                    <p>Successful Update</p>
                </div>
                <div class="modal-footer">                    
                    <button type="button" class="btn btn-dark" data-dismiss="modal">ACEPTAR</button>
                </div>
            </div>
         </div>             
    </div>
</asp:Content>
