using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;
using System.Data.SqlClient;

public partial class Dersler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack==false)
        {
            List<EntityDers> ders = BLLDers.BLLDersListe();
            Repeater1.DataSource = ders;
            Repeater1.DataBind();
        }
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityDers ent = new EntityDers();
        ent.DERSAD = txtdersad.Text;
        ent.DERSMINKONT = Convert.ToInt32(txtdersminkont.Text);
        ent.DERSMAXKONT = Convert.ToInt32(txtdersmaxkont.Text);
        BLLDers.BLLDersEkle(ent);
        Response.Redirect("Dersler.aspx");
    }
}