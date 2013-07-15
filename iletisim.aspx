<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style18
    {
        color: #FFFFFF;
    }
    .style19
    {
        width: 91px;
    }
    .style20
    {
        width: 60px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style1" style="text-align:left">
    <tr>
        <td bgcolor="#CC0066" class="style18">
            İletişim</td>
    </tr>
    <tr>
        <td>
            <table class="style1">
                <tr>
                    <td class="style19">
                        Adres bilgileri</td>
                    <td>
                        Adres bilgileri</td>
                </tr>
                <tr>
                    <td class="style19">
                        Tel-Fax</td>
                    <td>
                        telefon bilgileri</td>
                </tr>
                <tr>
                    <td class="style19">
                        Mail</td>
                    <td>
                        <a href="mailto:mail@mailadresi.com">mail@mailadresi.com</a></td>
                </tr>
                <tr>
                    <td class="style19">
                        &nbsp;</td>
                    <td>
                        <table class="style1">
                            <tr>
                                <td class="style20">
                                    Adınız</td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style20">
                                    Mailiniz</td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style20">
                                    Mesajınız</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" Height="69px" TextMode="MultiLine" 
                                        Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style20">
                                    &nbsp;</td>
                                <td>
                                    <asp:ImageButton ID="ImageButton2" runat="server" 
                                        ImageUrl="~/img/btngonder.png" onclick="ImageButton2_Click" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

