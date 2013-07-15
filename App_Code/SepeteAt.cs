using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for SepeteAt
/// </summary>
public static class SepeteAt
{
    public static DataTable sepetim()
    {
        DataTable dt = ((DataTable)(HttpContext.Current.Session["SEPET"]));
        
        return dt;
    }
    
    public static void SepeteEkle(string ID,string URUN,string FIYAT, int ADET)
    {

        double UrunFiyat=Convert.ToDouble(FIYAT.Replace(".",","));
        if (HttpContext.Current.Session["SEPET"]!=null)
	{
		 DataTable dt=((DataTable)(HttpContext.Current.Session["SEPET"]));
            bool varyok=false;
            for (int i = 0; i < dt.Rows.Count; i++)
			{
			  if (dt.Rows[i]["ID"].ToString()==ID)
	            {
		             int UrunADET=Convert.ToInt32(dt.Rows[i]["ADET"].ToString());
                     UrunADET++;
                  double Toplam=UrunFiyat*UrunADET;
                  dt.Rows[i]["TOPLAM"]=Toplam;
                  dt.Rows[i]["ADET"]=UrunADET;
                  varyok=true;

	            }
			}
            if (varyok)
	{
		 HttpContext.Current.Session["SEPET"]=dt;
	}
            else
	{
               DataRow dr=dt.NewRow();
                dr["ID"]=ID;
                dr["URUN"]=URUN;
                dr["ADET"]=ADET;
                dr["FIYAT"]=UrunFiyat;
                dt.Rows.Add(dr);
	}
	}
        else
	{
        DataTable dt = new DataTable();
        dt.Columns.Add("ID");
        dt.Columns.Add("URUN");
        dt.Columns.Add("ADET");
        dt.Columns.Add("FIYAT");
        dt.Columns.Add("TOPLAM");
        DataRow dr = dt.NewRow();
        dr["ID"] = ID;
        dr["URUN"] = URUN;
        dr["ADET"] = ADET;
        dr["FIYAT"] = UrunFiyat;
        dr["TOPLAM"] = (UrunFiyat * ADET).ToString();
        dt.Rows.Add(dr);
        HttpContext.Current.Session["SEPET"] = dt;
	}
    }
   public static void SepetSil(string ID)
   {
       DataTable dt=((DataTable)(HttpContext.Current.Session["SEPET"]));
       for (int i = 0; i < dt.Rows.Count; i++)
			{
			  if (dt.Rows[i]["ID"].ToString()==ID)
	{
		 dt.Rows[i].Delete();
	}
              HttpContext.Current.Session["SEPET"] = dt;
			}
   }
   public static void adetGuncelle(string ID,string ADET)
   {
       DataTable dt = ((DataTable)(HttpContext.Current.Session["SEPET"]));
       for (int i = 0; i < dt.Rows.Count; i++)
       {
           if (dt.Rows[i]["ID"].ToString()==ID)
           {
               double fiyat = Convert.ToDouble(dt.Rows[i]["FIYAT"].ToString());
               double toplam = fiyat * Convert.ToInt32(ADET);
               dt.Rows[i]["ADET"] = ADET;
               dt.Rows[i]["TOPLAM"] = toplam;

           }
       }
       HttpContext.Current.Session["SEPET"] = dt;
   }
}