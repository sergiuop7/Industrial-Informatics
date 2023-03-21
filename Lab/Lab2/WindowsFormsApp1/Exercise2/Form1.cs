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

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var line in File.ReadAllLines("D:\\II\\Lab\\Lab2\\WindowsFormsApp1\\Exercise2\\fisier.txt"))
            {
                listBox1.Items.Add(line);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            int i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
