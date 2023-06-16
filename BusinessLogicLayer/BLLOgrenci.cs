using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.OGRAD != null && p.OGRSOYAD != null && p.OGRNO != null && p.OGRSIFRE != null && p.OGRFOTO != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BLLOgrenciDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }
        public static bool BLLOgrenciGuncelle(EntityOgrenci p)
        {
            if (p.OGRAD != null && p.OGRAD != "" && p.OGRSOYAD != null && p.OGRNO != null && p.OGRSIFRE != null && p.OGRBAKIYE.ToString() != null)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
        public static bool BLLOgrenciSil(EntityOgrenci p)
        {
            if (p != null)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> BLLOgrListele()
        {
            return DALOgrenci.OgrenciListele();
        }
    }
}
