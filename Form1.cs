namespace BikeRentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form_catalogue.Show();
            Program.form_mainmenu.Hide();
        }
    }
}