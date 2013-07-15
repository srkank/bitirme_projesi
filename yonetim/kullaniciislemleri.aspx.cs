using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class yonetim_kullaniciislemleri : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from kullanici",DBislem.baglanti);
            TextBox1.Text = DBislem.dtGetir(da).Rows[0][1].ToString();
            TextBox2.Text=DBislem.dtGetir(da).Rows[0][2].ToString();
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        DBislem.cmdd.CommandText = "UPDATE kullanici SET KULLANICIADI=@KULLANICIADI,SIFRE=@SIFRE";
        DBislem.cmdd.Parameters.Clear();
        DBislem.cmdd.Parameters.AddWithValue("@KULLANICIADI",TextBox1.Text);
        DBislem.cmdd.Parameters.AddWithValue("@SIFRE=@SIFRE",TextBox2.Text);
        Label1.Text = DBislem.BilgiGonder();

    }
}