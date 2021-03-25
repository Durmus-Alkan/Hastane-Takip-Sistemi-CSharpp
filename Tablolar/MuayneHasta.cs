using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneTakipSon.Tablolar
{
    public class MuayneHasta : ITedavi
    {
        public int hastaId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sikayet { get; set; }
        public string teshis { get; set; }
        public string tetkit { get; set; }
        public string recete { get; set; }
    }
}
