using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Değişkenler
    {

        public Masa_tipi Masa_Tipi { get; set; }
        public int Bahis_Tutar { get; set; }

        [Flags]
        public enum Masa_tipi
        {
            None,
            Hizli = 1,
            Teketek=2,
            Rovans=4
        };
    }
}
