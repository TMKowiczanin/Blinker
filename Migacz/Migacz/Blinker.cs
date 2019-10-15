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
        public Blinker()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            timer1.Start();
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
    }
}
