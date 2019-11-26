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
    public partial class ImageBlinkerTrening : Form
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
        //private Image Green =    Image.FromFile("imgs\green.jpg");
        //private Image Orange =   Image.FromFile("imgs\orange.jpg");
        Rectangle resolution = Screen.PrimaryScreen.Bounds;



        String path;
        StreamWriter fs;
        bool trening;

        public ImageBlinkerTrening(bool trening)
        {
            InitializeComponent();
            this.secPP = 500; //sekundy na mignięcie
            this.trening = trening;

            path = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss");
            if(this.trening)
                path = @"wyniki\Trening_" + path + ".txt";
            else
                path = @"wyniki\Test_" + path + ".txt";
            fs = new StreamWriter(path);
            this.fs.WriteLine("Target was in this blinks:");

                      
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            BackColor = Color.White;

            timerImage.Interval = this.secPP;
            timerImage.Start();
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
                
                this.fs.WriteLine("==================================");
                this.fs.WriteLine("==================================");
                this.fs.WriteLine("Total numbers of blinks:" + licznik.ToString());
                this.fs.Close();
                this.Close();

            }
        }



        private void timerImage_Tick(object sender, EventArgs e)
        {
            if (this.licznik == 300 * 2)
            {
                this.fs.Close();
                this.Close();
            }


            if (this.klik == 1)
            {
                pictureBox1.Hide();
                this.klik = 0;
            }

            else
            {
                this.licznik++;
                int rr = rnd.Next(1, 121);
                                
                if (rr<= 25)
                    SetImage(Red);
                if ((rr > 25) && (rr <=50) )
                    SetImage(Orange);
                if ((rr > 50) && (rr <= 75))
                    SetImage(Green);
                if ((rr > 75) && (rr <= 100))
                    SetImage(Yellow);
                if (rr > 100 )
                {
                    SetImage(Target);
                    if(this.trening)
                        this.fs.WriteLine(this.licznik.ToString() + '\t' + DateTime.Now.ToString("HH:mm:ss.FFF"));
                }
                pictureBox1.Show();
                this.klik = 1;
            }
        }
    }
}
