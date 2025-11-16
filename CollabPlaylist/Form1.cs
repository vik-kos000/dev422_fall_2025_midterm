using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlbumInventoryClient;
using MusicRentalGUI;


namespace CollabPlaylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlbumInventoryMicroservice_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();

            mainForm.FormClosed += (s, args) => this.Show();
            mainForm.Show();

        }

        private void button_rentAnAlbum_Click(object sender, EventArgs e)
        {
            RentalForm rentalForm = new RentalForm();
            this.Hide();

            rentalForm.FormClosed += (s, args) => this.Show(); // return to MainForm
            rentalForm.Show();
        }

        private void button_EventTicketing_Click(object sender, EventArgs e)
        {
            Form2_PlaylistBuilder mainForm = new Form2_PlaylistBuilder();
            mainForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
