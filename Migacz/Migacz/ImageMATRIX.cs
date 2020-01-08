using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Migacz
{
    public partial class ImageMATRIX : Form
    {
        private int SecPP;
        private Image Target = Image.FromFile("imgs\\beer.png");
        private Image Black = Image.FromFile("imgs\\black.png");

        private Image Grapes = Image.FromFile("imgs\\grapes.png");
        private Image Lime = Image.FromFile("imgs\\lime.png");
        private Image Orange = Image.FromFile("imgs\\orange.png");
        private Image Carrot = Image.FromFile("imgs\\carrot.png");
        private Image Strawberry = Image.FromFile("imgs\\strawberry.png");

        private Random Rnd = new Random();
        private int Counter = 0;
        private int Counter2 = 0;
        private int TargetCounter = 0;
        private bool Klik = false;
        private int TargetNum = 0;
        Rectangle resolution = Screen.PrimaryScreen.Bounds;
        private bool[] IMGOnOff = new bool[6] { false, false, false, false, false, false };
        PictureBox[] Array = new PictureBox[6];

        int[] NumArray = new int[6] { 1, 2, 3, 4, 5, 6 };
        int[] ScenarioNumArray = new int[20 * 6];


        string Path;
        StreamWriter Fs;
        bool trening;



        public ImageMATRIX()
        {


            InitializeComponent();

            for (int i = 0; i < 20; i++)
            {
                Shuffle(NumArray);
                for (int j = 0; j < 6; j++)
                    ScenarioNumArray[i * 6 + j] = NumArray[j];

            }

            Array[0] = pictureBox1;
            Array[1] = pictureBox2;
            Array[2] = pictureBox3;
            Array[3] = pictureBox4;
            Array[4] = pictureBox5;
            Array[5] = pictureBox6;

            pictureBoxBlack.Image = Black;
            Array[0].Image = Target;
            Array[1].Image = Grapes;
            Array[2].Image = Lime;
            Array[3].Image = Orange;
            Array[4].Image = Carrot;
            Array[5].Image = Strawberry;


            for (int i = 0; i < 6; i++)
            {
                Array[i].Height = 400;
                Array[i].Width = 400;
            }
            pictureBoxBlack.Height = 400;
            pictureBoxBlack.Width = 400;
            pictureBoxTarget.Width = 400;
            pictureBoxTarget.Height = 400;


            pictureBoxTarget.Location = new Point((resolution.Width / 2) - (pictureBoxTarget.Width / 2), (resolution.Height / 2) - (pictureBoxTarget.Height / 2));

            for (int i = 0; i < 3; i++)
            {
                Array[i].Location = new Point((resolution.Width - 400 * 3) / 4 + 400 * i + (resolution.Width - 400 * 3) / 4 * i, (resolution.Height - 400 * 2) / 3);
            }

            for (int i = 3; i < 6; i++)
            {
                Array[i].Location = new Point((resolution.Width - 400 * 3) / 4 + 400 * (i - 3) + (resolution.Width - 400 * 3) / 4 * (i - 3), 400 + 2 * (resolution.Height - 400 * 2) / 3);
            }

            TargetNum = Rnd.Next(1, 6);
            pictureBoxTarget.Image = Array[TargetNum - 1].Image;

            pictureBoxTarget.Hide();


            MatrixOnOff(IMGOnOff);



            SecPP = 500; //sekundy na mignięcie
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            BackColor = Color.White;
            MatrixOnOff(IMGOnOff);
            pictureBoxBlack.Hide();


            MATRIX_timer.Interval = SecPP;
            MATRIX_timer.Start();

            pictureBoxTarget.Show();

            Path = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss");
            Path = @"results\MATRIX_" + Path + ".txt";

            Fs = new StreamWriter(Path);
            Fs.WriteLine("Target is image number: " + TargetNum.ToString());



        }


        public void Shuffle<T>(T[] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        private void MatrixOnOff(bool[] OnOff)
        {
            pictureBoxBlack.Hide();
            for (int i = 0; i < 6; i++)
            {
                if (OnOff[i] == false)
                {
                    Array[i].Hide();
                    pictureBoxBlack.Location = Array[i].Location;
                    pictureBoxBlack.Show();
                }
                if (OnOff[i] == true)
                    Array[i].Show();
            }
        }
        private void EndSesion()
        {

            Fs.WriteLine("==================================");
            Fs.WriteLine("==================================");
            Fs.WriteLine("Total numbers of blinks:" + (Counter2 - 1).ToString());
            Fs.WriteLine("Total numbers of target blinks:" + TargetCounter.ToString());
            Fs.Close();
            Close();

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



            if ((Counter2 > 120))
            {
                EndSesion();
                return;
            }
            if (Counter < 6)
            {
                pictureBoxTarget.Show();
            }
            if ((Counter > 6) && (Counter < 12))
            {
                pictureBoxTarget.Hide();
                for (int i = 0; i < 6; i++)
                    Array[i].Show();

            }
            if (Counter >= 12)
            {
                pictureBoxTarget.Hide();
                if (Klik)
                {

                    //int rr = Rnd.Next(1, 6);
                    int rr = ScenarioNumArray[Counter2 - 1];
                    if (rr == TargetNum)
                        TargetCounter++;
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == rr - 1)
                            IMGOnOff[i] = false;
                        else
                            IMGOnOff[i] = true;
                    }
                    MatrixOnOff(IMGOnOff);

                    Fs.WriteLine("IMG number " + rr.ToString() + '\t' + DateTime.Now.ToString("HH:mm:ss.FFF"));
                    ;
                }
                else
                {
                    for (int i = 0; i < 6; i++)
                        IMGOnOff[i] = true;
                    MatrixOnOff(IMGOnOff);
                    Counter2++;



                }



            }






            Counter++;
            Klik = !Klik;
        }
    }
}
