<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table table-bordered">
        <tr>
            <th class="text-center">ID</th>
            <th class="text-center">AD SOYAD</th>
            <th class="text-center">MAİL</th>
            <th class="text-center">KONU</th>
            <th class="text-center">MESAJI GÖR</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td class="text-center"><%# Eval("CONTACTID")  %></td>
                    <td class="text-center"><%# Eval("NAMESURNAME")  %></td>
                    <td class="text-center"><%# Eval("MAIL")  %></td>
                    <td class="text-center"><%# Eval("SUBJECT")  %></td>
                    <td class="text-center">
                        <asp:HyperLink ID="btnMessageDetail" runat="server" NavigateUrl='<%# "MessageDetails.aspx?ID=" + Eval("CONTACTID") %>' CssClass="btn btn-warning">MESAJI GÖR</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>

</asp:Content>

