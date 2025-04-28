namespace PreLabLuisMorenoVD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text == "1234")
            {
                Form2 cambio = new Form2();
                cambio.Show();
                this.Hide();
            }
            else MessageBox.Show("Rellene los 2 campos correctamente");
        }
    }
}
