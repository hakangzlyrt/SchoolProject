<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Recourse.aspx.cs" Inherits="Recourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th style="text-align: center">DERS TALEP ID</th>
            <th style="text-align: center">ÖĞRENCİ ADI</th>
            <th style="text-align: center">DERS ADI</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr style="text-align: center">
                        <td><%# Eval("RECOURSEID") %></td>
                        <td><%# Eval("StudentFullName") %></td>
                        <td><%# Eval("CourseName") %></td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
