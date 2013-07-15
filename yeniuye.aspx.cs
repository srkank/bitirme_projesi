using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class yeniuye : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
         OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath(@"App_Data\db.mdb") + ";Persist Security Info=True");
         OleDbCommand cmd = new OleDbCommand("insert into uyeler (MAIL,SIFRE,TELEFON)VALUES(@MAIL,@SIFRE,@TELEFON)",baglanti);
         cmd.Parameters.AddWithValue("@MAIL",TextBox1.Text);
         cmd.Parameters.AddWithValue("@SIFRE",TextBox2.Text);
         cmd.Parameters.AddWithValue("@TELEFON",TextBox3.Text);
         baglanti.Open();
         cmd.ExecuteNonQuery();
         baglanti.Close();
         OleDbDataAdapter da = new OleDbDataAdapter("select * from uyeler where MAIL=@MAIL AND SIFRE=@SIFRE",baglanti);
         da.SelectCommand.Parameters.AddWithValue("@MAIL",TextBox1.Text);
         da.SelectCommand.Parameters.AddWithValue("@SIFRE",TextBox2.Text);
         DataTable dt = new DataTable();
         da.Fill(dt);
         Session["UYE"] = dt;
         Response.Redirect("default.aspx");
    }
}