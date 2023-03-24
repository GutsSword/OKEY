using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp6.Değişkenler;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        bool hizli, teketek, rovans;
        int value;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            value = 100 * trackBar1.Value;
            lblpara.Text = value.ToString() + "$";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            trackBar1.Value = 2;
            int defaulttvalue = 2;
            lblpara.Text = (100 * defaulttvalue).ToString() + "$";
        }
        int t1 = 0;
        Color renk = Color.FromArgb(54, 51, 54);
        private void button1_Click(object sender, EventArgs e)
        {
            t2 = 0;
            if (t1 == 0)
            {
                hizli = true;
                button1.BackColor = Color.Gray;
                button5.BackColor = renk;
            }
            t1++;

            if (t1 == 2)
            {
                hizli = false;
                button1.BackColor = renk;
                t1 = 0;
            }
        }
        int t2 = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            t1 = 0;
            if (t2 == 0)
            {
                hizli = false;
                button1.BackColor = renk;
                button5.BackColor = Color.Gray;
            }
            t2++;
            if (t2 == 2)
            {
                hizli = false;
                button5.BackColor = renk;
                t2 = 0;
            }
        }
        int t3 = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            t4 = 0;
            if (t3 == 0)
            {
                teketek = true;
                button8.BackColor = Color.Gray;
                button7.BackColor = renk;
            }
            t3++;
            if (t3 == 2)
            {
                teketek = false;
                button8.BackColor = renk;
                t3 = 0;
            }
        }

        int t4 = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            t3 = 0;
            if (t4 == 0)
            {
                teketek = false;
                button8.BackColor = renk;
                button7.BackColor = Color.Gray;
            }
            t4++;
            if (t4 == 2)
            {
                teketek = false;
                button7.BackColor = renk;
                t4 = 0;
            }
        }



        int t5 = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            t6 = 0;
            if (t5 == 0)
            {
                rovans = true;
                button9.BackColor = renk;
                button10.BackColor = Color.Gray;
            }
            t5++;
            if (t5 == 2)
            {
                rovans = false;
                button10.BackColor = renk;
                t5 = 0;
            }
        }
        int t6 = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            t5 = 0;
            if (t6 == 0)
            {
                rovans = false;
                button9.BackColor = Color.Gray;
                button10.BackColor = renk;
            }
            t6++;
            if (t6 == 2)
            {
                rovans = false;
                button9.BackColor = renk;
                t6 = 0;
            }
        }
   
        private void button11_Click(object sender, EventArgs e)
        {

            int hh = Convert.ToInt32(hizli); 
            int tt = Convert.ToInt32(teketek);
            int rr = Convert.ToInt32(rovans);

            int top = (int)Masa_tipi.Hizli * hh + (int)Masa_tipi.Teketek * tt + (int)Masa_tipi.Rovans * rr;

            Filtreleme.Filtrele(masalar, value, top);
        }

            
        //Masa Listesi
        List<Masa> masalar = new List<Masa>
        {
            new Masa { Bahis_Tutar = 500, Masa_Tipi = Masa_tipi.Hizli },
            new Masa { Bahis_Tutar = 500, Masa_Tipi = Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 500, Masa_Tipi = Masa_tipi.Teketek },
            new Masa { Bahis_Tutar = 500, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Teketek },
            new Masa { Bahis_Tutar = 500, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 500, Masa_Tipi = Masa_tipi.Teketek | Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 500, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Teketek | Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 1500, Masa_Tipi = Masa_tipi.Hizli },
            new Masa { Bahis_Tutar = 1500, Masa_Tipi = Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 1500, Masa_Tipi = Masa_tipi.Teketek },
            new Masa { Bahis_Tutar = 1500, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Teketek },
            new Masa { Bahis_Tutar = 1500, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 1500, Masa_Tipi = Masa_tipi.Teketek | Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 1500, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Teketek | Masa_tipi.Rovans },
             new Masa { Bahis_Tutar = 3500, Masa_Tipi = Masa_tipi.Hizli },
            new Masa { Bahis_Tutar = 3500, Masa_Tipi = Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 3500, Masa_Tipi = Masa_tipi.Teketek },
            new Masa { Bahis_Tutar = 3500, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Teketek },
            new Masa { Bahis_Tutar = 3500, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 3500, Masa_Tipi = Masa_tipi.Teketek | Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 3500, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Teketek | Masa_tipi.Rovans },
             new Masa { Bahis_Tutar = 5000, Masa_Tipi = Masa_tipi.Hizli },
            new Masa { Bahis_Tutar = 5000, Masa_Tipi = Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 5000, Masa_Tipi = Masa_tipi.Teketek },
            new Masa { Bahis_Tutar = 5000, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Teketek },
            new Masa { Bahis_Tutar = 5000, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 5000, Masa_Tipi = Masa_tipi.Teketek | Masa_tipi.Rovans },
            new Masa { Bahis_Tutar = 5000, Masa_Tipi = Masa_tipi.Hizli | Masa_tipi.Teketek | Masa_tipi.Rovans },
        };

    }
}