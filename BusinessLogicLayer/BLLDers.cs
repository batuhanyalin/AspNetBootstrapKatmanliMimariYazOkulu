using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BLLDersListe()
        {
            return DALDers.DersListe();
        }
        public static int BLLDersEkle(EntityDers p)
        {
            if (p.DERSAD != null && p.DERSMINKONT != null && p.DERSMAXKONT != null)
            {
                return DALDers.DersEkle(p);
            }
            return -1;
        }
        public static bool BLLDersSil(EntityDers p)
        {
            if (p != null)
            {
                return DALDers.DersSil(p);
            }
            return false;
        }
        //Ders Detay
        public static List<EntityDers> BLLDersDetay(EntityDers p)
        {
            return DALDers.DersDetay(p);
        }
        //Güncelleme

        public static bool BLLDersGuncelle(EntityDers p)
        {
            if (p.DERSAD != null && p.DERSMINKONT != 0 && p.DERSMAXKONT != 0)
            {
                return DALDers.DersGuncelle(p);
            }
            return false;
        }




        //DERS BAŞVURU KATMANI *************
        public static bool BLLDersBasvuruEkle(int o, int d)
        {
            if (o > 0 && d > 0)
            {
                return DALDers.DersBasvuruEkle(o, d);
            }
            return false;
        }

        //OgrenciDropdownList
        public static List<EntityOgrenci> BLLDersBasvuruOgrListele()
        {
            return DALDers.DersBasvuruOgrenciDropdownlist();
        }

        //Ders Başvuruları Listeleme
        public static List<EntityBasvuru> BLLDersBasvuruListele()
        {
            return DALDers.DersBasvuruListele();
        }
    }
}
