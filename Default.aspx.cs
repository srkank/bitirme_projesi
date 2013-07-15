using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "sepet")
        {
            SepeteAt.SepeteEkle(DataList2.DataKeys[e.Item.ItemIndex].ToString(), ((Label)(DataList2.Items[e.Item.ItemIndex].FindControl("BASLIKLabel"))).Text, ((Label)(DataList2.Items[e.Item.ItemIndex].FindControl("lyenifiyat_"))).Text, 1);
            Response.Redirect(Request.RawUrl);

        }
    }
    protected void DataList2_ItemDataBound(object sender, DataListItemEventArgs e)
    {

        Label eskifiyat = (Label)e.Item.FindControl("FIYATLabel");

        Label yenifiyat = (Label)e.Item.FindControl("lyenifiyat_");


        string[] eskiayrac =eskifiyat.Text.Split('.');

        yenifiyat.Text = eskiayrac[0].ToString();

    }
    protected void AccessDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
}