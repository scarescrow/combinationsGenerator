<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="form1" action="javascript:void(0)">
        <h1>Combinations Generator</h1><br />
        <asp:TextBox ID="input" runat="server"></asp:TextBox>
        <br /><br />
        <asp:button id="clickMeButton" runat="server" text="Generate" onClick="clickMeButton_Click"/> 
        <asp:button id="Button2" runat="server" text="Clear" OnClick="Button2_Click"/>
        <br /><br />
        <asp:TextBox ID="output" style="resize:none" runat="server" TextMode="multiline" Width="200px" Height="100px" ReadOnly="true"></asp:TextBox>
    </form>
</asp:Content>
