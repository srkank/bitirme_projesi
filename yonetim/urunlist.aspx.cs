using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class yonetim_urunlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        OleDbDataAdapter da = new OleDbDataAdapter("select * from urunler where KATID=@KATID",DBislem.baglanti);
        da.SelectCommand.Parameters.AddWithValue("@KATID",DropDownList1.SelectedValue);
        DataList2.DataSource = DBislem.dtGetir(da);
        DataList2.DataKeyField = "ID";
        DataList2.DataBind();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        OleDbDataAdapter da = new OleDbDataAdapter("select * from urunler where BASLIK LIKE '%'+@BASLIK+'%' OR KACIKLAMA LIKE '%'+@KACIKLAMA+'%'", DBislem.baglanti);
        da.SelectCommand.Parameters.AddWithValue("@BASLIK", TextBox1.Text);
        da.SelectCommand.Parameters.AddWithValue("@KACIKLAMA", TextBox1.Text);
        DataList2.DataSource = DBislem.dtGetir(da);
        DataList2.DataKeyField = "ID";
        DataList2.DataBind();
    }
}