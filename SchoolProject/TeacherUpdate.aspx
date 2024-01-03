<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TeacherUpdate.aspx.cs" Inherits="TeacherUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <span style="display: inline-block; margin-bottom: 10px;">
                    <asp:Label for="txtTeacherId" runat="server" Text="Eğitmen ID" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtTeacherId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <span style="display: inline-block">
                    <asp:Label for="txtTeacherNameSurname" runat="server" Text="Eğitmen Ad Soyad" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtTeacherNameSurname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <span style="display: inline-block; margin-bottom: 10px;">
                    <asp:Label for="txtTeacherBranch" runat="server" Text="Eğitmen Branş" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:DropDownList ID="dropDownListTeacherBranch" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <br />
        </div>
        <asp:Button ID="btnTeacherUpdate" runat="server" Text="Eğitimciyi Güncelle" CssClass="btn btn-danger" Width="100%" OnClick="btnTeacherUpdate_Click" />
    </form>
</asp:Content>


