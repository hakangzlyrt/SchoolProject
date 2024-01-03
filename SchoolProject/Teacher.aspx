<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Teacher.aspx.cs" Inherits="Teacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <table class="table table-bordered table-hover">
        <tr>
            <th style="text-align: center">EĞİTMEN ID</th>
            <th style="text-align: center">EĞİTMEN AD SOYAD</th>
            <th style="text-align: center">EĞİTMEN BRANŞ</th>
            <th style="text-align: center">İŞLEMLER</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr style="text-align: center">
                        <td><%# Eval("TEACHERID") %></td>
                        <td><%# Eval("TEACHERNAMESURNAME") %></td>
                        <td><%# Eval("CourseName") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "TeacherDelete.aspx?TEACHERID="+ Eval("TEACHERID") %>' ID="btnDelete" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>                 
                            <asp:HyperLink NavigateUrl='<%# "TeacherUpdate.aspx?TEACHERID="+ Eval("TEACHERID") %>' ID="btnUpdate" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <asp:HyperLink ID="btnTeacherAdd" NavigateUrl="TeacherAdd.aspx" runat="server" CssClass="btn btn-info" Width="100%">Eğitmen Ekle</asp:HyperLink>
</asp:Content>

