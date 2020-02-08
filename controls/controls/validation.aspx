<%@ Page Language="C#"MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="validation.aspx.cs" Inherits="controls.validation" %>
<asp:Content ID="id23" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" Name must be entered" ForeColor="Red" ValidationGroup="vg">Enter your name</asp:RequiredFieldValidator>
<br />
        Ambica<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age between 18 to 60" MaximumValue="60" MinimumValue="18" ValidationGroup="vg" Type="Integer" ForeColor="#CC0000">Enter Age</asp:RangeValidator>
<br />
        21<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email must be in correct formart" ControlToValidate="TextBox3" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vg">Enter email id</asp:RegularExpressionValidator>
<br />
        ambica@gmail.com<br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Must enter password" ControlToValidate="TextBox4" ForeColor="#CC0000" ValidationGroup="vg">Enter Password</asp:RequiredFieldValidator>
        <br />
        vampire<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password must match" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ForeColor="Red" ValidationGroup="vg">confirm password</asp:CompareValidator>
<br />
        vampire<br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="vg" />
<br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
<br />
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</div>
    </asp:Content>

       