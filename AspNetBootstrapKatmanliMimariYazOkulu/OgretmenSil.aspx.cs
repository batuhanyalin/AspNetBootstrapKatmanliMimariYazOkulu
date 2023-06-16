using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
public partial class OgretmenSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int ogrtid = Convert.ToInt32(Request.QueryString["OGRTID"]);
        if (Page.IsPostBack==false)
        {
            EntityOgretmen ogrt=new EntityOgretmen();
            ogrt.OGRTID= ogrtid;
            BLLOgretmen.BLLOgretmenSil(ogrt);
            Response.Redirect("Ogretmenler.aspx");
        }

    }
}