using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

public partial class DersKayit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            //Ogrenci DropdownList
            List<EntityOgrenci> ogrlist = BLLDers.BLLDersBasvuruOgrListele();
            DropDownList1.DataTextField = "OGRAD";
            DropDownList1.DataValueField = "OGRID";
            DropDownList1.DataSource = ogrlist;
            DropDownList1.DataBind();
            //Ders DropdownList
            List<EntityDers> derslist = BLLDers.BLLDersListe();
            DropDownList2.DataTextField = "DERSAD";
            DropDownList2.DataValueField = "DERSID";
            DropDownList2.DataSource = derslist;
            DropDownList2.DataBind();

            //Başvuru Listesi
            List<EntityBasvuru> basvuruList = BLLDers.BLLDersBasvuruListele();
            Repeater1.DataSource = basvuruList;
            Repeater1.DataBind();
        }

    }

    protected void btnkayit_Click(object sender, EventArgs e)
    {
        EntityOgrenci ogr = new EntityOgrenci();
        EntityDers ders = new EntityDers();
        ogr.OGRID = Convert.ToInt32(DropDownList1.SelectedValue);
        ders.DERSID = Convert.ToInt32(DropDownList2.SelectedValue);
        BLLDers.BLLDersBasvuruEkle(ogr.OGRID, ders.DERSID);
        Response.Redirect("DersKayit.aspx");
    }
}