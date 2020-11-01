<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeRegisterPage.aspx.cs" Inherits="Presentation.RegistrationPages.EmployeeRegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Efects.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h4 class="bg-dark text-center text-white TitleViewPage">REGISTER EMPLOYEE</h4>
    <br />

    <div class="FormRegisterPage">
        <form>   
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label>Firts Name</label>
                    <asp:TextBox ID="txtFirtsName" runat="server" placeholder="Enter Firts Name" CssClass="form-control" MaxLength="10" onKeypress="OnlyText(event);" onfocus=" HideMessage()"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFirtsName" runat="server" ControlToValidate="txtFirtsName" ErrorMessage="The Field (Firts Name) is Required" Font-Bold="True" Font-Size="XX-Small" ForeColor="#FF3300" EnableClientScript="false"></asp:RequiredFieldValidator>
                </div>
         
                <div class="form-group col-md-6">
                    <label>Last Name</label>
                    <asp:TextBox ID="txtLastName" runat="server" placeholder="Enter Last Name" CssClass="form-control" MaxLength="20" onKeypress="return OnlyText(event);" onfocus=" HideMessage()"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="The Field (Last Name) is Required" Font-Bold="True" Font-Size="XX-Small" ForeColor="#FF3300" EnableClientScript="False"></asp:RequiredFieldValidator>
                </div>   
            </div>
         
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label>City</label>
                    <asp:TextBox ID="txtCity" runat="server" placeholder="Enter City" CssClass="form-control" MaxLength="15" onKeypress="return OnlyText(event);" onfocus=" HideMessage()"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity" ErrorMessage="The Field (City) is Required" Font-Bold="True" Font-Size="XX-Small" ForeColor="#FF3300" EnableClientScript="False"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group col-md-6">
                    <label>Region</label>
                    <asp:TextBox ID="txtRegion" runat="server" placeholder="Enter Region" CssClass="form-control" MaxLength="15" onKeypress="return OnlyText(event);" onfocus=" HideMessage()"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvRegion" runat="server" ControlToValidate="txtRegion" ErrorMessage="The Field (Region) is Required" Font-Bold="True" Font-Size="XX-Small" ForeColor="#FF3300" EnableClientScript="False"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="form-group">
                <label>Country</label>
                <asp:TextBox ID="txtCountry" runat="server" placeholder="Enter Country" CssClass="form-control" MaxLength="15" onKeypress="return OnlyText(event);" onfocus=" HideMessage()"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCountry" runat="server" ControlToValidate="txtCountry" ErrorMessage="The Field (Country) is Required" Font-Bold="True" Font-Size="XX-Small" ForeColor="#FF3300" EnableClientScript="False"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label>Hire Date</label>
                <asp:TextBox ID="txtHireDate" runat="server" placeholder="Enter Hire Date" TextMode="Date" CssClass="form-control" MaxLenght="15" onfocus=" HideMessage()"></asp:TextBox>                              
                <asp:RequiredFieldValidator ID="rfvHireDate" runat="server" ControlToValidate="txtHireDate" ErrorMessage="The Field (Hire Date) is Required" Font-Bold="True" Font-Size="XX-Small" ForeColor="#FF3300" EnableClientScript="False"></asp:RequiredFieldValidator>
            </div>
                
            <div class="alert alert-danger" role="alert" style="display:none; margin-top: 20px;" id="alertError">
                <h4 class="alert-heading text-danger">ERROR!</h4>
                <asp:Label runat="server" ID="lblError" CssClass="text-danger"></asp:Label>               
                <hr>
            </div>  
            <asp:Button ID="btnRegister" runat="server" Text="REGISTER" CssClass="btn btn-success" />                                            
            
        </form>
     </div>


     <div class="modal" tabindex="-1" role="dialog" id="ModalPage">
         <div class="modal-dialog" role="document">

            <div class="modal-content">
                <div class="modal-header bg-dark">
                  <h5 class="modal-title text-white">REGISTRO</h5>
                  <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                  </button>
                </div>
            
                <div class="modal-body">
                    <p>Successful Registration</p>
                </div>
                <div class="modal-footer">                    
                    <button type="button" class="btn btn-dark" data-dismiss="modal">ACEPTAR</button>
                </div>
            </div>
         </div>             
    </div>





</asp:Content>
