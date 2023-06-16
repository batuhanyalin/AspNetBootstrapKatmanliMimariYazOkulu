using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class DersGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int dersid = Convert.ToInt32(Request.QueryString["DERSID"]);
        EntityDers ent = new EntityDers();
        ent.DERSID = dersid;
        if (Page.IsPostBack==false)
        {      
            List<EntityDers> dersList = BLLDers.BLLDersDetay(ent);
            txtid.Text = dersid.ToString();
            txtid.Enabled = false;
            txtdersad.Text = dersList[0].DERSAD.ToString();
            txtminkont.Text = dersList[0].DERSMINKONT.ToString();
            txtmaxkont.Text = dersList[0].DERSMAXKONT.ToString();
        }
    }

    protected void btnguncelle_Click(object sender, EventArgs e)
    {
        int dersid = Convert.ToInt32(Request.QueryString["DERSID"]);
        EntityDers ent = new EntityDers();
        ent.DERSID= dersid;
        ent.DERSAD=txtdersad.Text;
        ent.DERSMINKONT = Convert.ToInt32(txtminkont.Text);
        ent.DERSMAXKONT = Convert.ToInt32(txtmaxkont.Text);
        BLLDers.BLLDersGuncelle(ent);
        Response.Redirect("Dersler.aspx");
    }
}