<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RecourseAdd.aspx.cs" Inherits="Courses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form runat="server">
        <div>
            <asp:Label ID="lblCourse" runat="server" Text="DERS SEÇİN"></asp:Label>
            <asp:DropDownList ID="dropDownListCourse" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <%-- <div>
            <asp:Label ID="lblStudentId" runat="server" Text="ÖĞRENCİ ID"></asp:Label>
            <asp:TextBox ID="txtStudentId" runat="server" CssClass="form-control"></asp:TextBox>
        </div>  --%>
        <div>
            <asp:Label ID="lblStudentId" runat="server" Text="ÖĞRENCİ SEÇİN"></asp:Label>
            <asp:DropDownList ID="dropDownListStudent" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Button ID="btnRecourseAdd" runat="server" Text="Ders Talebi Oluştur" CssClass="btn btn-warning" Width="100%" OnClick="btnRecourseAdd_Click" />
        </div>
    </form>
</asp:Content>

