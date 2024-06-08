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
    public partial class Form3 : Form
    {
        List<string> stringList = new List<string>();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            }

        }
    }
}
