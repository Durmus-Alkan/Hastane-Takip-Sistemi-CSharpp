using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneTakipSon.Tablolar
{
    public interface ITedavi
    {
        int hastaId { get; set; }
        string ad { get; set; }
        string soyad { get; set; }
        string sikayet { get; set; }
        string teshis { get; set; }
        string tetkit { get; set; }
        string recete { get; set; }
}
}
