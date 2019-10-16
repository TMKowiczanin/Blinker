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
    
    public partial class Form1 : Form
    {
        private int czestotliwos = 1;
        private int czasMigania = 60;
        public void setCzestotliwosc(int i) {
            this.czestotliwos = i;
        }
        public int getCzestotliwosc() {
            return this.czestotliwos;

        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form WyskakujaceOkno = new Blinker(this.czestotliwos, this.czasMigania);
            // Show the settings form
            WyskakujaceOkno.Show();
            //System('Pause')
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setCzestotliwosc(1);

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            setCzestotliwosc(10);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            setCzestotliwosc(20);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radio5Hz_CheckedChanged(object sender, EventArgs e)
        {
            setCzestotliwosc(2);
        }

        private void radio8Hz_CheckedChanged(object sender, EventArgs e)
        {
            setCzestotliwosc(4);
        }

        private void radio10Hz_CheckedChanged(object sender, EventArgs e)
        {
            setCzestotliwosc(5);
        }

        private void textBoxCzasMigania_TextChanged(object sender, EventArgs e)
        {




        }

        private void textBoxCzasMigania_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (true)
                this.textBoxCzasMigania.Text = "60";




        }
    }
}
