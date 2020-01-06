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
    public partial class ImageMATRIX : Form
    {
        private int secPP;
        private Image Target = Image.FromFile("imgs\\beer.png");
        private Image Black = Image.FromFile("imgs\\black.png");

        private Image Grapes = Image.FromFile("imgs\\grapes.png");
        private Image Lime = Image.FromFile("imgs\\lime.png");
        private Image Orange = Image.FromFile("imgs\\orange.png");
        private Image Carrot = Image.FromFile("imgs\\carrot.png");
        private Image Strawberry = Image.FromFile("imgs\\strawberry.png");

        private Random rnd = new Random();
        private int Counter = 0;
        private int Counter2 = 0;
        private int TargetCounter = 0;
        private bool klik = false;
        private int TargetNum = 0;
        Rectangle resolution = Screen.PrimaryScreen.Bounds;
        private bool [] IMGOnOff = new bool[6] {false, false, false, false, false, false };
        PictureBox[] array = new PictureBox[6];

        

        String path;
        StreamWriter fs;
        bool trening;

        public int SecPP { get => secPP; set => secPP = value; }
        public Image Target1 { get => Target; set => Target = value; }
        public Image Black1 { get => Black; set => Black = value; }
        public Image Grapes1 { get => Grapes; set => Grapes = value; }
        public Image Lime1 { get => Lime; set => Lime = value; }
        public Image Orange1 { get => Orange; set => Orange = value; }
        public Image Carrot1 { get => Carrot; set => Carrot = value; }
        public Image Strawberry1 { get => Strawberry; set => Strawberry = value; }
        public Random Rnd { get => rnd; set => rnd = value; }
        public int Licznik { get => Counter; set => Counter = value; }
        public bool Klik { get => klik; set => klik = value; }
        public Rectangle Resolution { get => resolution; set => resolution = value; }
        public bool[] IMGOnOff1 { get => IMGOnOff; set => IMGOnOff = value; }
        public PictureBox[] Array { get => array; set => array = value; }
        public string Path { get => path; set => path = value; }
        public StreamWriter Fs { get => fs; set => fs = value; }
        public bool Trening { get => trening; set => trening = value; }

        public ImageMATRIX()
        {


            InitializeComponent();
            
            Array[0] = pictureBox1;
            Array[1] = pictureBox2;
            Array[2] = pictureBox3;
            Array[3] = pictureBox4;
            Array[4] = pictureBox5;
            Array[5] = pictureBox6;

            pictureBoxBlack.Image = Black1;
            Array[0].Image = Target1;
            Array[1].Image = Grapes1;
            Array[2].Image = Lime1;
            Array[3].Image = Orange1;
            Array[4].Image = Carrot1;
            Array[5].Image = Strawberry1;


            for (int i = 0; i < 6; i++) {
                Array[i].Height = 400;
                Array[i].Width = 400;
            }
            pictureBoxBlack.Height = 400;
            pictureBoxBlack.Width = 400;
            pictureBoxTarget.Width = 400;
            pictureBoxTarget.Height = 400;


            pictureBoxTarget.Location= new Point((resolution.Width / 2) - (pictureBoxTarget.Width / 2), (resolution.Height / 2) - (pictureBoxTarget.Height / 2));

            for (int i = 0; i < 3; i++)
            {
                Array[i].Location = new Point(5 + 400 * i + 10*i, 1);
            }

            for (int i = 3; i < 6; i++)
            {
                Array[i].Location = new Point(5 + 400 * (i-3) + 10* (i - 3), 410);
            }

            this.TargetNum = Rnd.Next(1, 6);
            pictureBoxTarget.Image =Array[this.TargetNum-1].Image ;

            pictureBoxTarget.Hide();


            MatrixOnOff(this.IMGOnOff1);



            this.SecPP = 500; //sekundy na mignięcie
            this.Trening = Trening;



                



            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            BackColor = Color.White;
            MatrixOnOff(this.IMGOnOff1);
            pictureBoxBlack.Hide();


            MATRIX_timer.Interval = this.secPP;
            MATRIX_timer.Start();

            pictureBoxTarget.Show();

            Path = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss");
            Path = @"results\MATRIX_" + Path + ".txt";

            Fs = new StreamWriter(Path);
            this.Fs.WriteLine("Target is image number: "+ this.TargetNum.ToString());



        }

        private void MatrixOnOff(bool[] OnOff)
        {
            pictureBoxBlack.Hide();
            for (int i = 0; i < 6; i++)
            {
                if (OnOff[i] == false)
                {
                    this.Array[i].Hide();
                    this.pictureBoxBlack.Location = this.Array[i].Location;
                    pictureBoxBlack.Show();
                }
                if (OnOff[i] == true)
                    this.Array[i].Show();
                                                         }
        }
        private void EndSesion() {

            this.fs.WriteLine("==================================");
            this.fs.WriteLine("==================================");
            this.fs.WriteLine("Total numbers of blinks:" + Counter2.ToString());
            this.fs.WriteLine("Total numbers of target blinks:" + TargetCounter.ToString());
            this.fs.Close();
            this.Close();

        }
        private void ImageMATRIX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                EndSesion();


            }
        }

        private void MATRIX_timer_Tick(object sender, EventArgs e)
        {



            if ((this.TargetCounter >= 10)&&(this.Counter2%2==0))
            {
                EndSesion();
                return;
            }

            if (Counter >= 10)
            {
                this.pictureBoxTarget.Hide();
                if (this.Klik)
                {

                    int rr = Rnd.Next(1, 6);
                    if (rr == this.TargetNum)
                        this.TargetCounter++;
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == rr-1)
                            IMGOnOff1[i] = false;
                        else
                            IMGOnOff1[i] = true;
                    }
                    MatrixOnOff(IMGOnOff1);

                    this.fs.WriteLine("IMG number " + rr.ToString() + '\t' + DateTime.Now.ToString("HH:mm:ss.FFF"));
                    ;
                }
                else
                {
                    for (int i = 0; i < 6; i++)
                        IMGOnOff1[i] = true;
                    MatrixOnOff(IMGOnOff1);
                    Counter2++;



                }



            }
            else {
                this.pictureBoxTarget.Show();
            }





            this.Counter++;
            this.Klik = !this.Klik;
        }
    }
}
