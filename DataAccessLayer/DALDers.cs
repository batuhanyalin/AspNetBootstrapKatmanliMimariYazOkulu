using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListe()
        {
            List<EntityDers> ders = new List<EntityDers>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLDERS", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DERSID = Convert.ToInt32(dr["DERSID"]);
                ent.DERSAD = dr["DERSAD"].ToString();
                ent.DERSMINKONT = Convert.ToInt32(dr["DERSMINKONT"]);
                ent.DERSMAXKONT = Convert.ToInt32(dr["DERSMAXKONT"]);
                ders.Add(ent);
            }
            cmd.Connection.Close();
            return ders;
        }

        public static bool DersSil(EntityDers p)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TBLDERS WHERE DERSID=@P1", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1", p.DERSID);
            return cmd.ExecuteNonQuery() > 0;
            cmd.Connection.Close();
        }
        public static int DersEkle(EntityDers ent)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLDERS (DERSAD,DERSMINKONT,DERSMAXKONT) VALUES (@P1,@P2,@P3)", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1", ent.DERSAD);
            cmd.Parameters.AddWithValue("@P2", ent.DERSMINKONT);
            cmd.Parameters.AddWithValue("@P3", ent.DERSMAXKONT);
            return cmd.ExecuteNonQuery();
        }

        //Ders Detay

        public static List<EntityDers> DersDetay(EntityDers p)
        {
            List<EntityDers> dersList=new List<EntityDers>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLDERS WHERE DERSID=@P1",Baglanti.bgl);
            cmd.Parameters.AddWithValue("@P1",p.DERSID);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                p.DERSAD = dr["DERSAD"].ToString();
                p.DERSMINKONT = Convert.ToInt32(dr["DERSMINKONT"]);
                p.DERSMAXKONT = Convert.ToInt32(dr["DERSMAXKONT"]);
                dersList.Add(p);
            }
            dr.Close();
            return dersList;
        }

        //Güncelleme butonu
        public static bool DersGuncelle(EntityDers p)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBLDERS SET DERSAD=@P1,DERSMINKONT=@P2,DERSMAXKONT=@P3 WHERE DERSID=@P0",Baglanti.bgl);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P0",p.DERSID);
            cmd.Parameters.AddWithValue("@P1", p.DERSAD);
            cmd.Parameters.AddWithValue("@P2", p.DERSMINKONT);
            cmd.Parameters.AddWithValue("@P3", p.DERSMAXKONT);
           return cmd.ExecuteNonQuery() > 0;
        }




        //DERS BAŞVURU EK KATMANI **********************

        //Ekleme
        public static bool DersBasvuruEkle(int o, int d)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLBASVURU (OGRENCIID,DERSID) VALUES (@P1,@P2)", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1", o);
            cmd.Parameters.AddWithValue("@P2", d);
            return cmd.ExecuteNonQuery() > 0;
        }
        //OgrenciDropdownlist
        public static List<EntityOgrenci> DersBasvuruOgrenciDropdownlist()
        {
            List<EntityOgrenci> OgrenciList = new List<EntityOgrenci>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLOGRENCI", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OGRID = Convert.ToInt32(dr["OGRID"]);
                ent.OGRAD = dr["OGRAD"].ToString();
                ent.OGRSOYAD = dr["OGRSOYAD"].ToString();
                OgrenciList.Add(ent);
            }
            cmd.Connection.Close();
            return OgrenciList;
        }
        public static List<EntityBasvuru> DersBasvuruListele()
        {
            List<EntityBasvuru> basvuruList=new List<EntityBasvuru>();
            SqlCommand cmd = new SqlCommand("EXECUTE DERSBASVURULISTELE",Baglanti.bgl);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityBasvuru p = new EntityBasvuru();
                p.BASVURUID = Convert.ToInt32(dr["BASVURUID"]);
                p.OGRENCIAD = dr["OGRENCIADSOYAD"].ToString();
                p.DERSAD = dr["DERSAD"].ToString();
                basvuruList.Add(p);
            }
            cmd.Connection.Close();
            return basvuruList;
        }
    }
}
