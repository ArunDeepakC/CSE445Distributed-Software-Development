<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NewsFocusTryIt.aspx.cs" Inherits="NewsFocusTryIt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
            News Focus TryIt<br />
            <br />
            Description: Given a list of topics, NewsFocus operation finds news about those topics and returns their URL.<br />
            <br />
            URL:<a href="http://localhost:54524/Service1.svc">http://localhost:54524/Service1.svc</a><br />
            <br />
            Operation: NewsFocus<br />
            Parameters:string array of topics (string[] topics)<br />
            Returns:string array/list of URL&#39;s the given topics are reported in.<br />
            <br />
            <br />
            Enter list of topics</div>
        <asp:TextBox ID="txt_topics" runat="server" Width="1234px"></asp:TextBox>
        <asp:Button ID="btn_url" runat="server" OnClick="btn_url_Click" Text="Find News!" />
        <p>
            <asp:Label ID="lbl_url" runat="server"></asp:Label>
        </p>
</asp:Content>

