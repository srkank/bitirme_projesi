<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/MasterPage.master" AutoEventWireup="true" CodeFile="kullaniciislemleri.aspx.cs" Inherits="yonetim_kullaniciislemleri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style3
    {
        width: 85px;
    }
    .style4
    {
        width: 13px;
    }
    .style5
    {
        width: 198px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
    <tr>
        <td class="style3">
            Kullanıcı Adı</td>
        <td class="style4">
            :</td>
        <td class="style5">
            <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="Boş Geçilemez" ValidationGroup="a"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Şifre</td>
        <td class="style4">
            :</td>
        <td class="style5">
            <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox2" ErrorMessage="Boş Geçilemez" ValidationGroup="a"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td align="right" class="style5">
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/yonetim/img/kaydet.png" onclick="ImageButton1_Click" 
                ValidationGroup="a" />
        </td>
        <td>
            <asp:Label ID="Label1" runat="server" style="font-weight: 700; color: #FF0000"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>

