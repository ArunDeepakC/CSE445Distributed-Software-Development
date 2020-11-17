<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sort_webapp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1> Number Sorting Application </h1>
    </div>
   
    <div>
        Enter a string of numbers seperated by commas<br /><br />
        <asp:TextBox ID="TextNum" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text="Sorted String is: "></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text=" "></asp:Label>
        <br /><br />
        <asp:Button ID="BtnSort" runat="server" Text="Sort" OnClick="BtnSort_Click" />
    </div>
    
   

</asp:Content>
