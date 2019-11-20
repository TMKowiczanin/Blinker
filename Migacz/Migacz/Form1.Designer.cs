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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolTip toolTipTrening;
            this.buttonTrening = new System.Windows.Forms.Button();
            this.buttonTreningW = new System.Windows.Forms.Button();
            this.buttonTEST = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMigaj = new System.Windows.Forms.Button();
            this.radio1Hz = new System.Windows.Forms.RadioButton();
            this.radio2Hz = new System.Windows.Forms.RadioButton();
            this.radio4Hz = new System.Windows.Forms.RadioButton();
            this.radio5Hz = new System.Windows.Forms.RadioButton();
            this.radio20Hz = new System.Windows.Forms.RadioButton();
            this.radio10Hz = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTESTW = new System.Windows.Forms.Button();
            toolTipTrening = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTipTrening
            // 
            toolTipTrening.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // buttonTrening
            // 
            this.buttonTrening.Location = new System.Drawing.Point(23, 174);
            this.buttonTrening.Name = "buttonTrening";
            this.buttonTrening.Size = new System.Drawing.Size(164, 116);
            this.buttonTrening.TabIndex = 0;
            this.buttonTrening.Text = "TRENING";
            toolTipTrening.SetToolTip(this.buttonTrening, "Na ekranie wyświetla się w sposób losowy przez jedną minutę /n TARGET (10 razy) /" +
        "n NoTARGET (50 razy).");
            this.buttonTrening.UseVisualStyleBackColor = true;
            this.buttonTrening.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTreningW
            // 
            this.buttonTreningW.Location = new System.Drawing.Point(23, 333);
            this.buttonTreningW.Name = "buttonTreningW";
            this.buttonTreningW.Size = new System.Drawing.Size(164, 116);
            this.buttonTreningW.TabIndex = 17;
            this.buttonTreningW.Text = "TRENING WHITE";
            toolTipTrening.SetToolTip(this.buttonTreningW, "Na ekranie wyświetla się w sposób losowy przez jedną minutę /n TARGET (10 razy) /" +
        "n NoTARGET (50 razy).");
            this.buttonTreningW.UseVisualStyleBackColor = true;
            this.buttonTreningW.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonTEST
            // 
            this.buttonTEST.Location = new System.Drawing.Point(245, 174);
            this.buttonTEST.Name = "buttonTEST";
            this.buttonTEST.Size = new System.Drawing.Size(164, 116);
            this.buttonTEST.TabIndex = 1;
            this.buttonTEST.Text = "TEST";
            this.buttonTEST.UseVisualStyleBackColor = true;
            this.buttonTEST.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Blinking time 60s.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMigaj
            // 
            this.buttonMigaj.Location = new System.Drawing.Point(23, 18);
            this.buttonMigaj.Name = "buttonMigaj";
            this.buttonMigaj.Size = new System.Drawing.Size(164, 116);
            this.buttonMigaj.TabIndex = 7;
            this.buttonMigaj.Text = "BLINK";
            this.buttonMigaj.UseVisualStyleBackColor = true;
            this.buttonMigaj.Click += new System.EventHandler(this.button3_Click);
            // 
            // radio1Hz
            // 
            this.radio1Hz.AutoSize = true;
            this.radio1Hz.Location = new System.Drawing.Point(6, 26);
            this.radio1Hz.Name = "radio1Hz";
            this.radio1Hz.Size = new System.Drawing.Size(55, 21);
            this.radio1Hz.TabIndex = 8;
            this.radio1Hz.TabStop = true;
            this.radio1Hz.Text = "1 Hz";
            this.radio1Hz.UseVisualStyleBackColor = true;
            this.radio1Hz.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio2Hz
            // 
            this.radio2Hz.AutoSize = true;
            this.radio2Hz.Location = new System.Drawing.Point(6, 53);
            this.radio2Hz.Name = "radio2Hz";
            this.radio2Hz.Size = new System.Drawing.Size(55, 21);
            this.radio2Hz.TabIndex = 9;
            this.radio2Hz.TabStop = true;
            this.radio2Hz.Text = "2 Hz";
            this.radio2Hz.UseVisualStyleBackColor = true;
            this.radio2Hz.CheckedChanged += new System.EventHandler(this.radio5Hz_CheckedChanged);
            // 
            // radio4Hz
            // 
            this.radio4Hz.AutoSize = true;
            this.radio4Hz.Location = new System.Drawing.Point(6, 80);
            this.radio4Hz.Name = "radio4Hz";
            this.radio4Hz.Size = new System.Drawing.Size(55, 21);
            this.radio4Hz.TabIndex = 10;
            this.radio4Hz.TabStop = true;
            this.radio4Hz.Text = "4 Hz";
            this.radio4Hz.UseVisualStyleBackColor = true;
            this.radio4Hz.CheckedChanged += new System.EventHandler(this.radio8Hz_CheckedChanged);
            // 
            // radio5Hz
            // 
            this.radio5Hz.AutoSize = true;
            this.radio5Hz.Location = new System.Drawing.Point(76, 26);
            this.radio5Hz.Name = "radio5Hz";
            this.radio5Hz.Size = new System.Drawing.Size(55, 21);
            this.radio5Hz.TabIndex = 11;
            this.radio5Hz.TabStop = true;
            this.radio5Hz.Text = "5 Hz";
            this.radio5Hz.UseVisualStyleBackColor = true;
            this.radio5Hz.CheckedChanged += new System.EventHandler(this.radio10Hz_CheckedChanged);
            // 
            // radio20Hz
            // 
            this.radio20Hz.AutoSize = true;
            this.radio20Hz.Location = new System.Drawing.Point(76, 80);
            this.radio20Hz.Name = "radio20Hz";
            this.radio20Hz.Size = new System.Drawing.Size(63, 21);
            this.radio20Hz.TabIndex = 13;
            this.radio20Hz.TabStop = true;
            this.radio20Hz.Text = "20 Hz";
            this.radio20Hz.UseVisualStyleBackColor = true;
            this.radio20Hz.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radio10Hz
            // 
            this.radio10Hz.AutoSize = true;
            this.radio10Hz.Location = new System.Drawing.Point(76, 53);
            this.radio10Hz.Name = "radio10Hz";
            this.radio10Hz.Size = new System.Drawing.Size(63, 21);
            this.radio10Hz.TabIndex = 12;
            this.radio10Hz.TabStop = true;
            this.radio10Hz.Text = "10 Hz";
            this.radio10Hz.UseVisualStyleBackColor = true;
            this.radio10Hz.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio1Hz);
            this.groupBox1.Controls.Add(this.radio20Hz);
            this.groupBox1.Controls.Add(this.radio2Hz);
            this.groupBox1.Controls.Add(this.radio10Hz);
            this.groupBox1.Controls.Add(this.radio4Hz);
            this.groupBox1.Controls.Add(this.radio5Hz);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(239, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 116);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select frequency";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "TRENING time 300s.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "TEST time 600s.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonTESTW
            // 
            this.buttonTESTW.Location = new System.Drawing.Point(245, 333);
            this.buttonTESTW.Name = "buttonTESTW";
            this.buttonTESTW.Size = new System.Drawing.Size(164, 116);
            this.buttonTESTW.TabIndex = 18;
            this.buttonTESTW.Text = "TEST WHITE";
            this.buttonTESTW.UseVisualStyleBackColor = true;
            this.buttonTESTW.Click += new System.EventHandler(this.buttonTESTW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 476);
            this.Controls.Add(this.buttonTESTW);
            this.Controls.Add(this.buttonTreningW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMigaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTEST);
            this.Controls.Add(this.buttonTrening);
            this.Name = "Form1";
            this.Text = "PwM Blinker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTrening;
        private System.Windows.Forms.Button buttonTEST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMigaj;
        private System.Windows.Forms.RadioButton radio1Hz;
        private System.Windows.Forms.RadioButton radio2Hz;
        private System.Windows.Forms.RadioButton radio4Hz;
        private System.Windows.Forms.RadioButton radio5Hz;
        private System.Windows.Forms.RadioButton radio20Hz;
        private System.Windows.Forms.RadioButton radio10Hz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTreningW;
        private System.Windows.Forms.Button buttonTESTW;
    }
}

