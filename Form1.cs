namespace keksoklikernovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Igra = new Form2();
            Igra.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            File.WriteAllText(@"bodovi.txt", "");
            StreamWriter sw = new StreamWriter("bodovi.txt", true);
            sw.WriteLine("1");
            sw.Close();
            File.WriteAllText(@"nivo.txt", "");
            StreamWriter sw1 = new StreamWriter("nivo.txt", true);
            sw1.WriteLine("1");
            sw1.Close();
            File.WriteAllText(@"pekar.txt", "");
            StreamWriter sw2 = new StreamWriter("pekar.txt", true);
            sw2.WriteLine("1");
            sw2.Close();
            File.WriteAllText(@"tvornica.txt", "");
            StreamWriter sw3 = new StreamWriter("tvornica.txt", true);
            sw3.WriteLine("1");
            sw3.Close();
            File.WriteAllText(@"zlato.txt", "");
            StreamWriter sw4 = new StreamWriter("zlato.txt", true);
            sw4.WriteLine("0");
            sw4.Close();
            Form2 Igra = new Form2();
            Igra.ShowDialog();
            this.Close();

        }
    }
}