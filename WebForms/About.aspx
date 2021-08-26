<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebForms.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page 123.</h3>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <p>Use this area to provide additional information.</p>
</asp:Content>
