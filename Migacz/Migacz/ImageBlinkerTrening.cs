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
        private Image Target    =Image.FromFile("imgs\\beer.png");

        private Image Grapes       =Image.FromFile("imgs\\grapes.png");
        private Image Lime     =Image.FromFile("imgs\\lime.png");
        private Image Orange    =Image.FromFile("imgs\\orange.png");
        private Image Carrot    =Image.FromFile("imgs\\carrot.png");
        private Image Strawberry = Image.FromFile("imgs\\strawberry.png");

        private Random rnd = new Random();
        private int Counter = 0;
        private int Click = 0;
        //private Image Green =    Image.FromFile("imgs\green.jpg");
        //private Image Orange =   Image.FromFile("imgs\orange.jpg");
        Rectangle resolution = Screen.PrimaryScreen.Bounds;



        String path;
        StreamWriter fs;
        bool trening;

        public ImageBlinkerTrening(bool trening)
        {
            InitializeComponent();
            this.secPP = 500; //sec per blink
            this.trening = trening;

            path = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss");
            if(this.trening)
                path = @"results\Trening_" + path + ".txt";
            else
                path = @"results\Test_" + path + ".txt";
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

                EndSesion();
                return;

            }
        }
        private void EndSesion()
        {

            this.fs.WriteLine("==================================");
            this.fs.WriteLine("==================================");
            this.fs.WriteLine("Total numbers of blinks:" + Counter.ToString());
            this.fs.Close();
            this.Close();

        }


        private void timerImage_Tick(object sender, EventArgs e)
        {
            if (this.Counter == 300 * 2)
            {
                EndSesion();
                return;
            }


            if (this.Click == 1)
            {
                pictureBox1.Hide();
                this.Click = 0;
            }

            else
            {
                this.Counter++;
                int rr = rnd.Next(1, 121);
                                
                if (rr<= 20)
                    SetImage(Carrot);
                if ((rr > 20) && (rr <=40) )
                    SetImage(Orange);
                if ((rr > 40) && (rr <= 60))
                    SetImage(Grapes);
                if ((rr > 60) && (rr <= 80))
                    SetImage(Lime);
                if ((rr > 80) && (rr <= 100))
                    SetImage(Strawberry);

                if (rr > 100 )
                {
                    SetImage(Target);
                    if(this.trening)
                        this.fs.WriteLine(this.Counter.ToString() + '\t' + DateTime.Now.ToString("HH:mm:ss.FFF"));
                }
                pictureBox1.Show();
                this.Click = 1;
            }
        }
    }
}
