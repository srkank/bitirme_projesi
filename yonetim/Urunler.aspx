<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Urunler.aspx.cs" Inherits="yonetim_Urunler" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 107px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style3">
                Kategori Seçimi</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    DataSourceID="AccessDataSource1" DataTextField="kategori" DataValueField="ID" 
                    Width="200px">
                </asp:DropDownList>
                <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
                    DataFile="~/App_Data/db.mdb" SelectCommand="SELECT * FROM [kategoriler]">
                </asp:AccessDataSource>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Başlık</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Kısa Açıklama</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Fiyatı</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="80px"></asp:TextBox>
                <asp:MaskedEditExtender
                    ID="MaskedEditExtender1" runat="server" MaskType="Number" Mask="999,99" TargetControlID="TextBox3">
                </asp:MaskedEditExtender>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Resim1</td>
            <td>
                <asp:AsyncFileUpload ID="AsyncFileUpload1" runat="server" 
                    onuploadedcomplete="AsyncFileUpload1_UploadedComplete" clientIdMode="AutoID"/>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Resim2</td>
            <td>
                <asp:AsyncFileUpload ID="AsyncFileUpload2" runat="server" 
                    onuploadedcomplete="AsyncFileUpload2_UploadedComplete" clientIdMode="AutoID"/>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Resim3</td>
            <td>
                <asp:AsyncFileUpload ID="AsyncFileUpload3" runat="server" 
                    onuploadedcomplete="AsyncFileUpload3_UploadedComplete" clientIdMode="AutoID"/>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Detay</td>
            <td>
               <CKEditor:CKEditorControl ID="CKEditorControl1" runat="server" BasePath="ckeditor/" Height="300px" Width="590px"></CKEditor:CKEditorControl>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" 
                    ImageUrl="~/yonetim/img/kaydet.png" onclick="ImageButton1_Click" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

