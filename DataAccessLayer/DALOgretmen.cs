using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALOgretmen
    {
        public static bool OgretmenEkle(EntityOgretmen p)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLOGRETMEN (OGRTADSOYAD,OGRTBRANS) VALUES (@P1,@P2)", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1", p.OGRTADSOYAD);
            cmd.Parameters.AddWithValue("@P2", p.OGRTBRANS);
            return cmd.ExecuteNonQuery()>0;
        }
        public static bool OgretmenSil(EntityOgretmen p)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TBLOGRETMEN WHERE OGRTID=@P1", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1", p.OGRTID);
            return cmd.ExecuteNonQuery() > 0;
           
        }

        public static List<EntityOgretmen> OgretmenListele()
        {
            List<EntityOgretmen> ogrtlist = new List<EntityOgretmen>();
            SqlCommand cmd = new SqlCommand("SELECT OGRTID,OGRTADSOYAD,OGRTBRANS,DERSAD FROM TBLOGRETMEN INNER JOIN TBLDERS ON TBLDERS.DERSID=TBLOGRETMEN.OGRTBRANS", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ent = new EntityOgretmen();
                ent.OGRTID = Convert.ToInt32(dr["OGRTID"]);
                ent.OGRTADSOYAD = dr["OGRTADSOYAD"].ToString();
                ent.OGRTBRANS = Convert.ToInt32(dr["OGRTBRANS"]);
                ent.BRANSAD = dr["DERSAD"].ToString();
                ogrtlist.Add(ent);
            }
            cmd.Connection.Close();
            return ogrtlist;
        }
        //Detay Sorgusu
        public static List<EntityOgretmen> OgretmenDetay(EntityOgretmen p)
        {
            List<EntityOgretmen> ogrtList=new List<EntityOgretmen>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLOGRETMEN WHERE OGRTID=@P1", Baglanti.bgl);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1",p.OGRTID);
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                p.OGRTADSOYAD = dr["OGRTADSOYAD"].ToString();
                p.OGRTBRANS = Convert.ToInt32(dr["OGRTBRANS"]);
                ogrtList.Add(p);
            }
            cmd.Connection.Close();
            return ogrtList;
           
        }
      //Güncelleme işlemi
      public static bool OgretmenGuncelle(EntityOgretmen p)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBLOGRETMEN SET OGRTADSOYAD=@P1,OGRTBRANS=@P2 WHERE OGRTID=@P0",Baglanti.bgl);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P0",p.OGRTID);
            cmd.Parameters.AddWithValue("@P1", p.OGRTADSOYAD);
            cmd.Parameters.AddWithValue("@P2", p.OGRTBRANS);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
