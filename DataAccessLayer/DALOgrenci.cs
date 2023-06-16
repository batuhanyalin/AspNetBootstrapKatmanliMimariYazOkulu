using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using System.Net;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLOGRENCI (OGRAD,OGRSOYAD,OGRNO,OGRFOTO,OGRSIFRE) VALUES (@P1,@P2,@P3,@P4,@P5) ", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1", parametre.OGRAD);
            cmd.Parameters.AddWithValue("@P2", parametre.OGRSOYAD);
            cmd.Parameters.AddWithValue("@P3", parametre.OGRNO);
            cmd.Parameters.AddWithValue("@P4", parametre.OGRFOTO);
            cmd.Parameters.AddWithValue("@P5", parametre.OGRSIFRE);
           return cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static bool OgrenciGuncelle(EntityOgrenci p)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBLOGRENCI SET OGRAD=@P1,OGRSOYAD=@P2,OGRNO=@P3,OGRFOTO=@P4,OGRSIFRE=@P5,OGRBAKIYE=@P6 WHERE OGRID=@P0",Baglanti.bgl);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P0",p.OGRID);
            cmd.Parameters.AddWithValue("@P1", p.OGRAD);
            cmd.Parameters.AddWithValue("@P2", p.OGRSOYAD);
            cmd.Parameters.AddWithValue("@P3", p.OGRNO);
            cmd.Parameters.AddWithValue("@P4", p.OGRFOTO);
            cmd.Parameters.AddWithValue("@P5", p.OGRSIFRE);
            cmd.Parameters.AddWithValue("@P6", p.OGRBAKIYE);
            return cmd.ExecuteNonQuery()>0;
        }
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> list =new List<EntityOgrenci>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLOGRENCI WHERE OGRID=@P1", Baglanti.bgl);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1",id);
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OGRAD = dr["OGRAD"].ToString();
                ent.OGRSOYAD = dr["OGRSOYAD"].ToString();
                ent.OGRNO = dr["OGRNO"].ToString();
                ent.OGRFOTO = dr["OGRFOTO"].ToString();
                ent.OGRSIFRE = dr["OGRSIFRE"].ToString();
                ent.OGRBAKIYE = Convert.ToDouble(dr["OGRBAKIYE"]);
                list.Add(ent);
            }
            dr.Close();
            return list;
        }
        public static List<EntityOgrenci> OgrenciListele()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLOGRENCI",Baglanti.bgl);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OGRID = Convert.ToInt32(dr["OGRID"].ToString());
                ent.OGRAD = dr["OGRAD"].ToString();
                ent.OGRSOYAD = dr["OGRSOYAD"].ToString();
                ent.OGRNO = dr["OGRNO"].ToString();
                ent.OGRSIFRE = dr["OGRSIFRE"].ToString();
                ent.OGRFOTO = dr["OGRFOTO"].ToString();
                ent.OGRBAKIYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(EntityOgrenci p)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TBLOGRENCI WHERE OGRID=@P1",Baglanti.bgl);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@P1",p);
            return cmd.ExecuteNonQuery()>0;
            cmd.Connection.Close();
        }
        
    } 
}
