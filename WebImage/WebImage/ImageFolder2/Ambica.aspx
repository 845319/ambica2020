<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ambica.aspx.cs" Inherits="WebImage.Ambica" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="2">
            <ItemTemplate>
                <asp:Image ID="Image1"
                    ImageUrl='<%# Eval("Name","~/ImageFolder2/{0}")%>'
                    width="350px" Height="350px" runat="server" />

            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>