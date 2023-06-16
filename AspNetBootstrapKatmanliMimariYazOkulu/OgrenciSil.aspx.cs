using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

public partial class OgrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {      
        int ogrid = Convert.ToInt32(Request.QueryString["OGRID"]);
        EntityOgrenci ent=new EntityOgrenci();
        ent.OGRID= ogrid;
        BLLOgrenci.BLLOgrenciSil(ent);
        Response.Redirect("Ogrenciler.aspx");
        
    }
}