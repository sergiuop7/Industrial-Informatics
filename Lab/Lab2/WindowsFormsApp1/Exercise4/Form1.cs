using Exercise4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Add("Ferrari");
            listBox1.Items.Add("Lamborghini");
            listBox1.Items.Add("BMW");
            listBox1.Items.Add("Audi");
            listBox1.Items.Add("Porsche");
            listBox1.Items.Add("Honda");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem)
            {
                case "Ferrari":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\WindowsFormsApp1\\Exercise4\\Cars\\Ferrari.jpeg");
                    break;
                case "Lamborghini":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\WindowsFormsApp1\\Exercise4\\Cars\\Lamborghini.jpeg");
                    break;
                case "BMW":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\WindowsFormsApp1\\Exercise4\\Cars\\BMW.jpeg");
                    break;
                case "Audi":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\WindowsFormsApp1\\Exercise4\\Cars\\Audi.jpeg");
                    break;
                case "Porsche":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\WindowsFormsApp1\\Exercise4\\Cars\\Porsche.jpeg");
                    break;
                case "Honda":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\WindowsFormsApp1\\Exercise4\\Cars\\Honda.jpeg");
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica primul grup de radioButton-uri
            string primulRadioButton = "";
            if (radioButton1.Checked)
            {
                primulRadioButton = "Ai selectat primul radioButton din primul grup si ";
            }
            else if (radioButton2.Checked)
            {
                primulRadioButton = "Ai selectat al doilea radioButton din primul grup si ";
            }
            else if (radioButton3.Checked)
            {
                primulRadioButton = "Ai selectat al treilea radioButton din primul grup si ";
            }
            else if (radioButton4.Checked)
            {
                primulRadioButton = "Ai selectat al patrulea radioButton din primul grup si ";
            }

            // Verifica al doilea grup de radioButton-uri
            string alDoileaRadioButton = "";
            if (radioButton5.Checked)
            {
                alDoileaRadioButton = "ai selectat primul radioButton din al doilea grup.";
            }
            else if (radioButton6.Checked)
            {
                alDoileaRadioButton = "ai selectat al doilea radioButton din al doilea grup.";
            }
            else if (radioButton7.Checked)
            {
                alDoileaRadioButton = "ai selectat al treilea radioButton din al doilea grup.";
            }
            else if (radioButton8.Checked)
            {
                alDoileaRadioButton = "ai selectat al patrulea radioButton din al doilea grup.";
            }

            //Afiseaza rezultatul intr-un MessageBox
            MessageBox.Show($"RadioButton-urile selectate:" + primulRadioButton + alDoileaRadioButton);

        }
    }
}
