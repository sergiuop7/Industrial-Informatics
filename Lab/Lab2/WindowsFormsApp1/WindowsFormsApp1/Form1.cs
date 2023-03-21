using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                Rezultat.Text = (Convert.ToDouble(nr1.Text) + Convert.ToDouble(nr2.Text)).ToString(); 
            } catch (Exception ex) 
                {
                    MessageBox.Show("Error!" + ex); 
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Rezultat.Text = (Convert.ToDouble(nr1.Text) - Convert.ToDouble(nr2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Rezultat.Text = (Convert.ToDouble(nr1.Text) * Convert.ToDouble(nr2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Rezultat.Text = (Convert.ToDouble(nr1.Text) / Convert.ToDouble(nr2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rezultat.Text = "";
            nr1.Text = ""; 
            nr2.Text = "";
        }
    }
}
