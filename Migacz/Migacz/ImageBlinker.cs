using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Migacz
{
    public partial class ImageBlinker : Form
    {
        private int secPP;
        private Image Target=    Image.FromFile("imgs\\target.jpg");
        private Image Red =      Image.FromFile("imgs\\red.jpg");
        //private Image Green =    Image.FromFile("imgs\green.jpg");
        //private Image Orange =   Image.FromFile("imgs\orange.jpg");
        Rectangle resolution = Screen.PrimaryScreen.Bounds;
        public ImageBlinker()
        {
            InitializeComponent();
            this.secPP = 500;
            

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            timerImage.Interval = this.secPP;
            timerImage.Start();
            BackColor = Color.White;
        }

        private void ImageBlinker_Load(object sender, EventArgs e)
        {

        }

        private void ImageBlinker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timerImage_Tick(object sender, EventArgs e)
        {
            if (BackColor == Color.White)
            {
                BackColor = Color.Black;
                pictureBox1.Hide();
            }

            else
            {
                BackColor = Color.White;
                pictureBox1.Image = this.Target;
                pictureBox1.Show();
            }
        }
    }
}
