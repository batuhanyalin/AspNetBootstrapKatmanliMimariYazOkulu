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

public partial class OgrenciListe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            //Öğrenci Listesi
            List<EntityOgrenci> ogrlist = BLLOgrenci.BLLOgrListele();
            Repeater1.DataSource = ogrlist;
            Repeater1.DataBind();   
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.OGRAD = txtad.Text;
        ent.OGRSOYAD = txtsoyad.Text;
        ent.OGRNO = txtogrno.Text;
        ent.OGRFOTO = FileUpload1.FileName;
        ent.OGRSIFRE = txtsifre.Text;
        BLLOgrenci.OgrenciEkleBLL(ent);
    }
}