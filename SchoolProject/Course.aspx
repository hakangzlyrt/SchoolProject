<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Course.aspx.cs" Inherits="Course" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th style="text-align: center">DERS ID</th>
            <th style="text-align: center">DERS AD</th>
            <th style="text-align: center">DERS MİNİMUM KONTENJAN</th>
            <th style="text-align: center">DERS MAKSİMUM KONTENJAN</th>
            <th style="text-align: center">İŞLEMLER</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr style="text-align: center">
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("COURSENAME") %></td>
                        <td><%# Eval("MİN") %></td>
                        <td><%# Eval("MAX") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "CourseDelete.aspx?COURSEID="+ Eval("ID") %>' ID="btnDelete" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "CourseUpdate.aspx?COURSEID="+ Eval("ID") %>' ID="btnUpdate" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <asp:HyperLink ID="btnCourseAdd" NavigateUrl="CourseAdd.aspx" runat="server" CssClass="btn btn-info" Width="100%">Ders Ekle</asp:HyperLink>
</asp:Content>

