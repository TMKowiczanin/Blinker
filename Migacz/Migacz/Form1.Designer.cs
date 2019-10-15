namespace Migacz
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxCzasMigania = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMigaj = new System.Windows.Forms.Button();
            this.radio4Hz = new System.Windows.Forms.RadioButton();
            this.radio5Hz = new System.Windows.Forms.RadioButton();
            this.radio8Hz = new System.Windows.Forms.RadioButton();
            this.radio10Hz = new System.Windows.Forms.RadioButton();
            this.radio20Hz = new System.Windows.Forms.RadioButton();
            this.radio15Hz = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "TRENING";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "TEST";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxCzasMigania
            // 
            this.textBoxCzasMigania.Location = new System.Drawing.Point(296, 64);
            this.textBoxCzasMigania.Name = "textBoxCzasMigania";
            this.textBoxCzasMigania.Size = new System.Drawing.Size(100, 20);
            this.textBoxCzasMigania.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 281);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 328);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Czas migania [s]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // buttonMigaj
            // 
            this.buttonMigaj.Location = new System.Drawing.Point(60, 61);
            this.buttonMigaj.Name = "buttonMigaj";
            this.buttonMigaj.Size = new System.Drawing.Size(75, 23);
            this.buttonMigaj.TabIndex = 7;
            this.buttonMigaj.Text = "MIGAJ";
            this.buttonMigaj.UseVisualStyleBackColor = true;
            this.buttonMigaj.Click += new System.EventHandler(this.button3_Click);
            // 
            // radio4Hz
            // 
            this.radio4Hz.AutoSize = true;
            this.radio4Hz.Location = new System.Drawing.Point(22, 19);
            this.radio4Hz.Name = "radio4Hz";
            this.radio4Hz.Size = new System.Drawing.Size(47, 17);
            this.radio4Hz.TabIndex = 8;
            this.radio4Hz.TabStop = true;
            this.radio4Hz.Text = "4 Hz";
            this.radio4Hz.UseVisualStyleBackColor = true;
            this.radio4Hz.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio5Hz
            // 
            this.radio5Hz.AutoSize = true;
            this.radio5Hz.Location = new System.Drawing.Point(22, 42);
            this.radio5Hz.Name = "radio5Hz";
            this.radio5Hz.Size = new System.Drawing.Size(47, 17);
            this.radio5Hz.TabIndex = 9;
            this.radio5Hz.TabStop = true;
            this.radio5Hz.Text = "5 Hz";
            this.radio5Hz.UseVisualStyleBackColor = true;
            this.radio5Hz.CheckedChanged += new System.EventHandler(this.radio5Hz_CheckedChanged);
            // 
            // radio8Hz
            // 
            this.radio8Hz.AutoSize = true;
            this.radio8Hz.Location = new System.Drawing.Point(22, 65);
            this.radio8Hz.Name = "radio8Hz";
            this.radio8Hz.Size = new System.Drawing.Size(47, 17);
            this.radio8Hz.TabIndex = 10;
            this.radio8Hz.TabStop = true;
            this.radio8Hz.Text = "8 Hz";
            this.radio8Hz.UseVisualStyleBackColor = true;
            // 
            // radio10Hz
            // 
            this.radio10Hz.AutoSize = true;
            this.radio10Hz.Location = new System.Drawing.Point(92, 19);
            this.radio10Hz.Name = "radio10Hz";
            this.radio10Hz.Size = new System.Drawing.Size(53, 17);
            this.radio10Hz.TabIndex = 11;
            this.radio10Hz.TabStop = true;
            this.radio10Hz.Text = "10 Hz";
            this.radio10Hz.UseVisualStyleBackColor = true;
            // 
            // radio20Hz
            // 
            this.radio20Hz.AutoSize = true;
            this.radio20Hz.Location = new System.Drawing.Point(92, 65);
            this.radio20Hz.Name = "radio20Hz";
            this.radio20Hz.Size = new System.Drawing.Size(53, 17);
            this.radio20Hz.TabIndex = 13;
            this.radio20Hz.TabStop = true;
            this.radio20Hz.Text = "20 Hz";
            this.radio20Hz.UseVisualStyleBackColor = true;
            this.radio20Hz.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radio15Hz
            // 
            this.radio15Hz.AutoSize = true;
            this.radio15Hz.Location = new System.Drawing.Point(92, 42);
            this.radio15Hz.Name = "radio15Hz";
            this.radio15Hz.Size = new System.Drawing.Size(53, 17);
            this.radio15Hz.TabIndex = 12;
            this.radio15Hz.TabStop = true;
            this.radio15Hz.Text = "15 Hz";
            this.radio15Hz.UseVisualStyleBackColor = true;
            this.radio15Hz.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio4Hz);
            this.groupBox1.Controls.Add(this.radio20Hz);
            this.groupBox1.Controls.Add(this.radio5Hz);
            this.groupBox1.Controls.Add(this.radio15Hz);
            this.groupBox1.Controls.Add(this.radio8Hz);
            this.groupBox1.Controls.Add(this.radio10Hz);
            this.groupBox1.Location = new System.Drawing.Point(461, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz częstotliwość";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMigaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxCzasMigania);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "PwM Migacz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxCzasMigania;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMigaj;
        private System.Windows.Forms.RadioButton radio4Hz;
        private System.Windows.Forms.RadioButton radio5Hz;
        private System.Windows.Forms.RadioButton radio8Hz;
        private System.Windows.Forms.RadioButton radio10Hz;
        private System.Windows.Forms.RadioButton radio20Hz;
        private System.Windows.Forms.RadioButton radio15Hz;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

