<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="urundetay.aspx.cs" Inherits="urundetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style18
        {
            color: #CC0066;
        }
        .style19
        {
            width: 118px;
        }
        .style20
        {
            width: 136px;
        }
        .style21
        {
            color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style1" style="text-align:left">
        <tr>
            <td bgcolor="#990033" class="style21">
                Ürün Detayı</td>
        </tr>
        <tr>
            <td>
<asp:DataList ID="DataList2" runat="server" DataKeyField="ID" 
        DataSourceID="AccessDataSource1" RepeatColumns="4" 
    RepeatDirection="Horizontal" onitemcommand="DataList2_ItemCommand">
    <ItemTemplate>
        <table style="width: 103%">
            <tr>
                <td>
                    <asp:Label ID="BASLIKLabel" runat="server" style="font-weight: 700" 
                            Text='<%# Eval("BASLIK") %>' />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="KACIKLAMALabel" runat="server" Font-Size="12px" 
                            ForeColor="#333333" Text='<%# Eval("KACIKLAMA") %>' />
                </td>
            </tr>
            <tr>
                <td>
                    <table class="style1" style="width: 46%">
                        <tr>
                            <td class="style19">
                                <asp:Image ID="Image1" runat="server" 
                                    ImageUrl='<%# "urunresim/"+Eval("RESIM1") %>' Width="150px" />
                            </td>
                            <td class="style20">
                                <asp:Image ID="Image2" runat="server" 
                                    ImageUrl='<%# "urunresim/"+Eval("RESIM2") %>' Width="150px" />
                            </td>
                            <td>
                                <asp:Image ID="Image3" runat="server" 
                                    ImageUrl='<%# "urunresim/"+Eval("RESIM3") %>' Width="150px" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="FIYATLabel" runat="server" CssClass="style18" 
                            Text='<%# Eval("FIYAT") %>' />
                    <span class="style18">&nbsp;TL</span></td>
            </tr>
            <tr>
                <td align="right">
                    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/sepet.png" 
                        CommandName="sepet" />
                </td>
            </tr>
        </table>
        <asp:Label ID="Label2" runat="server" Text='<%# Eval("DETAY") %>'></asp:Label>
        <br />
    </ItemTemplate>
</asp:DataList>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/App_Data/db.mdb" 
    SelectCommand="SELECT * FROM [urunler] WHERE ([ID] = ?)">
        <SelectParameters>
            <asp:QueryStringParameter Name="ID" QueryStringField="ID" Type="Int32" />
        </SelectParameters>
    </asp:AccessDataSource>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

