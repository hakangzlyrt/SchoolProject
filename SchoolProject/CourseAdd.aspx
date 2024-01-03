<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CourseAdd.aspx.cs" Inherits="CourseAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <span style="display: inline-block; margin-bottom: 10px;">
                    <asp:Label for="txtCourseName" runat="server" Text="Ders Adı" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtCourseName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <span style="display: inline-block; margin-bottom: 10px;">
                    <asp:Label for="txtCourseMınQuota" runat="server" Text="Ders Minimum Kontenjan" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtCourseMınQuota" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <span style="display: inline-block; margin-bottom: 10px;">
                    <asp:Label for="txtCourseMaxQuota" runat="server" Text="Ders Maksimum Kontenjan" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtCourseMaxQuota" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            </div>
            <br />         
            <asp:Button ID="btnStudentAdd" runat="server" Text="Öğrenciyi Ekle" CssClass="btn btn-info" Width="100%" OnClick="btnStudentAdd_Click"  />
    </form>
</asp:Content>


