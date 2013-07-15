using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for DBislem
/// </summary>
public static class DBislem
{
    // "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + HttpContext.Current.Server.MapPath(@"\App_Data\db.mdb") + ";Persist Security Info=True"
    public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Serkan\\Desktop\\proje\\App_Data\\db.mdb;Persist Security Info=True");
    //public static string connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=yourdatabasename.mdb;";
    public static OleDbCommand cmdd = new OleDbCommand();

    public static OleDbDataAdapter adapter;
    public static OleDbDataAdapter adapter2;
    public static DataTable sepettable;
    public static DataTable tmptable;

    public static string BilgiGonder()
    {
        string sonuc = "işleminiz gerçekleştirildi.";


        cmdd.Connection = baglanti;
        if (baglanti.State == ConnectionState.Open)
            baglanti.Close();
        try
        {
            baglanti.Open();
            cmdd.ExecuteNonQuery();
            baglanti.Close();
        }
        catch (Exception ex)
        {
            sonuc = "hata : " + ex.Message;
        }
       
        return sonuc;
    }

    /*resmi urun id buraya*/
    public static string Image(string urunid)
    {
        string sonuc = "işleminiz gerçekleştirildi.";
        cmdd.Connection = baglanti;
        if (baglanti.State == ConnectionState.Open)
            baglanti.Close();
        try
        {
            baglanti.Open();
            cmdd.CommandText = "select * from urunler where ID = " + urunid;
            adapter = new OleDbDataAdapter(cmdd);
            sepettable = new DataTable();
            adapter.Fill(sepettable);
            sonuc = sepettable.Rows[0][6].ToString();
        }
        catch (Exception ex)
        {
            sonuc = "hata : " + ex.Message;
        }

        baglanti.Close();
        return sonuc;
    }
    /*********************************************/
    public static void secici()
    {
        List<int> siparis_id = new List<int>();
        
        List<List<int>> al_urunler= new List<List<int>>();
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
                siparis_id.Add( dr.GetInt32(0));
            baglanti.Close();
            
            OleDbDataReader dr1;
            baglanti.Open();
            
            foreach (int i in siparis_id)
            {
                List<int> gecici = new List<int>();
                cmdd.CommandText = "select * from sepet where SIPID = " + i.ToString();
                dr1 = cmdd.ExecuteReader();
                while(dr1.Read())
                    gecici.Add(dr1.GetInt32(2));
                al_urunler.Add(gecici);
            }

        }
        catch (Exception ex)
        {
            sonuc = "hata : " + ex.Message;
        }

        baglanti.Close();
        //foreach (int i in apriory.urun_eleme(al_urunler,))
           // Image(i);
    }
    
    public static string[] BilgiAl(string urunid)
    {
        string sonuc = "işleminiz gerçekleştirildi.";
        string[] s = new string[1];
        cmdd.Connection = baglanti;
        if (baglanti.State == ConnectionState.Open)
            baglanti.Close();
        try
        {
            baglanti.Open();
            cmdd.CommandText = "select * from sepet where URUNID = " + urunid;
            adapter = new OleDbDataAdapter(cmdd);
            sepettable = new DataTable();
            adapter.Fill(sepettable);
            int yandex = 0;
            int yindex = 0;
            //sonuc = sepettable.Rows[0][2].ToString();
            for(int i = 0; i < sepettable.Rows.Count; i++)
            {
                cmdd.CommandText = "select * from sepet where SIPID = " + sepettable.Rows[i][1].ToString() + " and not URUNID = " + urunid;
                adapter2 = new OleDbDataAdapter(cmdd);
                tmptable = new DataTable();
                adapter.Fill(tmptable);

                yandex += tmptable.Rows.Count;
            }

            s = new string[yandex];

            for (int i = 0; i < sepettable.Rows.Count; i++)
            {
                cmdd.CommandText = "select * from sepet where SIPID = " + sepettable.Rows[i][1].ToString() + " and not URUNID = " + urunid;
                adapter2 = new OleDbDataAdapter(cmdd);
                tmptable = new DataTable();
                adapter.Fill(tmptable);

                for (int j = 0; j < tmptable.Rows.Count; j++)
                {
                    s[yindex++] = tmptable.Rows[j][2].ToString();
                }
            }
        }
        catch (Exception ex)
        {
            sonuc = "hata : " + ex.Message;
        }

        baglanti.Close();
        return s;
    }

    public static DataTable dtGetir(OleDbDataAdapter da)
    {
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
    
}



 