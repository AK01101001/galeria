using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace galeria
{
    public class zdjecie
    {
        public string source { get; set; } = "";

        public int lWyswietlen { get; set; }
        public int lPolubien { get; set; }
        static int licznik;

        public zdjecie(int lWyswietlen, int lPolubien)
        {
            licznik++;
            this.source= "zdj/zdj"+licznik+".png";
            this.lWyswietlen = lWyswietlen;
            this.lPolubien = lPolubien;
        }
    }
}
