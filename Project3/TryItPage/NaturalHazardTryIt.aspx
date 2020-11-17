<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NaturalHazardTryIt.aspx.cs" Inherits="NaturalHazardTryIt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
            <b>Natural Hazard Service Try It</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:HyperLink ID="HyperLink1" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>

            <br />
            <b>Description:</b> Given the latitude and longitude of a position in the globe, NaturalHazards operation returns the natural hazards index.<br />
            <br />
            <b>URL: </b><a href="http://webstrar5.fulton.asu.edu/page7/Service1.svc">http://webstrar5.fulton.asu.edu/page7/Service1.svc</a><br />
            <br />
            <b>Operation name:</b>NaturalHazards<br />
            <b>Parameters:</b> (decimal latitude,decimal longitude)<br />
            <b>Returns:</b> decimal value of natural hazard index<br />
            <br />
            Enter Latitude:<br />
            <asp:TextBox ID="txt_latitude" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Longitude</div>
        <p>
            <asp:TextBox ID="txt_longitude" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btn_getresult" runat="server" OnClick="btn_getresult_Click" Text="Get Natural Hazard Index!" />
        <p>
            <asp:Label ID="lbl_result" runat="server" Text=""></asp:Label>
        </p>
</asp:Content>

