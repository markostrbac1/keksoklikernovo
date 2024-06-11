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
            sr.Close();
            StreamReader sr2 = new StreamReader("bodovi.txt", true);
            string tpbodovi = sr2.ReadLine();
            bodovi = int.Parse(tpbodovi);
            sr2.Close();
            StreamReader sr3 = new StreamReader("pekar.txt", true);
            string tppekar = sr3.ReadLine();
            pekar = int.Parse(tppekar);
            sr3.Close();
            labelbodovi.Text = bodovi.ToString();
            if (nivo == 1)
            {
                keks.Load("KEKSOKLIKERTEMPLATE.png");

            }
            if (nivo == 2)
            {
                keks.Load("keksjaffaE.png");
            }
            if (nivo == 3)
            {
                keks.Load("ludikeks.png");
            }
            if (nivo == 4)
            {
                keks.Load("opasnikeks.png");
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
                pbpekar.Load("pekar2.png");
            }
            if (pekar == 3)
            {
                pbpekar.Load("pekar3.png");
            }
            if (pekar == 4)
            {
                pbpekar.Load("pekar4.png");
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
                if (i > 5)
                {
                    i = 0;
                }
                if (i < 1)
                {
                    keks.Load("keksjaffaE.png");
                }
                else if (i < 2)
                {
                    keks.Load("keksjaffaugriz1.png");

                }
                else if (i < 3)
                {
                    keks.Load("keksjaffaugriz2.png");
                }
                else if (i < 4)
                {
                    keks.Load("keksjaffaugriz3.png");
                }
                else if (i < 5)
                {
                    keks.Load("keksjaffaugriz4.png");
                }
                else if (i < 6)
                {
                    keks.Load("keksjaffaugriz5.png");
                }
                i++;
            }
            if (nivo == 3)
            {
                bodovi = bodovi + 10;
                labelbodovi.Text = bodovi.ToString();
                if (i > 5)
                {
                    i = 0;
                }
                if (i < 1)
                {
                    keks.Load("ludikeks.png");
                }
                else if (i < 2)
                {
                    keks.Load("ludikeksugriz1.png");

                }
                else if (i < 3)
                {
                    keks.Load("ludikeksugriz2.png");
                }
                else if (i < 4)
                {
                    keks.Load("ludikeksugriz3.png");
                }
                else if (i < 5)
                {
                    keks.Load("ludikeksugriz4.png");
                }
                else if (i < 6)
                {
                    keks.Load("ludikeksugriz5.png");
                }
                i++;
            }
            if (nivo == 4)
            {
                bodovi = bodovi + 15;
                labelbodovi.Text = bodovi.ToString();
                if (i > 5)
                {
                    i = 0;
                }
                if (i < 1)
                {
                    keks.Load("opasnikeks.png");
                }
                else if (i < 2)
                {
                    keks.Load("opasnikeksugriz1.png");

                }
                else if (i < 3)
                {
                    keks.Load("opasnikeksugriz2.png");
                }
                else if (i < 4)
                {
                    keks.Load("opasnikeksugriz3.png");
                }
                else if (i < 5)
                {
                    keks.Load("opasnikeksugriz4.png");
                }
                else if (i < 6)
                {
                    keks.Load("opasnikeksugriz5.png");
                }
                i++;
            }
            if (nivo == 5)
            {
                bodovi = bodovi + 20;
                labelbodovi.Text = bodovi.ToString();
            }
        }

        private void buttontrgovina_Click(object sender, EventArgs e)
        {
            this.Hide();
            File.WriteAllText(@"bodovi.txt", "");
            StreamWriter sw = new StreamWriter("bodovi.txt", true);
            sw.WriteLine(bodovi);
            sw.Close();
            Form3 Trgovina = new Form3();
            Trgovina.ShowDialog();
            this.Close();
            
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
                bodovi=bodovi+5;
                labelbodovi.Text = bodovi.ToString();
            }
            if (pekar == 3)
            {
                bodovi = bodovi + 15;
                labelbodovi.Text = bodovi.ToString();
            }
            if (pekar == 4)
            {
                bodovi = bodovi + 50;
                labelbodovi.Text = bodovi.ToString();
            }
            if (pekar == 5)
            {

            }
        }

        private void buttonSPREMI_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"bodovi.txt", "");
            StreamWriter sw = new StreamWriter("bodovi.txt", true);
            sw.WriteLine(bodovi);
            sw.Close();
        }
    }
}
