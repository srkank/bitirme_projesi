<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sepetiniz.aspx.cs" Inherits="sepetiniz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style23
        {
            color: #FFFFFF;
            width: 656px;
        }
        .style24
        {
            width: 656px;
        }
        
        .style25
        {
            width: 656px;
            height: 18px;
        }
        
        .style26
        {
            width: 656px;
            height: 166px;
        }
        
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style1" style="text-align:left">
    <tr>
        <td bgcolor="#990033" class="style23">
            Sepetiniz</td>
    </tr>
    <tr>
        <td class="style24">
            <asp:DataList ID="DataList2" runat="server" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                GridLines="Both" onitemcommand="DataList2_ItemCommand" Width="467px">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <ItemStyle ForeColor="#000066" />
                <ItemTemplate>
                    <table width="650">
                        <tr>
                            <td align="left">
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("URUN") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" MaxLength="2" 
                                    Text='<%# Eval("ADET") %>' Width="25px"></asp:TextBox>
                            </td>
                            <td align="left">
                                Fiyat :
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("FIYAT") %>'></asp:Label>
                                &nbsp;TL</td>
                            <td align="left">
                                Toplam :<asp:Label ID="Label4" runat="server" Text='<%# Eval("TOPLAM") %>'></asp:Label>
                                &nbsp;TL</td>
                            <td align="left" width="125">
                                <asp:LinkButton ID="LinkButton5" runat="server" CommandName="adet">Adet Güncelle</asp:LinkButton>
                            </td>
                            <td align="left" width="125">
                                <asp:LinkButton ID="LinkButton6" runat="server" CommandName="sil">Ürünü Silin</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            </asp:DataList>
           <center><asp:Label ID="Label5" runat="server" style="color: #BB18E4; font-weight: 700"></asp:Label></center>
        </td>
    </tr>
    <tr>
        <td class="style24">
            <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click">Siparişi Tamamla</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="style25" bgcolor="#990033">
            Şu anda almakta olduğunuz ürünü alanlar aşağıdaki ürünleri de aldılar.</td>
    </tr>
    <tr>
        <td class="style26" valign="middle" width="120">
            <asp:Image ID="Image2" runat="server" Width="120px" Visible="False" />
            <asp:Image ID="Image3" runat="server" Width="120px" Visible="False" />
            <asp:Image ID="Image4" runat="server" Width="120px" Visible="False" />
            <asp:Image ID="Image5" runat="server" Width="120px" Visible="False" />
            <asp:Image ID="Image6" runat="server" Width="120px" Visible="False" />
            
                <br />
            <br />
            <asp:TextBox ID="res1" runat="server" Enabled="False" Visible="False" 
                Width="120px" Font-Bold="True"></asp:TextBox>
            <asp:TextBox ID="res2" runat="server" Enabled="False" Visible="False" 
                Width="120px" Font-Bold="True"></asp:TextBox>
            <asp:TextBox ID="res3" runat="server" Enabled="False" Visible="False" 
                Width="120px" Font-Bold="True"></asp:TextBox>
            <asp:TextBox ID="res4" runat="server" Enabled="False" Visible="False" 
                Width="120px" Font-Bold="True"></asp:TextBox>
            <asp:TextBox ID="res5" runat="server" Enabled="False" Visible="False" 
                Width="120px" Font-Bold="True"></asp:TextBox>
        </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

