<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/MasterPage.master" AutoEventWireup="true" CodeFile="kategoriler.aspx.cs" Inherits="yonetim_kategoriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style3
    {
        width: 62px;
    }
    .style4
    {
        width: 11px;
    }
    .style5
    {
        width: 193px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
    <tr>
        <td class="style3">
            Kategori</td>
        <td class="style4">
            :</td>
        <td class="style5">
            <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="boş geçilemez" ValidationGroup="a"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td align="right" class="style5">
            <asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl="~/yonetim/img/kaydet.png" onclick="ImageButton2_Click" />
        </td>
        <td>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>
</table>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    CellPadding="4" DataKeyNames="ID" DataSourceID="AccessDataSource1" 
    ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
        <asp:CommandField CancelText="Vazgeç" DeleteText="Sil" EditText="Düzenle" 
            ShowDeleteButton="True" ShowEditButton="True" UpdateText="Güncelle" />
        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
            ReadOnly="True" SortExpression="ID" />
        <asp:BoundField DataField="kategori" HeaderText="kategori" 
            SortExpression="kategori" />
    </Columns>
    <EditRowStyle BackColor="#999999" />
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#E9E7E2" />
    <SortedAscendingHeaderStyle BackColor="#506C8C" />
    <SortedDescendingCellStyle BackColor="#FFFDF8" />
    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>
<asp:AccessDataSource ID="AccessDataSource1" runat="server" 
    DataFile="~/App_Data/db.mdb" 
    DeleteCommand="DELETE FROM [kategoriler] WHERE [ID] = ?" 
    InsertCommand="INSERT INTO [kategoriler] ([ID], [kategori]) VALUES (?, ?)" 
    SelectCommand="SELECT * FROM [kategoriler]" 
    UpdateCommand="UPDATE [kategoriler] SET [kategori] = ? WHERE [ID] = ?">
    <DeleteParameters>
        <asp:Parameter Name="ID" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="ID" Type="Int32" />
        <asp:Parameter Name="kategori" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="kategori" Type="String" />
        <asp:Parameter Name="ID" Type="Int32" />
    </UpdateParameters>
</asp:AccessDataSource>
</asp:Content>

