using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                Rezultat.Text = (Convert.ToDouble(nr1.Text) + Convert.ToDouble(nr2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
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

        private void nr1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
