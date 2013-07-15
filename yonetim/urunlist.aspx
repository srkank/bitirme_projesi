<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/MasterPage.master" AutoEventWireup="true" CodeFile="urunlist.aspx.cs" Inherits="yonetim_urunlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 113px;
        }
        .style4
        {
            width: 393px;
        }
        .style5
        {
            width: 393px;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style3">
                Kategoriye Göre</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    DataSourceID="AccessDataSource1" DataTextField="kategori" DataValueField="ID">
                </asp:DropDownList>
                <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
                    DataFile="~/App_Data/db.mdb" SelectCommand="SELECT * FROM [kategoriler]">
                </asp:AccessDataSource>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Ürün Arama</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Arama</asp:LinkButton>
&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Kategoriye Göre Ürün Getir</asp:LinkButton>
            </td>
        </tr>
    </table>
    <br />
    <table class="style1">
        <tr>
            <td class="style5">
                İlgi Ürünler</td>
            <td>
                <b>En Son Eklenen Ürün</b></td>
        </tr>
        <tr>
            <td class="style4" valign="top">
                <asp:DataList ID="DataList2" runat="server" RepeatColumns="2" 
                    RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <table class="style1">
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" style="font-weight: 700" 
                                        Text='<%# Eval("KATEGORI") %>'></asp:Label>
                                </td>
                                <td rowspan="5" valign="top">
                                    <asp:Image ID="Image1" runat="server" Height="50px" 
                                        ImageUrl='<%# "../urunresim/"+Eval("RESIM1") %>' Width="50px" />
                                    <br />
                                    <asp:Image ID="Image2" runat="server" Height="50px" 
                                        ImageUrl='<%# "../urunresim/"+Eval("RESIM2") %>' Width="50px" />
                                    <br />
                                    <asp:Image ID="Image3" runat="server" Height="50px" 
                                        ImageUrl='<%# "../urunresim/"+Eval("RESIM3") %>' Width="50px" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("BASLIK") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("KACIKLAMA") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("FIYAT") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
                </td>
            <td valign="top">
                <asp:DataList ID="DataList1" runat="server" DataSourceID="AccessDataSource2">
                    <ItemTemplate>
                        <table class="style1">
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" style="font-weight: 700" 
                                        Text='<%# Eval("KATEGORI") %>'></asp:Label>
                                </td>
                                <td rowspan="5" valign="top">
                                    <asp:Image ID="Image1" runat="server" Height="50px" 
                                        ImageUrl='<%# "../urunresim/"+Eval("RESIM1") %>' Width="50px" />
                                    <br />
                                    <asp:Image ID="Image2" runat="server" Height="50px" 
                                        ImageUrl='<%# "../urunresim/"+Eval("RESIM2") %>' Width="50px" />
                                    <br />
                                    <asp:Image ID="Image3" runat="server" Height="50px" 
                                        ImageUrl='<%# "../urunresim/"+Eval("RESIM3") %>' Width="50px" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("BASLIK") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("KACIKLAMA") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("FIYAT") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
                <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
                    DataFile="~/App_Data/db.mdb" 
                    SelectCommand="SELECT top 1 * FROM [urunler] ORDER BY [ID] DESC">
                </asp:AccessDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

