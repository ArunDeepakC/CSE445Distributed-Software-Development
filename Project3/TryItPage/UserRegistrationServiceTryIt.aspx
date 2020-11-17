<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserRegistrationServiceTryIt.aspx.cs" Inherits="UserRegistrationServiceTryIt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
    <div>
        <p>
            <b>User Registration TryIt</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      <asp:HyperLink ID="HyperLink1" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>

        </p>

        
        <p>
           <b> Description:</b> The WSDL/SOAP service takes user name and password as input, and registers the users by storing user credentials in a JSON file named database.json in the server.</p>
        <p>
           <b> URL:</b> <a href="http://webstrar5.fulton.asu.edu/page2/Service1.svc">http://webstrar5.fulton.asu.edu/page2/Service1.svc</a></p>
        <p>
           <b> Operation name:</b> registerUser<br />
            <b>Parameters:</b> (string username, string password)<br />
           <b>Returns:</b> boolean value representing whether registration was successful or not.</p>
       
    </div>
    <p>
        Enter Username:</p>
    <asp:TextBox ID="txt_user" runat="server"></asp:TextBox>
    <br />
    <br />
    Enter Password:<br />
    <asp:TextBox ID="txt_pass" TextMode="Password" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btn_register" runat="server" Text="Register" OnClick="btn_register_Click" />
    <br />
    <br />
    <asp:Label ID="lbl_register" runat="server" Text=""></asp:Label>
</asp:Content>

