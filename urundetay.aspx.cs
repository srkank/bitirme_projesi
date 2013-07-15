using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class urundetay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName=="sepet")
        {
            SepeteAt.SepeteEkle(DataList2.DataKeys[e.Item.ItemIndex].ToString(), ((Label)(DataList2.Items[e.Item.ItemIndex].FindControl("BASLIKLabel"))).Text, ((Label)(DataList2.Items[e.Item.ItemIndex].FindControl("FIYATLabel"))).Text, 1);
            Response.Redirect(Request.RawUrl);
                
        }
    }
}