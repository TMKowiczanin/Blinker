using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Migacz
{
    public partial class ImageBlinkerTreningWhite : Form
    {
        private int secPP;
        private Image Target    =Image.FromFile("imgs\\target.jpg");
        private Image Red       =Image.FromFile("imgs\\red.jpg");
        private Image Green     =Image.FromFile("imgs\\green.jpg");
        private Image Orange    =Image.FromFile("imgs\\orange.jpg");
        private Image Yellow    =Image.FromFile("imgs\\yellow.jpg");
        private Random rnd = new Random();
        private int licznik = 0;
        private int klik = 0;

        Rectangle resolution = Screen.PrimaryScreen.Bounds;



        String path;
        StreamWriter fs;
        bool trening;

        public ImageBlinkerTreningWhite(bool trening)
        {
            InitializeComponent();
            this.secPP = 500; //sekundy na mignięcie
            this.trening = trening;

            path = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss");
            if(this.trening)
                path = @"wyniki\TreningW_" + path + ".txt";
            else
                path = @"wyniki\TestW_" + path + ".txt";
            fs = new StreamWriter(path);
            this.fs.WriteLine("Target was in this blinks:");

            pictureBox.Hide();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            BackColor = Color.White;
            SetImage(Target);
            timerImageW.Interval = this.secPP;
            timerImageW.Start();
        }
        private void SetImage(Image IMG)
        {
            
            pictureBox.Width = IMG.Width;
            pictureBox.Height = IMG.Height;
            pictureBox.Image = IMG;
            pictureBox.Location = new Point((resolution.Width / 2) - (pictureBox.Width / 2), (resolution.Height / 2) - (pictureBox.Height / 2));


        }
        private void ImageBlinker_Load(object sender, EventArgs e)
        {

        }

        private void ImageBlinker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                this.fs.WriteLine("==================================");
                this.fs.WriteLine("==================================");
                this.fs.WriteLine("Total numbers of blinks:" + licznik.ToString());
                this.fs.Close();
                this.Close();

            }
        }



        private void timerImageW_Tick(object sender, EventArgs e)
        {
            if (this.licznik == 300 * 2)
            {
                this.fs.Close();
                this.Close();
            }
            

            if (this.klik == 1)
            {
             
                pictureBox.Hide();
            }

            else
            {
                this.licznik++;
                int rr = rnd.Next(1, 100);
                
                
                if (rr > 75 )
                {
                    
                    if(this.trening)
                        this.fs.WriteLine(this.licznik.ToString() + '\t' + DateTime.Now.ToString("HH:mm:ss.FFF"));
                }
                pictureBox.Show();
            }
        }

        private void ImageBlinkerTrening_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.licznik == 300 * 2)
            {
                this.fs.Close();
                this.Close();
            }


            if (this.klik == 1)
            {
                
                pictureBox.Hide();
                this.klik = 0;
            }

            else
            {
                this.licznik++;
                int rr = rnd.Next(1, 100);


                if (rr > 75)
                {
                    //this.fs.WriteLine(this.licznik.ToString() + '\t' + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.FFF"));
                    pictureBox.Show();
                    if (this.trening)
                        this.fs.WriteLine(this.licznik.ToString() + '\t' + DateTime.Now.ToString("HH:mm:ss.FFF"));
                }

                this.klik = 1;
            }
        }
    }
}
