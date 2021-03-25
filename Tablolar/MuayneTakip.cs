using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneTakipSon.Tablolar
{
    public class MuayneTakip
    {
        public int Id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string yas { get; set; }
        public string doktorAd { get; set; }
        public string poliklinik { get; set; }
        public string tansiyon { get; set; }
        public string nabiz { get; set; }
        public string satursayon { get; set; }
        public bool ameliyat { get; set; }
        public string kan_grubu { get; set; }
        public string ilac { get; set; }
        public string yemekDurumu { get; set; }
    }
}
