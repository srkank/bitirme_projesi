using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class yonetim_guven_deger : System.Web.UI.Page
{
    public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Serkan\\Desktop\\proje\\App_Data\\db.mdb;Persist Security Info=True");
    //public static string connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=yourdatabasename.mdb;";
    public static OleDbCommand cmdd = new OleDbCommand();

    public static OleDbDataAdapter adapter;
    public static OleDbDataAdapter adapter2;
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void onay_Click(object sender, EventArgs e)
    {
        string sonuc = "işleminiz gerçekleştirildi.";
        cmdd.Connection = baglanti;

        if (baglanti.State == ConnectionState.Open)
            baglanti.Close();
        try
        {
             
               
                baglanti.Open();
                cmdd.CommandText = string.Format("update destek set min_guven = {0}, esk_dest={1}, esk_destk = {2}",minguv.Text, dested.Text, dedk.Text);
                cmdd.ExecuteNonQuery();
                
                baglanti.Close();
                
            
        }
        catch (Exception ex)
        {
            sonuc = "hata : " + ex.Message;
        }
        Label1.Text = "işlem başarıyla gerçekleştirildi!";
    }
}