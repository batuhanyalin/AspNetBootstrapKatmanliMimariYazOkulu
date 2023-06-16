using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data;

public partial class OgretmenGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int ogrtid = Convert.ToInt32(Request.QueryString["OGRTID"]);
        EntityOgretmen ent = new EntityOgretmen();
        ent.OGRTID = ogrtid;
        if (Page.IsPostBack==false)
        {         
            List<EntityOgretmen> ogrtList = BLLOgretmen.BLLOgretmenDetay(ent);
            txtadsoyad.Text = ogrtList[0].OGRTADSOYAD.ToString();
            txtid.Text = ogrtList[0].OGRTID.ToString();
            txtid.Enabled = false;

            DropDrownList1.DataTextField = "DERSAD";
            DropDrownList1.DataValueField = "DERSID";
            DropDrownList1.DataSource = BLLDers.BLLDersListe();
            DropDrownList1.DataBind();
         
        }    
    }

    protected void btnguncelle_Click(object sender, EventArgs e)
    {
        int ogrtid = Convert.ToInt32(Request.QueryString["OGRTID"]);
        EntityOgretmen ent = new EntityOgretmen();
        ent.OGRTID = ogrtid;
        ent.OGRTADSOYAD = txtadsoyad.Text;
        ent.OGRTBRANS = Convert.ToInt32(DropDrownList1.SelectedValue);
        BLLOgretmen.BLLOgretmenGuncelle(ent);
        Response.Redirect("Ogretmenler.aspx");
    }
}