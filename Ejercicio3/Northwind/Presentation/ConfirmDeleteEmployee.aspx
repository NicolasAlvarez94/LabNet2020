<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfirmDeleteEmployee.aspx.cs" Inherits="Presentation.ConfirmDeleteEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="modal" tabindex="-1" role="dialog" id="ModalDelete">
      <div class="modal-dialog modal-lg" role="document">
        <div class="modal-content">
          <div class="modal-header bg-dark text-white">
            <h5 class="modal-title">DELETE EMPLOYEE</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            <p>Sure you Want to Delete the Employee?</p>
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
                
                        <asp:Label runat="server" ID="lblMessageDelete"></asp:Label>
                              
                    </form>
                 </div>
          </div>

   
          <div class="modal-footer bg-dark">
             <asp:Button runat="server" ID="btnDelete" CssClass="btn btn-danger" Text="DELETE"/>            
             <a href="EmployeeDeletePage.aspx" class="btn btn-secondary">CANCEL</a>     
          </div>
        </div>
      </div>
    </div>

 


</asp:Content>
