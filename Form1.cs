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
    }
}