using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace keksoklikernovo
{
    public partial class Form4 : Form
    {
        int vrijeme = 0;
        int rezultat;
        int zlato;
        public Form4()
        {

            InitializeComponent();
            Random r = new Random();
            int rInt = r.Next(0, 100);
            int rInt2 = r.Next(0, 20);
            label2.Text = rInt.ToString();
            label4.Text = rInt2.ToString();
            rezultat = rInt2 * rInt;
            StreamReader sr4 = new StreamReader("zlato.txt", true);
            string tpzlato = sr4.ReadLine();
            zlato = int.Parse(tpzlato);
            sr4.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vrijeme++;
            int vrijemeod = 30 - vrijeme;
            label8.Text = vrijemeod.ToString();
            if (vrijeme == 30)
            {
                this.Close();


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rez = rezultat.ToString();
            if (textBox1.Text == rez)
            {
                zlato++;
                MessageBox.Show("Sef otkljucan!");
                File.WriteAllText(@"zlato.txt", "");
                StreamWriter sw1 = new StreamWriter("zlato.txt", true);
                sw1.WriteLine(zlato);
                sw1.Close();
                this.Close();

            }
        }
    }
}
