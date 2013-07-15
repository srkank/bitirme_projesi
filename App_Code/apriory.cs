using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for apriory
/// </summary>
public static class apriory
{
	
    /*************************Alt kumeleri bulan kısım************************************/
    static List<List<int>> alt_kume_bul(List<int> liste)
    {
        int len = liste.Count;
        string startString = "1".PadLeft(len, '0');

        List<List<int>> alt_kumeler = new List<List<int>>();


        while (startString != string.Empty)
        {
            List<int> gecici = new List<int>();
            for (int i = 0; i < len; i++)
            {
                if (startString[i] == '1')
                    gecici.Add(liste[i]);
            }
            gecici.Sort();
            if (gecici.Count > 0)
                alt_kumeler.Add(gecici);
            startString = GetNexString(startString);
        }
        return alt_kumeler;
    }
    static string GetNexString(string str)
    {
        int pos0 = str.LastIndexOf('0');
        if (pos0 == -1) return string.Empty;
        int len = str.Length;
        str = str.Substring(0, pos0) + "1";
        return str.PadRight(len, '0');
    }
    /************************************************************************************/


    /******************ürünlerin elenip finale kalan ürünlerin döndürüldügü yer***************************/
    public static List<List<int>> urun_eleme(List<List<int>> liste, List<int> alinan, int min_guven, int destek_esik, int esdest_katsayi)
    {
        alinan.Sort();
        double es_dest_say = (destek_esik / 100.0) * esdest_katsayi;
        double guven, adet, sepet_adet = 0;
        List<int> deneme = new List<int>();
        deneme.Add(3);
        List<List<int>> tum_altkumeler = new List<List<int>>();
        List<List<int>> siniri_gecenalt = new List<List<int>>();
        List<List<int>> ikiligrup3 = new List<List<int>>();
        foreach (List<int> i in liste)
        {
            foreach (List<int> j in alt_kume_bul(i))
            {
                tum_altkumeler.Add(j);
            }
        }

        foreach (List<int> i in tum_altkumeler)
        {
            List<int> gecici = new List<int>();
            foreach (int l in i)
                gecici.Add(l);
            gecici.Add(tum_altkumeler.Count(x => x.SequenceEqual(i)));
            if (tum_altkumeler.Count(x => x.SequenceEqual(i)) >= es_dest_say && siniri_gecenalt.Count(x => x.SequenceEqual(gecici)) == 0)
            {
                siniri_gecenalt.Add(gecici);
            }
        }

        List<List<int>> onerilen_urunlist = new List<List<int>>();

        foreach (List<int> i in siniri_gecenalt)
        {
            if (i.Count - 1 == alinan.Count && i.Skip(0).Take(i.Count - 1).SequenceEqual(alinan))
                sepet_adet = i[i.Count - 1];
            adet = i[i.Count - 1];

            if (alinan.All(itm2 => i.Skip(0).Take(i.Count - 1).Contains(itm2)) && i.Count == alinan.Count + 2)
            {              
                guven = Math.Floor((adet / (sepet_adet * 1.0)) * 100);
                
                if (guven >= min_guven)
                    foreach (int onerilen in i.Skip(0).Take(i.Count - 1))
                    {
                        List<int> guven_list = new List<int>();
                        if (!alinan.Contains(onerilen))
                        {

                            guven_list.Add(onerilen);
                            guven_list.Add(Convert.ToInt32(guven));
                            onerilen_urunlist.Add(guven_list);
                        }

                    }
            }
        }
        
        onerilen_urunlist.Sort((a, b) => b[1].CompareTo(a[1]));
        return onerilen_urunlist;
    }

    /***********************************************************************************************/

}