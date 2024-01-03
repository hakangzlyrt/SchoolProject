<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MessageDetails.aspx.cs" Inherits="MessageDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="form1" runat="server">
        <h4 style="font-weight: bold; text-align: center;">MESAJ GÖRÜNTÜLEME SAYFASI</h4>
        <br />
        <asp:TextBox ID="txtNameSurname" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtMail" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtSubject" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtMessage" TextMode="MultiLine" Height="100" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    </form>
</asp:Content>


