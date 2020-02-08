<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="image.aspx.cs" Inherits="Imageapp.image" %>
<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
<div class="jumbotron">
<asp:FileUpload ID="FileUpload1" runat="server" />
<br />
<br />
    <asp:Button ID="Button1" runat="server" Text="Button" Height="48px" Width="103px" />
<br />
<br />
<asp:DataList ID="DataList1" runat="server" RepeatColumns="2">
<ItemTemplate>
<asp:Image ID="Image1"
ImageUrl='<%# Eval("Name","~/Imagefolder/{0}") %>'
width="350px" Height="350px" Runat="Server" />
<br />
<%#Eval("Name") %>
</ItemTemplate>
</asp:DataList>
</div>
</asp:Content>


