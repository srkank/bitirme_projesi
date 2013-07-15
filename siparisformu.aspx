<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="siparisformu.aspx.cs" Inherits="siparisformu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style18
    {
        width: 92px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style1">
    <tr>
        <td class="style18">
            Teslim Adresi</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" BackColor="#CCCC00" Height="58px" 
                TextMode="MultiLine" Width="207px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style18">
            Teslim Telefon</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style18">
            &nbsp;</td>
        <td>
            <asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click">Siparişi Gönder</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="style18">
            &nbsp;</td>
        <td>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

