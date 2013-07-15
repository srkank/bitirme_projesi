<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/MasterPage.master" AutoEventWireup="true" CodeFile="siparisler.aspx.cs" Inherits="yonetim_siparisler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/App_Data/db.mdb" 
        DeleteCommand="DELETE FROM [siparis] WHERE [ID] = ?" 
        InsertCommand="INSERT INTO [siparis] ([ID], [UYEID], [ADRES], [TEL], [DURUMU]) VALUES (?, ?, ?, ?, ?)" 
        SelectCommand="SELECT * FROM [siparis] ORDER BY [ID] DESC" 
        UpdateCommand="UPDATE [siparis] SET [UYEID] = ?, [ADRES] = ?, [TEL] = ?, [DURUMU] = ? WHERE [ID] = ?">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ID" Type="Int32" />
            <asp:Parameter Name="UYEID" Type="Int32" />
            <asp:Parameter Name="ADRES" Type="String" />
            <asp:Parameter Name="TEL" Type="String" />
            <asp:Parameter Name="DURUMU" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="UYEID" Type="Int32" />
            <asp:Parameter Name="ADRES" Type="String" />
            <asp:Parameter Name="TEL" Type="String" />
            <asp:Parameter Name="DURUMU" Type="String" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
    </asp:AccessDataSource>
    <table class="style1">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" DataKeyNames="ID" DataSourceID="AccessDataSource1">
                    <Columns>
                        <asp:CommandField DeleteText="Sil" EditText="Düzenle" SelectText="Detay" 
                            ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" 
                            UpdateText="Güncelle" />
                        <asp:BoundField DataField="ADRES" HeaderText="ADRES" SortExpression="ADRES" />
                        <asp:BoundField DataField="TEL" HeaderText="TEL" SortExpression="TEL" />
                        <asp:BoundField DataField="DURUMU" HeaderText="DURUMU" 
                            SortExpression="DURUMU" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="4" DataKeyNames="ID" DataSourceID="AccessDataSource2" 
                    ForeColor="Black" GridLines="Horizontal">
                    <Columns>
                        <asp:BoundField DataField="SIPID" HeaderText="Sip No" SortExpression="SIPID" />
                        <asp:BoundField DataField="URUN" HeaderText="URUN" SortExpression="URUN" />
                        <asp:BoundField DataField="FIYAT" HeaderText="FIYAT" SortExpression="FIYAT" />
                        <asp:BoundField DataField="ADET" HeaderText="ADET" SortExpression="ADET" />
                        <asp:BoundField DataField="TOPLAM" HeaderText="TOPLAM" 
                            SortExpression="TOPLAM" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
                <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
                    DataFile="~/App_Data/db.mdb" 
                    SelectCommand="SELECT * FROM [sepet] WHERE ([SIPID] = ?)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="GridView1" Name="SIPID" 
                            PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:AccessDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

