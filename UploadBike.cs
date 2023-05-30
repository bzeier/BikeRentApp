using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRentApp
{
    public partial class UploadBike : Form
    {
        public UploadBike()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form_mainmenu.Show();
            Program.form_upload.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                if(numericUpDown1.Value > 0)
                {
                    Manager.AddNewBikeToCatalgue(new Models.Bike(textBox1.Text, textBox2.Text, Manager.CurrentUser, (float)numericUpDown1.Value, "bike.png"));

                    Program.form_mainmenu.Show();
                    Program.form_upload.Hide();
                }
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
