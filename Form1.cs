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
            Program.form_catalogue.Refresh();
            Program.form_catalogue.Show();
            Program.form_mainmenu.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form_mainmenu.Hide();
            Program.form_upload.Show();
        }
    }
}