using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public class Filtreleme : Masa
    {
        public static  List<Masa> Filtrele(List<Masa> masalar, int bahisTutar, int masaTipi)
        {
            List<Masa> filtrelenenMasalar = new List<Masa>();

            foreach (Masa item in masalar)
            {
                if (item.Bahis_Tutar >= bahisTutar && (int)item.Masa_Tipi  == masaTipi)
                {
                    filtrelenenMasalar.Add(item);
                }
            }    

            foreach(Masa item in filtrelenenMasalar)
            {
               MessageBox.Show (item.Masa_Tipi + " " + item.Bahis_Tutar + "$");   
            }

            return filtrelenenMasalar;
        }

     

    }
}