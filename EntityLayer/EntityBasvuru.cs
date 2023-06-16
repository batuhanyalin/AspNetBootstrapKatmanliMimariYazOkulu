using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuru
    {
        private int basvuruid;
        private int ogrenciid;
        private int dersid;
        private string ogrenciad;
        private string dersad;

        public int BASVURUID { get => basvuruid; set => basvuruid = value; }
        public int OGRENCIID { get => ogrenciid; set => ogrenciid = value; }
        public int DERSID { get => dersid; set => dersid = value; }
        public string OGRENCIAD { get => ogrenciad; set => ogrenciad = value; }
        public string DERSAD { get => dersad; set => dersad = value; }
    }
}