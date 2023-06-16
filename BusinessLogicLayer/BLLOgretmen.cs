using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLOgretmen
    {
        public static bool BLLOgretmenEkle(EntityOgretmen ogrtEkle)
        {
            if (ogrtEkle.OGRTADSOYAD != null && ogrtEkle.OGRTBRANS != 0)
            {
                return DALOgretmen.OgretmenEkle(ogrtEkle);
            }
            return false;
        }
        public static bool BLLOgretmenSil(EntityOgretmen ogrtSil)
        {
            if (ogrtSil!=null)
            {
                return DALOgretmen.OgretmenSil(ogrtSil);
            }
            return false;
        }
        public static List<EntityOgretmen> BBLOgretmenListele()
        {
        return DALOgretmen.OgretmenListele();
        }
        public static List<EntityDers> BLLDersListele()
        {
            return DALDers.DersListe();
        }

        //Detay Sorgusu
        public static List<EntityOgretmen> BLLOgretmenDetay(EntityOgretmen p)
        {
            return DALOgretmen.OgretmenDetay(p);
        }
        //Güncelleme Butonu
        public static bool BLLOgretmenGuncelle(EntityOgretmen p)
        {
            if (p.OGRTADSOYAD!=null&& p.OGRTBRANS>0)
            {
                return DALOgretmen.OgretmenGuncelle(p);
            }
            return false;
        }
    }
}
