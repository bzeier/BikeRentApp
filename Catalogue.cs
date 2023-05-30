using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeRentApp.Models;

namespace BikeRentApp
{
    public partial class Catalogue : Form
    {

        public Catalogue()
        {
            InitializeComponent();
            Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListBox selected = (ListBox)sender;
            try {
                Bike currentBike = Manager.Catalogue.ElementAt(selected.SelectedIndex);
            label1.Text = currentBike.Name;
            label3.Text = currentBike.Description;
            label2.Text = currentBike.PricePerHour.ToString() + "$ / hr";

            string dir = Environment.CurrentDirectory + "/Resources/" + currentBike.ImageUrl;
            pictureBox1.ImageLocation = dir;

            if (currentBike.IsRentedOut)
            {
                button1.Text = "UNAVAILABLE";
                button1.Enabled = false;
            }
            else
            {
                button1.Text = "RENT";
                button1.Enabled = true;
            }

            } catch
            {

            }

        }

        private void Refresh()
        {
            string dir = Environment.CurrentDirectory + "/Resources/bike.png";
            pictureBox1.ImageLocation = dir;
            Console.WriteLine(dir);
            Console.WriteLine(dir);

            listBox1.Items.Clear();

            foreach (Bike bike in Manager.Catalogue)
            {
                listBox1.Items.Add(bike.Name);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form_catalogue.Hide();
            Program.form_mainmenu.Show();
        }
    }
}
