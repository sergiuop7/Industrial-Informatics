namespace myDatabase
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
            this.components = new System.ComponentModel.Container();
            this.listBox_Univ = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Fac = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_CodeUniv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_NumeUniv = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_Oras = new System.Windows.Forms.TextBox();
            this.textBox_Cod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new myDatabase.Database1DataSet();
            this.facultatiTableAdapter = new myDatabase.Database1DataSetTableAdapters.FacultatiTableAdapter();
            this.stergere_Fac = new System.Windows.Forms.Button();
            this.adaugare_Fac = new System.Windows.Forms.Button();
            this.textBox_Id_Fac = new System.Windows.Forms.TextBox();
            this.textBox_Cod_Fac = new System.Windows.Forms.TextBox();
            this.textBox_Nume_Fac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Univ
            // 
            this.listBox_Univ.FormattingEnabled = true;
            this.listBox_Univ.ItemHeight = 16;
            this.listBox_Univ.Location = new System.Drawing.Point(68, 68);
            this.listBox_Univ.Name = "listBox_Univ";
            this.listBox_Univ.Size = new System.Drawing.Size(202, 180);
            this.listBox_Univ.TabIndex = 0;
            this.listBox_Univ.SelectedIndexChanged += new System.EventHandler(this.listBox_Univ_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Universitati";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox_Fac
            // 
            this.listBox_Fac.FormattingEnabled = true;
            this.listBox_Fac.ItemHeight = 16;
            this.listBox_Fac.Location = new System.Drawing.Point(417, 68);
            this.listBox_Fac.Name = "listBox_Fac";
            this.listBox_Fac.Size = new System.Drawing.Size(176, 100);
            this.listBox_Fac.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Facultati";
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(417, 207);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(100, 22);
            this.textBox_City.TabIndex = 4;
            // 
            // textBox_CodeUniv
            // 
            this.textBox_CodeUniv.Location = new System.Drawing.Point(417, 262);
            this.textBox_CodeUniv.Name = "textBox_CodeUniv";
            this.textBox_CodeUniv.Size = new System.Drawing.Size(100, 22);
            this.textBox_CodeUniv.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cod Univ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adauga Universitate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_NumeUniv
            // 
            this.textBox_NumeUniv.Location = new System.Drawing.Point(417, 432);
            this.textBox_NumeUniv.Name = "textBox_NumeUniv";
            this.textBox_NumeUniv.Size = new System.Drawing.Size(194, 22);
            this.textBox_NumeUniv.TabIndex = 9;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(287, 432);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(63, 22);
            this.textBox_Id.TabIndex = 10;
            this.textBox_Id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_Oras
            // 
            this.textBox_Oras.Location = new System.Drawing.Point(635, 432);
            this.textBox_Oras.Name = "textBox_Oras";
            this.textBox_Oras.Size = new System.Drawing.Size(135, 22);
            this.textBox_Oras.TabIndex = 11;
            // 
            // textBox_Cod
            // 
            this.textBox_Cod.Location = new System.Drawing.Point(802, 432);
            this.textBox_Cod.Name = "textBox_Cod";
            this.textBox_Cod.Size = new System.Drawing.Size(100, 22);
            this.textBox_Cod.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nume Universitate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Oras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(799, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cod";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 25);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sterge Universitate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 24);
            this.button3.TabIndex = 18;
            this.button3.Text = "Actualizeaza Universitate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameFacDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facultatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(635, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 266);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameFacDataGridViewTextBoxColumn
            // 
            this.nameFacDataGridViewTextBoxColumn.DataPropertyName = "NameFac";
            this.nameFacDataGridViewTextBoxColumn.HeaderText = "NameFac";
            this.nameFacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameFacDataGridViewTextBoxColumn.Name = "nameFacDataGridViewTextBoxColumn";
            this.nameFacDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultatiBindingSource
            // 
            this.facultatiBindingSource.DataMember = "Facultati";
            this.facultatiBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultatiTableAdapter
            // 
            this.facultatiTableAdapter.ClearBeforeFill = true;
            // 
            // stergere_Fac
            // 
            this.stergere_Fac.Location = new System.Drawing.Point(904, 28);
            this.stergere_Fac.Name = "stergere_Fac";
            this.stergere_Fac.Size = new System.Drawing.Size(157, 23);
            this.stergere_Fac.TabIndex = 20;
            this.stergere_Fac.Text = "Sterge Facultate";
            this.stergere_Fac.UseVisualStyleBackColor = true;
            this.stergere_Fac.Click += new System.EventHandler(this.stergere_Fac_Click);
            // 
            // adaugare_Fac
            // 
            this.adaugare_Fac.Location = new System.Drawing.Point(635, 28);
            this.adaugare_Fac.Name = "adaugare_Fac";
            this.adaugare_Fac.Size = new System.Drawing.Size(181, 23);
            this.adaugare_Fac.TabIndex = 21;
            this.adaugare_Fac.Text = "Adauga Facultate";
            this.adaugare_Fac.UseVisualStyleBackColor = true;
            this.adaugare_Fac.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_Id_Fac
            // 
            this.textBox_Id_Fac.Location = new System.Drawing.Point(635, 362);
            this.textBox_Id_Fac.Name = "textBox_Id_Fac";
            this.textBox_Id_Fac.Size = new System.Drawing.Size(76, 22);
            this.textBox_Id_Fac.TabIndex = 22;
            // 
            // textBox_Cod_Fac
            // 
            this.textBox_Cod_Fac.Location = new System.Drawing.Point(802, 362);
            this.textBox_Cod_Fac.Name = "textBox_Cod_Fac";
            this.textBox_Cod_Fac.Size = new System.Drawing.Size(100, 22);
            this.textBox_Cod_Fac.TabIndex = 23;
            // 
            // textBox_Nume_Fac
            // 
            this.textBox_Nume_Fac.Location = new System.Drawing.Point(974, 362);
            this.textBox_Nume_Fac.Name = "textBox_Nume_Fac";
            this.textBox_Nume_Fac.Size = new System.Drawing.Size(192, 22);
            this.textBox_Nume_Fac.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(635, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Id Facultate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(802, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Cod Facultate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(974, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Nume Facultate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 541);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Nume_Fac);
            this.Controls.Add(this.textBox_Cod_Fac);
            this.Controls.Add(this.textBox_Id_Fac);
            this.Controls.Add(this.adaugare_Fac);
            this.Controls.Add(this.stergere_Fac);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Cod);
            this.Controls.Add(this.textBox_Oras);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.textBox_NumeUniv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CodeUniv);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Fac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Univ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Univ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Fac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_CodeUniv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_NumeUniv;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Oras;
        private System.Windows.Forms.TextBox textBox_Cod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource facultatiBindingSource;
        private Database1DataSetTableAdapters.FacultatiTableAdapter facultatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFacDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button stergere_Fac;
        private System.Windows.Forms.Button adaugare_Fac;
        private System.Windows.Forms.TextBox textBox_Id_Fac;
        private System.Windows.Forms.TextBox textBox_Cod_Fac;
        private System.Windows.Forms.TextBox textBox_Nume_Fac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

