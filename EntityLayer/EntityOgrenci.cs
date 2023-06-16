using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private int id;
        private string ad;
        private string soyad;
        private string ogrno;
        private string fotograf;
        private string sifre;
        private double bakiye;

        public int OGRID { get => id; set => id = value; }
        public string OGRAD { get => ad; set => ad = value; }
        public string OGRSOYAD { get => soyad; set => soyad = value.ToUpper(); }
        public string OGRNO { get => ogrno; set => ogrno = value; }
        public string OGRFOTO { get => fotograf; set => fotograf = value; }
        public string OGRSIFRE { get => sifre; set => sifre = value; }
        public double OGRBAKIYE { get => bakiye; set => bakiye = value; }

    }
}
