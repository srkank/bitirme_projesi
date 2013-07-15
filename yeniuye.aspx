<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="yeniuye.aspx.cs" Inherits="yeniuye" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style18
    {
        width: 113px;
    }
    .style19
    {
        width: 5px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style1" style="text-align:left">
    <tr>
        <td class="style18">
            Mail Adresiniz</td>
        <td class="style19">
            :</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="Mail Adresi Giriniz."></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style18">
            Şifre</td>
        <td class="style19">
            :</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox2" ErrorMessage="Şifrenizi Giriniz"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style18">
            Telefon</td>
        <td class="style19">
            .</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="TextBox3" ErrorMessage="Telefon Numaranızı Giriniz."></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style18">
            &nbsp;</td>
        <td class="style19">
            &nbsp;</td>
        <td>
            <asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl="~/yonetim/img/kaydet.png" onclick="ImageButton2_Click" />
        </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

