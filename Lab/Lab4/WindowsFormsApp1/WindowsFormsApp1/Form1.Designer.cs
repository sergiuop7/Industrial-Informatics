namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_LIstDisplay = new System.Windows.Forms.Button();
            this.textBox_tempC = new System.Windows.Forms.TextBox();
            this.textBox_tempF = new System.Windows.Forms.TextBox();
            this.textBox_Rezultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_FtoC = new System.Windows.Forms.Button();
            this.button_CtoF = new System.Windows.Forms.Button();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.textBox_Conversie = new System.Windows.Forms.TextBox();
            this.testBox_Euro = new System.Windows.Forms.TextBox();
            this.button_Date = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(92, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 0;
            // 
            // button_LIstDisplay
            // 
            this.button_LIstDisplay.Location = new System.Drawing.Point(92, 168);
            this.button_LIstDisplay.Name = "button_LIstDisplay";
            this.button_LIstDisplay.Size = new System.Drawing.Size(120, 26);
            this.button_LIstDisplay.TabIndex = 1;
            this.button_LIstDisplay.Text = "Add List";
            this.button_LIstDisplay.UseVisualStyleBackColor = true;
            this.button_LIstDisplay.Click += new System.EventHandler(this.button_LIstDisplay_Click);
            // 
            // textBox_tempC
            // 
            this.textBox_tempC.Location = new System.Drawing.Point(616, 52);
            this.textBox_tempC.Name = "textBox_tempC";
            this.textBox_tempC.Size = new System.Drawing.Size(100, 22);
            this.textBox_tempC.TabIndex = 2;
            // 
            // textBox_tempF
            // 
            this.textBox_tempF.Location = new System.Drawing.Point(616, 119);
            this.textBox_tempF.Name = "textBox_tempF";
            this.textBox_tempF.Size = new System.Drawing.Size(100, 22);
            this.textBox_tempF.TabIndex = 3;
            // 
            // textBox_Rezultat
            // 
            this.textBox_Rezultat.Location = new System.Drawing.Point(616, 184);
            this.textBox_Rezultat.Name = "textBox_Rezultat";
            this.textBox_Rezultat.Size = new System.Drawing.Size(100, 22);
            this.textBox_Rezultat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temp C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Temp F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rezultat";
            // 
            // button_FtoC
            // 
            this.button_FtoC.Location = new System.Drawing.Point(558, 245);
            this.button_FtoC.Name = "button_FtoC";
            this.button_FtoC.Size = new System.Drawing.Size(75, 23);
            this.button_FtoC.TabIndex = 8;
            this.button_FtoC.Text = "FtoC";
            this.button_FtoC.UseVisualStyleBackColor = true;
            this.button_FtoC.Click += new System.EventHandler(this.button_FtoC_Click);
            // 
            // button_CtoF
            // 
            this.button_CtoF.Location = new System.Drawing.Point(558, 286);
            this.button_CtoF.Name = "button_CtoF";
            this.button_CtoF.Size = new System.Drawing.Size(75, 23);
            this.button_CtoF.TabIndex = 9;
            this.button_CtoF.Text = "CtoF";
            this.button_CtoF.UseVisualStyleBackColor = true;
            this.button_CtoF.Click += new System.EventHandler(this.button_CtoF_Click);
            // 
            // textBox_Date
            // 
            this.textBox_Date.Location = new System.Drawing.Point(159, 337);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.ReadOnly = true;
            this.textBox_Date.Size = new System.Drawing.Size(234, 22);
            this.textBox_Date.TabIndex = 11;
            this.textBox_Date.TextChanged += new System.EventHandler(this.textBox_Date_TextChanged);
            // 
            // textBox_Conversie
            // 
            this.textBox_Conversie.Location = new System.Drawing.Point(558, 364);
            this.textBox_Conversie.Name = "textBox_Conversie";
            this.textBox_Conversie.Size = new System.Drawing.Size(100, 22);
            this.textBox_Conversie.TabIndex = 12;
            this.textBox_Conversie.TextChanged += new System.EventHandler(this.textBox_Conversie_TextChanged);
            // 
            // testBox_Euro
            // 
            this.testBox_Euro.Location = new System.Drawing.Point(558, 413);
            this.testBox_Euro.Name = "testBox_Euro";
            this.testBox_Euro.ReadOnly = true;
            this.testBox_Euro.Size = new System.Drawing.Size(100, 22);
            this.testBox_Euro.TabIndex = 13;
            this.testBox_Euro.TextChanged += new System.EventHandler(this.testBox_Euro_TextChanged);
            // 
            // button_Date
            // 
            this.button_Date.Location = new System.Drawing.Point(63, 337);
            this.button_Date.Name = "button_Date";
            this.button_Date.Size = new System.Drawing.Size(75, 23);
            this.button_Date.TabIndex = 15;
            this.button_Date.Text = "Data";
            this.button_Date.UseVisualStyleBackColor = true;
            this.button_Date.Click += new System.EventHandler(this.button_Date_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Euro to Ron";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Date);
            this.Controls.Add(this.testBox_Euro);
            this.Controls.Add(this.textBox_Conversie);
            this.Controls.Add(this.textBox_Date);
            this.Controls.Add(this.button_CtoF);
            this.Controls.Add(this.button_FtoC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Rezultat);
            this.Controls.Add(this.textBox_tempF);
            this.Controls.Add(this.textBox_tempC);
            this.Controls.Add(this.button_LIstDisplay);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_LIstDisplay;
        private System.Windows.Forms.TextBox textBox_tempC;
        private System.Windows.Forms.TextBox textBox_tempF;
        private System.Windows.Forms.TextBox textBox_Rezultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_FtoC;
        private System.Windows.Forms.Button button_CtoF;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.TextBox textBox_Conversie;
        private System.Windows.Forms.TextBox testBox_Euro;
        private System.Windows.Forms.Button button_Date;
        private System.Windows.Forms.Button button1;
    }
}

