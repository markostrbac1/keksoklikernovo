using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace keksoklikernovo
{
    public partial class Form3 : Form
    {
        int nivo;
        int pekar;
        int bodovi;
        string vrsta;
        int razina;
        int zlato;
        List<string> stringList = new List<string>();
        public Form3()
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
            StreamReader sr4 = new StreamReader("zlato.txt", true);
            string tpzlato = sr4.ReadLine();
            zlato = int.Parse(tpzlato);
            sr4.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cijena = label5.Text;
            string cijenaz = label7.Text;
            int minus = int.Parse(cijena);
            int minusz = int.Parse(cijenaz);
            if (minus > bodovi)
            {
                MessageBox.Show("Nemate dovoljno novca!");
            }
            else if (minusz > zlato)
            {
                MessageBox.Show("Nemate dovoljno zlata!");
            }
            else
            {

                if (vrsta == "keks")
                {
                    StreamReader sr = new StreamReader("nivo.txt", true);
                    string tnivo = sr.ReadLine();
                    int tstnivo = int.Parse(tnivo);
                    sr.Close();
                    if (tstnivo >= razina)
                    {
                        MessageBox.Show("Ova nadogradnja je vec kupljena!");
                    }
                    else
                    {
                        MessageBox.Show("Nadogradnja kupljena!");
                        bodovi = bodovi - minus;
                        File.WriteAllText(@"bodovi.txt", "");
                        StreamWriter sw = new StreamWriter("bodovi.txt", true);
                        sw.WriteLine(bodovi);
                        sw.Close();
                        File.WriteAllText(@"nivo.txt", "");
                        StreamWriter sw1 = new StreamWriter("nivo.txt", true);
                        sw1.WriteLine(razina);
                        sw1.Close();
                        zlato = zlato - minusz;
                        File.WriteAllText(@"zlato.txt", "");
                        StreamWriter sw2 = new StreamWriter("zlato.txt", true);
                        sw2.WriteLine(zlato);
                        sw2.Close();
                    }
                }
                else if (vrsta == "pekar")
                {
                    StreamReader sr = new StreamReader("pekar.txt", true);
                    string tnivo = sr.ReadLine();
                    int tstnivo = int.Parse(tnivo);
                    sr.Close();
                    if (tstnivo >= razina)
                    {
                        MessageBox.Show("Ova nadogradnja je vec kupljena!");
                    }
                    else
                    {
                        MessageBox.Show("Nadogradnja kupljena!");
                        bodovi = bodovi - minus;
                        File.WriteAllText(@"bodovi.txt", "");
                        StreamWriter sw = new StreamWriter("bodovi.txt", true);
                        sw.WriteLine(bodovi);
                        sw.Close();
                        File.WriteAllText(@"pekar.txt", "");
                        StreamWriter sw1 = new StreamWriter("pekar.txt", true);
                        sw1.WriteLine(razina);
                        sw1.Close();
                        zlato = zlato - minusz;
                        File.WriteAllText(@"zlato.txt", "");
                        StreamWriter sw2 = new StreamWriter("zlato.txt", true);
                        sw2.WriteLine(zlato);
                        sw2.Close();
                    }

                }
                else if (vrsta == "tvornica")
                {
                    StreamReader sr = new StreamReader("tvornica.txt", true);
                    string tnivo = sr.ReadLine();
                    int tstnivo = int.Parse(tnivo);
                    sr.Close();
                    if (tstnivo >= razina)
                    {
                        MessageBox.Show("Ova nadogradnja je vec kupljena!");
                    }
                    else
                    {
                        MessageBox.Show("Nadogradnja kupljena!");
                        bodovi = bodovi - minus;
                        File.WriteAllText(@"bodovi.txt", "");
                        StreamWriter sw = new StreamWriter("bodovi.txt", true);
                        sw.WriteLine(bodovi);
                        sw.Close();
                        File.WriteAllText(@"tvornica.txt", "");
                        StreamWriter sw1 = new StreamWriter("tvornica.txt", true);
                        sw1.WriteLine(razina);
                        sw1.Close();
                        zlato = zlato - minusz;
                        File.WriteAllText(@"zlato.txt", "");
                        StreamWriter sw2 = new StreamWriter("zlato.txt", true);
                        sw2.WriteLine(zlato);
                        sw2.Close();
                    }

                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Igra = new Form2();
            Igra.ShowDialog();
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("izbornik.txt");
            string linija = sr.ReadLine();

            while (linija != null)
            {
                stringList.Add(linija);
                linija = sr.ReadLine();
            }

            listBox3.DataSource = stringList;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem.ToString() == "keksi")
            {
                StreamReader sr = new StreamReader("keksi.txt");
                string line = sr.ReadLine();
                List<string> stringList1 = new List<string>();

                while (line != null)
                {
                    stringList1.Add(line);
                    line = sr.ReadLine();
                }

                listBox1.DataSource = stringList1;
            }

            if (listBox3.SelectedItem.ToString() == "pekari")
            {
                StreamReader sr = new StreamReader("pekari.txt");
                string line = sr.ReadLine();
                List<string> stringList1 = new List<string>();

                while (line != null)
                {
                    stringList1.Add(line);
                    line = sr.ReadLine();
                }

                listBox1.DataSource = stringList1;
                sr.Close();
            }
            if (listBox3.SelectedItem.ToString() == "tvornice")
            {
                StreamReader sr = new StreamReader("tvornice.txt");
                string line = sr.ReadLine();
                List<string> stringList1 = new List<string>();

                while (line != null)
                {
                    stringList1.Add(line);
                    line = sr.ReadLine();
                }

                listBox1.DataSource = stringList1;
                sr.Close();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "keks jaffa")
            {
                StreamReader sr = new StreamReader("jaffa.txt", true);
                string linija = sr.ReadLine();

                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    string cijena = lin[0];
                    string opis = lin[1];
                    string path = lin[2];
                    label5.Text = cijena;
                    richTextBox1.Text = opis;
                    linija = sr.ReadLine();
                    pictureBox1.Load(path);
                    vrsta = lin[3];
                    razina = int.Parse(lin[4]);
                    string zlato = lin[5];
                    label7.Text = zlato;
                }
                sr.Close();
            }
            if (listBox1.SelectedItem.ToString() == "ludi keks")
            {
                StreamReader sr = new StreamReader("ludi.txt", true);
                string linija = sr.ReadLine();

                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    string cijena = lin[0];
                    string opis = lin[1];
                    string path = lin[2];
                    label5.Text = cijena;
                    richTextBox1.Text = opis;
                    linija = sr.ReadLine();
                    pictureBox1.Load(path);
                    vrsta = lin[3];
                    razina = int.Parse(lin[4]);
                    string zlato = lin[5];
                    label7.Text = zlato;

                }
                sr.Close();
            }
            if (listBox1.SelectedItem.ToString() == "opasni keks")
            {
                StreamReader sr = new StreamReader("opasni.txt", true);
                string linija = sr.ReadLine();
                string cijena;
                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    cijena = lin[0];
                    string opis = lin[1];
                    string path = lin[2];
                    label5.Text = cijena;
                    richTextBox1.Text = opis;
                    linija = sr.ReadLine();
                    pictureBox1.Load(path);
                    vrsta = lin[3];
                    razina = int.Parse(lin[4]);
                    string zlato = lin[5];
                    label7.Text = zlato;

                }

                sr.Close();
            }
            if (listBox1.SelectedItem.ToString() == "iskusni pekar")
            {
                StreamReader sr = new StreamReader("iskusni.txt", true);
                string linija = sr.ReadLine();
                string cijena;
                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    cijena = lin[0];
                    string opis = lin[1];
                    string path = lin[2];
                    label5.Text = cijena;
                    richTextBox1.Text = opis;
                    linija = sr.ReadLine();
                    pictureBox1.Load(path);
                    vrsta = lin[3];
                    razina = int.Parse(lin[4]);
                    string zlato = lin[5];
                    label7.Text = zlato;

                }

                sr.Close();
            }
            if (listBox1.SelectedItem.ToString() == "pekar mestar")
            {
                StreamReader sr = new StreamReader("mestar.txt", true);
                string linija = sr.ReadLine();
                string cijena;
                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    cijena = lin[0];
                    string opis = lin[1];
                    string path = lin[2];
                    label5.Text = cijena;
                    richTextBox1.Text = opis;
                    linija = sr.ReadLine();
                    pictureBox1.Load(path);
                    vrsta = lin[3];
                    razina = int.Parse(lin[4]);
                    string zlato = lin[5];
                    label7.Text = zlato;

                }

                sr.Close();
            }
            if (listBox1.SelectedItem.ToString() == "terminator")
            {
                StreamReader sr = new StreamReader("optimizirani.txt", true);
                string linija = sr.ReadLine();
                string cijena;
                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    cijena = lin[0];
                    string opis = lin[1];
                    string path = lin[2];
                    label5.Text = cijena;
                    richTextBox1.Text = opis;
                    linija = sr.ReadLine();
                    pictureBox1.Load(path);
                    vrsta = lin[3];
                    razina = int.Parse(lin[4]);
                    string zlato = lin[5];
                    label7.Text = zlato;

                }

                sr.Close();
            }
            if (listBox1.SelectedItem.ToString() == "jednostavna tvornica")
            {
                StreamReader sr = new StreamReader("jednostavna.txt", true);
                string linija = sr.ReadLine();

                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    string cijena = lin[0];
                    string opis = lin[1];
                    string path = lin[2];
                    label5.Text = cijena;
                    richTextBox1.Text = opis;
                    linija = sr.ReadLine();
                    pictureBox1.Load(path);
                    vrsta = lin[3];
                    razina = int.Parse(lin[4]);
                    string zlato = lin[5];
                    label7.Text = zlato;
                }
                sr.Close();
            }
            if (listBox1.SelectedItem.ToString() == "teska industrija")
            {
                StreamReader sr = new StreamReader("teska.txt", true);
                string linija = sr.ReadLine();

                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    string cijena = lin[0];
                    string opis = lin[1];
                    string path = lin[2];
                    label5.Text = cijena;
                    richTextBox1.Text = opis;
                    linija = sr.ReadLine();
                    pictureBox1.Load(path);
                    vrsta = lin[3];
                    razina = int.Parse(lin[4]);
                    string zlato = lin[5];
                    label7.Text = zlato;
                }
                sr.Close();
            }
            if (listBox1.SelectedItem.ToString() == "monopol nad industrijom")
            {
                StreamReader sr = new StreamReader("monopol.txt", true);
                string linija = sr.ReadLine();

                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    string cijena = lin[0];
                    string opis = lin[1];
                    string path = lin[2];
                    label5.Text = cijena;
                    richTextBox1.Text = opis;
                    linija = sr.ReadLine();
                    pictureBox1.Load(path);
                    vrsta = lin[3];
                    razina = int.Parse(lin[4]);
                    string zlato = lin[5];
                    label7.Text = zlato;
                }
                sr.Close();
            }


        }
    }
}
