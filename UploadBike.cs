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
    }
}
