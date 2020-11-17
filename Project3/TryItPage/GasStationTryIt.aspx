<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GasStationTryIt.aspx.cs" Inherits="GasStationTryIt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <p>
            <b>Gas Station Service</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      <asp:HyperLink ID="HyperLink1" NavigateUrl="Default.aspx" runat="server">Go Back</asp:HyperLink>

        </p>

        
        <p>
           <b> Description:</b> The restful service takes address as input and returns details of nearby gas stations including gas station name, street address, fuel type eg. LPG, CNG, electric, station type eg. grocery store.</p>
        <p>
           <b> URL/ API end point:</b> <a href="http://webstrar5.fulton.asu.edu/page3/api/GasStation/{address">http://webstrar5.fulton.asu.edu/page3/api/GasStation/{address</a>}</p>
        <p>
           <b> Operation name:</b>GasStation<br />
            <b>Parameters:</b> string address<br />
           <b>Returns:</b> List&lt;string&gt; list of gas station details in string format</p>
        <p>Enter Address: </p>

    </div>
    <asp:TextBox ID="txt_address" runat="server"></asp:TextBox><br /><br />
    <asp:Button ID="btn_submit" runat="server" Text="Find" Height="30px" OnClick="btn_submit_Click" Width="72px" /><br /><br />
    <asp:Label ID="lbl_output" runat="server" Text=""></asp:Label>
</asp:Content>

