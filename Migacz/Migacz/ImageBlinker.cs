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
        private Image Target    =Image.FromFile("imgs\\target.jpg");
        private Image Red       =Image.FromFile("imgs\\red.jpg");
        private Image Green     =Image.FromFile("imgs\\green.jpg");
        private Image Orange    =Image.FromFile("imgs\\orange.jpg");
        private Random rnd = new Random();
        private int licznik = 0;
        //private Image Green =    Image.FromFile("imgs\green.jpg");
        //private Image Orange =   Image.FromFile("imgs\orange.jpg");
        Rectangle resolution = Screen.PrimaryScreen.Bounds;
        public ImageBlinker()
        {
            InitializeComponent();
             //CreateText(string path);
            //System.IO.StreamWriter writer = new System.IO.StreamWriter("wyniki\\ble.txt"); //open the file for writing.
            //writer.Write(DateTime.Now.ToString()); //write the current date to the file. change this with your date or something.
            //writer.Close(); //remember to close the file again.
            //writer.Dispose(); //remember to dispose it from the memory.
            this.secPP = 500;
            
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            timerImage.Interval = this.secPP;
            timerImage.Start();
            BackColor = Color.Black;
        }
        private void SetImage(Image IMG)
        {
            
            pictureBox1.Width = IMG.Width;
            pictureBox1.Height = IMG.Height;
            pictureBox1.Image = IMG;
            pictureBox1.Location = new Point((resolution.Width / 2) - (pictureBox1.Width / 2), (resolution.Height / 2) - (pictureBox1.Height / 2));


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
            if (this.licznik== 300*2)
                this.Close();


            this.licznik++;
            if (BackColor == Color.White)
            {
                BackColor = Color.Gray;
                pictureBox1.Hide();
            }

            else
            {
                BackColor = Color.White;
                if(rnd.Next(1,5)==1)
                SetImage(Target);
                if (rnd.Next(1, 5) == 2)
                    SetImage(Red);
                if (rnd.Next(1, 5) == 3)
                    SetImage(Orange);
                if (rnd.Next(1, 5) == 4)
                    SetImage(Green);
                pictureBox1.Show();
            }
        }
    }
}
