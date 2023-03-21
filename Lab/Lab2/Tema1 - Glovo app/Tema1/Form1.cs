using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1
{
    public partial class FormGlovo : Form
    {
        public FormGlovo()
        {
            InitializeComponent();
            foreach (var line in File.ReadAllLines("D:\\II\\Lab\\Lab2\\Tema1\\Tema1\\mancare.txt"))
            {
                listBox1.Items.Add(line);
            }

            foreach (var line in File.ReadAllLines("D:\\II\\Lab\\Lab2\\Tema1\\Tema1\\bauturi.txt"))
            {
                listBox2.Items.Add(line);
            }
        }

        private void FormListaDeCumparaturi_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem)
            {
                case "Burger":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\Tema1\\Tema1\\Mancare\\Burger.jpeg");
                    break;
                case "Pizza":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\Tema1\\Tema1\\Mancare\\Pizza.jpeg");
                    break;
                case "Shaorma":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\Tema1\\Tema1\\Mancare\\Shaorma.jpeg");
                    break;
                case "Salata":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\Tema1\\Tema1\\Mancare\\Salata.jpeg");
                    break;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox2.SelectedItem)
            {
                case "Dorna":
                    pictureBox2.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\Tema1\\Tema1\\Bauturi\\Dorna.jpeg");
                    break;
                case "CocaCola":
                    pictureBox2.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\Tema1\\Tema1\\Bauturi\\CocaCola.jpeg");
                    break;
                case "Heineken":
                    pictureBox2.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\Tema1\\Tema1\\Bauturi\\Heineken.jpeg");
                    break;
                case "Lipton":
                    pictureBox2.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab2\\Tema1\\Tema1\\Bauturi\\Lipton.jpeg");
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double primaOptiune = 0, aDouaOptiune = 0;
            // Verifica primul grup de radioButton-uri
            string primulRadioButton = "";
            if (radioButton1.Checked)
            {
                primaOptiune = Convert.ToDouble(textBox1.Text);
                primulRadioButton = "Burger si ";
            }
            else if (radioButton2.Checked)
            {
                primaOptiune = Convert.ToDouble(textBox2.Text);
                primulRadioButton = "Pizza si ";
            }
            else if (radioButton3.Checked)
            {
                primaOptiune = Convert.ToDouble(textBox3.Text);
                primulRadioButton = "Shaorma si ";
            }
            else if (radioButton7.Checked)
            {
                primaOptiune = Convert.ToDouble(textBox4.Text);
                primulRadioButton = "Salata si ";
            }

            // Verifica al doilea grup de radioButton-uri
            string alDoileaRadioButton = "";
            if (radioButton4.Checked)
            {
                aDouaOptiune = Convert.ToDouble(textBox8.Text);
                alDoileaRadioButton = "apa Dorna a fost plasata.";
            }
            else if (radioButton5.Checked)
            {
                aDouaOptiune = Convert.ToDouble(textBox7.Text);
                alDoileaRadioButton = "suc CocaCola a fost plasata.";
            }
            else if (radioButton6.Checked)
            {
                aDouaOptiune = Convert.ToDouble(textBox6.Text);
                alDoileaRadioButton = "bere Heineken a fost plasata.";
            }
            else if (radioButton8.Checked)
            {
                aDouaOptiune = Convert.ToDouble(textBox5.Text);
                alDoileaRadioButton = "ceai Lipton a fost plasata.";
            }

            double rezultat = primaOptiune + aDouaOptiune;
            //Afiseaza rezultatul intr-un MessageBox
            MessageBox.Show("Comanda ta: " + primulRadioButton + alDoileaRadioButton + " Totalul de plata este de " + rezultat + " RON");

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
