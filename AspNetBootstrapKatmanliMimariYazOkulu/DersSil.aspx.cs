using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
public partial class DersSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int dersid = Convert.ToInt32(Request.QueryString["DERSID"]);
        if (Page.IsPostBack == false)
        {
            EntityDers ent=new EntityDers();
            ent.DERSID = dersid;
            BLLDers.BLLDersSil(ent);
            Response.Redirect("Dersler.aspx");
        }

    }
}