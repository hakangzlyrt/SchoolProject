<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Student.aspx.cs" Inherits="StudentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    

    <table class="table table-bordered">
        <tr>
            <th style="text-align: center">ÖĞRENCİ ID</th>
            <th style="text-align: center">ÖĞRENCİ AD</th>
            <th style="text-align: center">ÖĞRENCİ SOYAD</th>
            <th style="text-align: center">ÖĞRENCİ NUMARA</th>
            <th style="text-align: center">ÖĞRENCİ ŞİFRE</th>
            <th style="text-align: center">ÖĞRENCİ FOTOĞRAF</th>
            <th style="text-align: center">ÖĞRENCİ BAKİYE</th>
            <th style="text-align: center">İŞLEMLER</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr style="text-align: center">
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("NAME") %></td>
                        <td><%# Eval("SURNAME") %></td>
                        <td><%# Eval("NUMBER") %></td>
                        <td><%# Eval("PASSWORD") %></td>
                        <td><%# Eval("PHOTOGRAPH") %></td>
                        <td><%# Eval("BALANCE") %></td>
                        <td>
                            <div>
                                <asp:HyperLink NavigateUrl='<%# "StudentDelete.aspx?STUDENTID="+ Eval("ID") %>' ID="btnDelete" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>

                                <asp:HyperLink NavigateUrl='<%# "StudentUpdate.aspx?STUDENTID="+ Eval("ID") %>' ID="btnUpdate" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <asp:HyperLink ID="btnÖğrenciEkle" NavigateUrl="StudentAdd.aspx" runat="server" CssClass="btn btn-info" Width="100%">Öğrenciyi Ekle</asp:HyperLink>

</asp:Content>
