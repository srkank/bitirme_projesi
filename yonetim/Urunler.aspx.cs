using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Urunler : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {
        string isim = DateTime.Now.Date.Day.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + AsyncFileUpload1.FileBytes.Length.ToString() + ".jpg";
        Session["resim1"] = isim;
        AsyncFileUpload1.SaveAs(Server.MapPath(@"..\urunresim\"+isim));
    }
    protected void AsyncFileUpload2_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {
        string isim = DateTime.Now.Date.Day.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + AsyncFileUpload2.FileBytes.Length.ToString() + ".jpg";
        Session["resim2"] = isim;
        AsyncFileUpload2.SaveAs(Server.MapPath(@"..\urunresim\" + isim));
    }
    protected void AsyncFileUpload3_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
    {
        string isim = DateTime.Now.Date.Day.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + AsyncFileUpload3.FileBytes.Length.ToString() + ".jpg";
        Session["resim3"] = isim;
        AsyncFileUpload3.SaveAs(Server.MapPath(@"..\urunresim\" + isim));
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        DBislem.cmdd.CommandText = "insert into urunler (KATID,KATEGORI,BASLIK,KACIKLAMA,FIYAT,RESIM1,RESIM2,RESIM3,DETAY) VALUES (@KATID,@KATEGORI,@BASLIK,@KACIKLAMA,@FIYAT,@RESIM1,@RESIM2,@RESIM3,@DETAY)";
        DBislem.cmdd.Parameters.Clear();
        DBislem.cmdd.Parameters.AddWithValue("@KATID",DropDownList1.SelectedValue);
        DBislem.cmdd.Parameters.AddWithValue("@KATEGORI",DropDownList1.SelectedItem.Text);
        DBislem.cmdd.Parameters.AddWithValue("@BASLIK",TextBox1.Text);
        DBislem.cmdd.Parameters.AddWithValue("@KACIKLAMA",TextBox2.Text);
        DBislem.cmdd.Parameters.AddWithValue("@FIYAT",TextBox3.Text);
        DBislem.cmdd.Parameters.AddWithValue("@RESIM1",Session["resim1"].ToString());
        DBislem.cmdd.Parameters.AddWithValue("@RESIM2",Session["resim2"].ToString());
        DBislem.cmdd.Parameters.AddWithValue("@RESIM3",Session["resim3"].ToString());
        DBislem.cmdd.Parameters.AddWithValue("@DETAY",CKEditorControl1.Text);
        DBislem.BilgiGonder();
        Response.Redirect("urunlist.aspx");
    }
}