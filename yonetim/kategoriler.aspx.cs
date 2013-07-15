using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_kategoriler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

        DBislem.cmdd.CommandText = "insert into kategoriler(kategori)values(@kategori)";
        DBislem.cmdd.Parameters.Clear();
        DBislem.cmdd.Parameters.AddWithValue("@kategori", TextBox1.Text);
        DBislem.BilgiGonder();
        GridView1.DataBind();
    }
}