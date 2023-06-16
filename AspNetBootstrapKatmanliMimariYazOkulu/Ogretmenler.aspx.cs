using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data.SqlClient;
using System.Data;

public partial class OgretmenListele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack==false)
        {
            List<EntityOgretmen> ogretmenlistele = BLLOgretmen.BBLOgretmenListele();
            Repeater1.DataSource = ogretmenlistele;
            Repeater1.DataBind();

            DropDownList1.DataTextField = "DERSAD";
            DropDownList1.DataValueField = "DERSID";
            DropDownList1.DataSource = BLLDers.BLLDersListe();
            DropDownList1.DataBind();
        }
           
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgretmen ent = new EntityOgretmen();
        ent.OGRTADSOYAD = txtadsoyad.Text;
        ent.OGRTBRANS = Convert.ToInt32(DropDownList1.SelectedValue);
        BLLOgretmen.BLLOgretmenEkle(ent);
        Response.Redirect("Ogretmenler.aspx");
    }
}