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

namespace Migacz
{
    public partial class Blinker : Form
    {
        int licznik = 0;
        int secPP = 500;
        int czasTrwania = 60;
        public Blinker(int czestotliwosc, int migniecia)
        {
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
                BackColor = Color.White;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            WyswietlaczSekund.Text= Convert.ToString( ++this.licznik);

            if (this.licznik == czasTrwania)
                this.Close();
        }
    }
}
