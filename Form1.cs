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
            
            Form2 Igra = new Form2();
            Igra.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            File.WriteAllText(@"bodovi.txt", "");
            StreamWriter sw = new StreamWriter("bodovi.txt", true);
            sw.WriteLine("1");
            sw.Close();
            Form2 Igra = new Form2();
            Igra.ShowDialog();
            this.Close();

        }
    }
}