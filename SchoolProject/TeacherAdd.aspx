<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TeacherAdd.aspx.cs" Inherits="TeacherAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <span style="display: inline-block; margin-bottom: 10px;">
                    <asp:Label for="txtTeacherNameSurname" runat="server" Text="Eğitmen Ad Soyad" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtTeacherNameSurname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <span style="display: inline-block; margin-bottom: 10px;">
                    <asp:Label for="txtTeacherBranch" runat="server" Text="Eğitmen Branş" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:DropDownList ID="dropDownListTeacher" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <br />
            <asp:Button ID="btnStudentAdd" runat="server" Text="Eğitmen Ekle" CssClass="btn btn-info" Width="100%" OnClick="btnStudentAdd_Click" />
            </div>
    </form>
</asp:Content>
