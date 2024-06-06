using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keksoklikernovo
{
    public partial class Form2 : Form
    {
        int nivo;
        int pekar;
        int bodovi;

        public Form2()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("nivo.txt", true);
            string tpnivo = sr.ReadLine();
            nivo = int.Parse(tpnivo);
            StreamReader sr2 = new StreamReader("bodovi.txt", true);
            string tpbodovi = sr2.ReadLine();
            bodovi = int.Parse(tpbodovi);
            StreamReader sr3 = new StreamReader("pekar.txt", true);
            string tppekar = sr3.ReadLine();
            pekar = int.Parse(tppekar);
            if (nivo == 1)
            {
                keks.Load("KEKSOKLIKERTEMPLATE.png");

            }
            if (nivo == 2)
            {

            }
            if (nivo == 3)
            {

            }
            if (nivo == 4)
            {

            }
            if (nivo == 5)
            {

            }



            if (pekar == 1)
            {
                pbpekar.Load("pekar1.png");

            }
            if (pekar == 2)
            {

            }
            if (pekar == 3)
            {

            }
            if (pekar == 4)
            {

            }
            if (pekar == 5)
            {

            }
        }


        int i = 0;
        private void keks_Click_1(object sender, EventArgs e)
        {

            if (nivo == 1)
            {
                bodovi++;
                labelbodovi.Text = bodovi.ToString();
                if (i > 5)
                {
                    i = 0;
                }
                if (i < 1)
                {
                    keks.Load("KEKSOKLIKERTEMPLATE.png");
                }
                else if (i < 2)
                {
                    keks.Load("KEKSOKLIKERTEMPLATEugriz1.png");

                }
                else if (i < 3)
                {
                    keks.Load("KEKSOKLIKERTEMPLATEugriz2.png");
                }
                else if (i < 4)
                {
                    keks.Load("KEKSOKLIKERTEMPLATEugriz3.png");
                }
                else if (i < 5)
                {
                    keks.Load("KEKSOKLIKERTEMPLATEugriz4.png");
                }
                else if (i < 6)
                {
                    keks.Load("KEKSOKLIKERTEMPLATEugriz5.png");
                }
                i++;


            }
            if (nivo == 2)
            {
                bodovi = bodovi + 5;
                labelbodovi.Text = bodovi.ToString();
            }
            if (nivo == 3)
            {
                bodovi = bodovi + 10;
                labelbodovi.Text = bodovi.ToString();
            }
            if (nivo == 4)
            {
                bodovi = bodovi + 15;
                labelbodovi.Text = bodovi.ToString();
            }
            if (nivo == 5)
            {
                bodovi = bodovi + 20;
                labelbodovi.Text = bodovi.ToString();
            }
        }

        private void buttontrgovina_Click(object sender, EventArgs e)
        {
            Form3 Trgovina = new Form3();
            Trgovina.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pekar == 1)
            {
                bodovi++;
                labelbodovi.Text = bodovi.ToString();
            }
            if (pekar == 2)
            {

            }
            if (pekar == 3)
            {

            }
            if (pekar == 4)
            {

            }
            if (pekar == 5)
            {

            }
        }
    }
}
