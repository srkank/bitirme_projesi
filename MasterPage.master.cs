using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //txtKullanici.Text = "";
        //txtSifre.Text = "";
        //if (Session["SEPET"] != null)
        //{
        //    LinkButton4.Visible = true;
        //    img_basket.Visible = true;
        //}
        //else
        //{
        //    LinkButton4.Visible = false;
        //    img_basket.Visible = false;
        //}
        if (!IsPostBack)
        {
            if (Session["UYE"] != null)
            {
                MultiView1.ActiveViewIndex = 1;
                Label1.Text = "Hoş geldiniz mail adresiniz : " + ((DataTable)(Session["UYE"])).Rows[0]["MAIL"].ToString();
            }
            else
                MultiView1.ActiveViewIndex = 0;
        }
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("guvenlicikis.aspx");
        
    }
    
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath(@"App_Data\db.mdb") + ";Persist Security Info=True");
        OleDbDataAdapter da = new OleDbDataAdapter("select * from uyeler where MAIL=@MAIL AND SIFRE=@SIFRE",baglanti);
        da.SelectCommand.Parameters.AddWithValue("@MAIL",txtKullanici.Text);
        da.SelectCommand.Parameters.AddWithValue("@SIFE", txtSifre.Text);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count>0)
        {
            Session["UYE"] = dt;
            Response.Redirect(Request.RawUrl);
        }
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath(@"App_Data\db.mdb") + ";Persist Security Info=True");
        OleDbDataAdapter da = new OleDbDataAdapter("select * from siparis where ID=@ID",baglanti);
        da.SelectCommand.Parameters.AddWithValue("@ID",TextBox1.Text);
        DataTable dt = new DataTable();
        da.Fill(dt);
        Label2.Text="Siparişiniz Durumu : "+dt.Rows[0]["DURUMU"].ToString();
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        if (Session["UYE"] != null)
            Response.Redirect("sepetiniz.aspx");
        else
        {
            ScriptManager.RegisterStartupScript(Page, typeof(string), Guid.NewGuid().ToString(), "alert('Lütfen Üye Girişi Yapınız')", true);
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    
}
