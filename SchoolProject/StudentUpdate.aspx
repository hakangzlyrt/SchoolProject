<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="StudentUpdate.aspx.cs" Inherits="StudentUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <span style="display: inline-block">
                    <asp:Label for="txtStudentId" runat="server" Text="Öğrenci ID" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtStudentId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <span style="display: inline-block">
                    <asp:Label for="txtStudentName" runat="server" Text="Öğrenci Adı" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtStudentName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <span style="display: inline-block">
                    <asp:Label for="txtStudentSurname" runat="server" Text="Öğrenci Soyadı" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtStudentSurname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <span style="display: inline-block">
                    <asp:Label for="txtStudentNumber" runat="server" Text="Öğrenci Numarası" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtStudentNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />
            <div>
                <span style="display: inline-block">
                    <asp:Label for="txtStudentPhotograph" runat="server" Text="Öğrenci Fotoğrafı" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtStudentPhotograph" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
               <span style="display: inline-block">
                    <asp:Label for="txtStudentPassword" runat="server" Text="Öğrenci Şifresi" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtStudentPassword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <span style="display: inline-block">
                    <asp:Label for="txtStudentBalance" runat="server" Text="Öğrenci Bakiyesi" Style="font-weight: 700; margin-left: 10px;"></asp:Label>
                </span>
                <asp:TextBox ID="txtStudentBalance" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
        </div>
        <asp:Button ID="btnStudentUpdate" runat="server" Text="Öğrenciyi Güncelle" CssClass="btn btn-danger" Width="100%" OnClick="btnStudentUpdate_Click"  />
    </form>
</asp:Content>
