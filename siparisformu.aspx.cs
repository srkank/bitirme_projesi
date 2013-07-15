using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class siparisformu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Server.MapPath(@"App_Data\db.mdb")+";Persist Security Info=True");
        OleDbCommand cmd = new OleDbCommand("insert into siparis (UYEID,ADRES,TEL,DURUMU) values (@UYEID,@ADRES,@TEL,@DURUMU)",baglanti);
        cmd.Parameters.AddWithValue("@UYEID",((DataTable)(Session["UYE"])).Rows[0][0].ToString());
         cmd.Parameters.AddWithValue("@ADRES",TextBox1.Text);
         cmd.Parameters.AddWithValue("@TEL",TextBox2.Text);
         cmd.Parameters.AddWithValue("@DURUMU","Beklemede");
         baglanti.Open();
         cmd.ExecuteNonQuery();
         baglanti.Close();
         OleDbDataAdapter da = new OleDbDataAdapter("select ID from siparis where UYEID=@UYEID order by ID DESC",baglanti);
         da.SelectCommand.Parameters.AddWithValue("@UYEID",((DataTable)(Session["UYE"])).Rows[0][0].ToString());
         DataTable dt = new DataTable();
         da.Fill(dt);
        DataTable sdt=((DataTable)(Session["SEPET"]));
        for (int i = 0; i < sdt.Rows.Count; i++)
			{
                OleDbCommand scmd = new OleDbCommand("insert into sepet (SIPID,URUNID,URUN,FIYAT,ADET,TOPLAM) VALUES (@SIPID,@URUNID,@URUN,@FIYAT,@ADET,@TOPLAM)",baglanti);
                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@SIPID",dt.Rows[0][0].ToString());
            scmd.Parameters.AddWithValue("@URUNID",sdt.Rows[i]["ID"].ToString());
            scmd.Parameters.AddWithValue("@URUN",sdt.Rows[i]["URUN"].ToString());
            scmd.Parameters.AddWithValue("@FIYAT",sdt.Rows[i]["FIYAT"].ToString());
            scmd.Parameters.AddWithValue("@ADET",sdt.Rows[i]["ADET"].ToString());
            scmd.Parameters.AddWithValue("@TOPLAM", sdt.Rows[i]["TOPLAM"].ToString());
            baglanti.Open();
            scmd.ExecuteNonQuery();
            baglanti.Close();
			}
        Label2.Text = "Sipariş Takip Numarasınız : "+dt.Rows[0][0].ToString();
        
    }
}