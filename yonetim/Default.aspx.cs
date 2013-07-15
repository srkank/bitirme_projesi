using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class yonetim_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
  
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        OleDbDataAdapter da = new OleDbDataAdapter("select * from kullanici where KULLANICIADI=@KULLANICIADI AND SIFRE=@SIFRE", DBislem.baglanti);
        da.SelectCommand.Parameters.AddWithValue("@KULLANICIADI", TextBox2.Text);
        da.SelectCommand.Parameters.AddWithValue("@SIFRE", TextBox3.Text);
        if (DBislem.dtGetir(da).Rows.Count > 0)
        {
            Session["ADMIN"] = "ok";
            Response.Redirect("kullaniciislemleri.aspx");
        }
        else
            Label1.Text = "Bilgileriniz Hatalıdır...";
    }
}