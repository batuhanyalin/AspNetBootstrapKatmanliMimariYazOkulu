using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int ogrid = Convert.ToInt32(Request.QueryString["OGRID"]);
        txtid.Text = ogrid.ToString();
        txtid.Enabled = false;
        if (Page.IsPostBack==false)
        {

                List<EntityOgrenci> ogrlist = BLLOgrenci.BLLOgrenciDetay(ogrid);
                txtad.Text = ogrlist[0].OGRAD.ToString();
                txtsoyad.Text = ogrlist[0].OGRSOYAD.ToString();
                txtogrno.Text = ogrlist[0].OGRNO.ToString();
                txtsifre.Text = ogrlist[0].OGRSIFRE.ToString();
                txtbakiye.Text = ogrlist[0].OGRBAKIYE.ToString();
                Image1.ImageUrl = ogrlist[0].OGRFOTO.ToString();
                lbladsoyad.Text = ogrlist[0].OGRAD + " " + ogrlist[0].OGRSOYAD;         
        }
    }

    protected void btnguncelle_Click(object sender, EventArgs e)
    {
        FileUpload1.SaveAs(Server.MapPath("/Fotograflar/Ogrenciler/"+FileUpload1.FileName));

        int ogrid = Convert.ToInt32(Request.QueryString["OGRID"]);
        EntityOgrenci ogr = new EntityOgrenci();
        ogr.OGRID = ogrid;
        ogr.OGRAD = txtad.Text;
        ogr.OGRSOYAD = txtsoyad.Text;
        ogr.OGRNO = txtogrno.Text;
        ogr.OGRSIFRE= txtsifre.Text;
        ogr.OGRBAKIYE = Convert.ToDouble(txtbakiye.Text);
        ogr.OGRFOTO = "~/Fotograflar/Ogrenciler/"+FileUpload1.FileName;
        BLLOgrenci.BLLOgrenciGuncelle(ogr);
        Response.Redirect("Ogrenciler.aspx");
    }
}