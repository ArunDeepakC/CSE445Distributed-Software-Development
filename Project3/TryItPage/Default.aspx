<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <h1>TryIt Page</h1>
        <p>By Arun Deepak Chandrasekar</p>
        <p>ASUID: 1217200647</p>
    </div>

    <div class="row">
        <div>
            <p>Try the following services: </p>
            <p><b>Required Services</b></p>
            <p> <asp:HyperLink ID="HyperLink1" NavigateUrl="NewsFocusTryIt.aspx" runat="server">Link to News Focus TryIt</asp:HyperLink></p>
            <p> <asp:HyperLink ID="HyperLink2" NavigateUrl="NaturalHazardTryIt.aspx" runat="server">Link to Natural Hazards Try It</asp:HyperLink></p>
            <p> &nbsp;</p>
            <p><b> Elective Services</b></p>
            <p> <asp:HyperLink ID="HyperLink3" NavigateUrl="GasStationTryIt.aspx" runat="server">Link to Gas Station Try It</asp:HyperLink></p>
            <p> <asp:HyperLink ID="HyperLink4" NavigateUrl="UserRegistrationServiceTryIt.aspx" runat="server">Link to User Registration Service Try It</asp:HyperLink></p>
        </div>
    </div>
</asp:Content>

