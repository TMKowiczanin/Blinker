using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Migacz
{
    public partial class Blinker : Form
    {
        int licznik = 0;
        int BlinkC = 0;
        int secPP = 500;
        int czasTrwania = 60;
        String path;
        StreamWriter fs;
        int Freq;
        public Blinker(int czestotliwosc, int migniecia)
        {
            Freq = czestotliwosc;
            path = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss");
            path = @"wyniki\Blinks_" + path + ".txt";
            fs = new StreamWriter(path);
            //tw = new StreamWriter(fs);

            czasTrwania = migniecia;
            secPP = 1000 / (2 * czestotliwosc);
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            timer1.Interval = secPP;
            timer1.Start();
            timer2.Start();
            BackColor = Color.White;
           
          
            //int j = 20;
            //for (int i = 0; i <= j; i++)
            //{

            //    BackColor = Color.Red;
            //    wait(500);
            //    BackColor = Color.Black;
            //    wait(500);
            //}


        }

        private void Blinker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                this.fs.WriteLine("Blinks " + this.BlinkC.ToString() + " times.");
                this.fs.WriteLine("Blinking frequency: "+Freq.ToString());
                this.fs.Close();
                this.Close();

            }
        }

        private void Blinker_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BackColor == Color.White)
                BackColor = Color.Black;
            else
            {
                BackColor = Color.White;
                this.BlinkC++;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            WyswietlaczSekund.Text= Convert.ToString( ++this.licznik);

            if (this.licznik == czasTrwania)
                this.Close();
        }
    }
}
