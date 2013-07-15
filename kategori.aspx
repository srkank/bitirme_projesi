<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="kategori.aspx.cs" Inherits="kategori" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style18
        {
            color: #CC0066;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style1">
    <tr>
        <td bgcolor="#CC0066">
            <asp:Label ID="Label2" runat="server" ForeColor="White"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
</table>
<asp:DataList ID="DataList2" runat="server" DataKeyField="ID" 
        DataSourceID="AccessDataSource1" RepeatColumns="4" 
    RepeatDirection="Horizontal" onitemcommand="DataList2_ItemCommand" 
        style="font-family: Tahoma; font-size: 12px" 
        onitemdatabound="DataList2_ItemDataBound">
        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
            Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
            VerticalAlign="Top" />
        <ItemTemplate>
            <table style="width:195px; text-align:center" align="center">
                <tr>
                    <td colspan="2"><a href=urundetay.aspx?ID=<%#Eval("ID") %>>
                        <asp:Label ID="BASLIKLabel" runat="server" style="font-weight: 700" 
                            Text='<%# Eval("BASLIK") %>' /></a>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="KACIKLAMALabel" runat="server" Font-Size="12px" 
                            ForeColor="#333333" Text='<%# Eval("KACIKLAMA") %>' />
                    </td>
                </tr>
                <tr>
                    <td colspan="2"><a href="urundetay.aspx?ID=<%#Eval("ID") %>"><asp:Image ID="Image1" runat="server"  ImageUrl='<%# "urunresim/"+Eval("RESIM1") %>' Width="150px" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1" /></a>
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:10px">
                        <asp:Label ID="FIYATLabel" runat="server" CssClass="style18" 
                            Text='<%# Eval("FIYAT") %>' Visible="false" />
                             <asp:Label ID="lyenifiyat_" runat="server" CssClass="style18" />
                        <span class="style18">&nbsp;TL</span></td>
                    <td>
                        <asp:ImageButton ID="ImageButton3" runat="server" CommandName="sepet" 
                            ImageUrl="~/img/sepet.png" Width="55" />
                    </td>
                </tr>
            </table>
<br />
        </ItemTemplate>
    </asp:DataList>
     <asp:Label ID="lurunyok" runat="server" />
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/App_Data/db.mdb" 
    SelectCommand="SELECT * FROM [urunler] WHERE ([KATID] = ?)">
        <SelectParameters>
            <asp:QueryStringParameter Name="KATID" QueryStringField="ID" Type="Int32" />
        </SelectParameters>
    </asp:AccessDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

