using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
 

public partial class sepetiniz : System.Web.UI.Page
{
   
    // "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + HttpContext.Current.Server.MapPath(@"\App_Data\db.mdb") + ";Persist Security Info=True"
    public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Serkan\\Desktop\\proje\\App_Data\\db.mdb;Persist Security Info=True");
    //public static string connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=yourdatabasename.mdb;";
    public static OleDbCommand cmdd = new OleDbCommand();

    public static OleDbDataAdapter adapter;
    public static OleDbDataAdapter adapter2;
    public static DataTable sepettable;
    public static DataTable tmptable;


    
    public static List<int> sip_idler()
    {
        List<int> siparis_id = new List<int>();
        

        string sonuc = "işleminiz gerçekleştirildi.";
        cmdd.Connection = baglanti;

        if (baglanti.State == ConnectionState.Open)
            baglanti.Close();
        try
        {
            OleDbDataReader dr;
            baglanti.Open();
            cmdd.CommandText = "select * from siparis";
            dr = cmdd.ExecuteReader();
            while (dr.Read())
                siparis_id.Add(dr.GetInt32(0));
            baglanti.Close();
        }
        catch (Exception ex)
        {
            sonuc = "hata : " + ex.Message;
        }

        baglanti.Close();
        return siparis_id;
    }

    public static List<List<int>> hepsi()
    {
        List<List<int>> al_urunler = new List<List<int>>();
        

        string sonuc = "işleminiz gerçekleştirildi.";
        cmdd.Connection = baglanti;

        if (baglanti.State == ConnectionState.Open)
            baglanti.Close();
        try
        {
            foreach (int i in sip_idler())
            {
                List<int> gecici = new List<int>();
                OleDbDataReader dr;
                baglanti.Open();
                cmdd.CommandText = "select * from sepet where SIPID = " + i.ToString();
                dr = cmdd.ExecuteReader();
                while (dr.Read())
                    gecici.Add(dr.GetInt32(2));
                baglanti.Close();
                al_urunler.Add(gecici);
            }
        }
        catch (Exception ex)
        {
            sonuc = "hata : " + ex.Message;
        }
        return al_urunler;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
        List<int> sepet_urun = new List<int>();
        if (!IsPostBack)
        {
          
            DataList2.DataSource = SepeteAt.sepetim();
            DataList2.DataKeyField = "ID";
            DataList2.DataBind();
            
            if (DataList2.Items.Count == 0)
            {
                Label5.Text = "Sepetiniz Boş";
                LinkButton7.Visible = false;
            }
            else
            {
                int index = DataList2.Items.Count;
                string[][] s = new string[index][];
                DataTable t = SepeteAt.sepetim();
                Hashtable hash = new Hashtable();
                for (int i = 0; i < DataList2.Items.Count; i++)
                    sepet_urun.Add(Convert.ToInt32(t.Rows[i][0]));
                
                List<List<int>> ikisi = new List<List<int>>();
                List<int> sonuclar = new List<int>();
                List<int> guvenler = new List<int>();
                int minguven=0, eskdestek=0, eskdkat=0;

                string sonuc = "işleminiz gerçekleştirildi.";
                cmdd.Connection = baglanti;

                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                try
                {
                    

                    OleDbDataReader dr;
                    baglanti.Open();
                    cmdd.CommandText = "select * from destek";
                    dr = cmdd.ExecuteReader();
                    while (dr.Read())
                    {
                        minguven = dr.GetInt32(0);
                        eskdestek = dr.GetInt32(1);
                        eskdkat = dr.GetInt32(2);
                    }
                }
                catch (Exception ex)
                {
                    sonuc = "hata : " + ex.Message;
                }
      
                ikisi = apriory.urun_eleme(hepsi(), sepet_urun, minguven, eskdestek, eskdkat);
                

                if (ikisi.Count == 1)
                {
                    res1.Visible = true;
                    res1.Text = "güven: %" + ikisi[0][1];

                    Image2.Visible = true;
                    Image2.ImageUrl = "urunresim/" + DBislem.Image(ikisi[0][0].ToString());
                }
                else if (ikisi.Count == 2)
                {
                    res1.Visible = true;
                    res1.Text = "güven: %" + ikisi[0][1];
                    res2.Visible = true;
                    res2.Text = "güven: %" + ikisi[1][1];

                    Image2.Visible = true;
                    Image3.Visible = true;
                    Image2.ImageUrl = "urunresim/" + DBislem.Image(ikisi[0][0].ToString());
                    Image3.ImageUrl = "urunresim/" + DBislem.Image(ikisi[1][0].ToString());
                }
                else if (ikisi.Count == 3)
                {
                    res1.Visible = true;
                    res1.Text = "güven: %" + ikisi[0][1];
                    res2.Visible = true;
                    res2.Text = "güven: %" + ikisi[1][1];
                    res3.Visible = true;
                    res3.Text = "güven: %" + ikisi[2][1];

                    Image2.Visible = true;
                    Image3.Visible = true;
                    Image4.Visible = true;
                    Image2.ImageUrl = "urunresim/" + DBislem.Image(ikisi[0][0].ToString());
                    Image3.ImageUrl = "urunresim/" + DBislem.Image(ikisi[1][0].ToString());
                    Image4.ImageUrl = "urunresim/" + DBislem.Image(ikisi[2][0].ToString());
                }
                else if (ikisi.Count == 4)
                {
                    res1.Visible = true;
                    res1.Text = "güven: %" + ikisi[0][1];
                    res2.Visible = true;
                    res2.Text = "güven: %" + ikisi[1][1];
                    res3.Visible = true;
                    res3.Text = "güven: %" + ikisi[2][1];
                    res4.Visible = true;
                    res4.Text = "güven: %" + ikisi[3][1];

                    Image2.Visible = true;
                    Image3.Visible = true;
                    Image4.Visible = true;
                    Image5.Visible = true;
                    Image2.ImageUrl = "urunresim/" + DBislem.Image(ikisi[0][0].ToString());
                    Image3.ImageUrl = "urunresim/" + DBislem.Image(ikisi[1][0].ToString());
                    Image4.ImageUrl = "urunresim/" + DBislem.Image(ikisi[2][0].ToString());
                    Image5.ImageUrl = "urunresim/" + DBislem.Image(ikisi[3][0].ToString());
                }
                else if (ikisi.Count >= 5)
                {
                    res1.Visible = true;
                    res1.Text = "güven: %" + ikisi[0][1];
                    res2.Visible = true;
                    res2.Text = "güven: %" + ikisi[1][1];
                    res3.Visible = true;
                    res3.Text = "güven: %" + ikisi[2][1];
                    res4.Visible = true;
                    res4.Text = "güven: %" + ikisi[3][1];
                    res5.Visible = true;
                    res5.Text = "güven: %" + ikisi[4][1];

                    Image2.Visible = true;
                    Image3.Visible = true;
                    Image4.Visible = true;
                    Image5.Visible = true;
                    Image6.Visible = true;
                    Image2.ImageUrl = "urunresim/" + DBislem.Image(ikisi[0][0].ToString());
                    Image3.ImageUrl = "urunresim/" + DBislem.Image(ikisi[1][0].ToString());
                    Image4.ImageUrl = "urunresim/" + DBislem.Image(ikisi[2][0].ToString());
                    Image5.ImageUrl = "urunresim/" + DBislem.Image(ikisi[3][0].ToString());
                    Image6.ImageUrl = "urunresim/" + DBislem.Image(ikisi[4][0].ToString());
                }
 
            }
        }
    }


    protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName=="sil")
        {
            SepeteAt.SepetSil(DataList2.DataKeys[e.Item.ItemIndex].ToString());
            Response.Redirect(Request.RawUrl);
        }
        else if (e.CommandName=="adet")
        {
            SepeteAt.adetGuncelle(DataList2.DataKeys[e.Item.ItemIndex].ToString(), ((TextBox)(DataList2.Items[e.Item.ItemIndex].FindControl("TextBox1"))).Text);
            Response.Redirect(Request.RawUrl);
        }
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        if (Session["UYE"] != null)
            Response.Redirect("siparisformu.aspx");
        else
        {
            ScriptManager.RegisterStartupScript(Page, typeof(string), Guid.NewGuid().ToString(), "alert('Lütfen Üye Girişi Yapınız')", true);
        }
    }

    protected void res1_TextChanged(object sender, EventArgs e)
    {

    }
}