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

        WindowsFormsApp1.ServiceReference1.WebService1SoapClient service = new WindowsFormsApp1.ServiceReference1.WebService1SoapClient();
        private void button_LIstDisplay_Click(object sender, EventArgs e)
        {
       
            foreach (string element in service.AfisareLista())
            {
                listBox1.Items.Add(element);
            }

        }

        private void textBox_Date_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_FtoC_Click(object sender, EventArgs e)
        {
            // Convert the text from the Fahrenheit textbox to a float
            float fahrenheit = float.Parse(textBox_tempF.Text);

            // Call the web service to convert the Fahrenheit temperature to Celsius
            float celsius = service.FahrenheitToCelsius(fahrenheit);

            // Display the result in the Celsius textbox
            textBox_Rezultat.Text = celsius.ToString();
        }

        private void button_Date_Click(object sender, EventArgs e)
        {
                // Call the web service to get the current date and time
                string dateTimeString = service.GetDateTime();

                // Update the text of the read-only textbox to display the date and time
                textBox_Date.Text = dateTimeString;
        }

        private void button_CtoF_Click(object sender, EventArgs e)
        {
            // Convert the text from the Fahrenheit textbox to a float
            float celsius = float.Parse(textBox_tempC.Text);

            // Call the web service to convert the Fahrenheit temperature to Celsius
            float fahrenheit = service.CelsiusToFahrenheit(celsius);

            // Display the result in the Celsius textbox
            textBox_Rezultat.Text = fahrenheit.ToString();
        }

        private void textBox_Conversie_TextChanged(object sender, EventArgs e)
        {

        }

        private void testBox_Euro_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Try to parse the text from the Euro textbox to a float
            if (float.TryParse(textBox_Conversie.Text, out float euro))
            {
                // Call the web service to convert the Euro amount to Lei
                float ron = service.ConvertEuroToLei(euro);

                // Display the result in the Lei textbox
                testBox_Euro.Text = ron.ToString();
            }
            else
            {
                // If the text in the Euro textbox is not a valid float, display an error message
                MessageBox.Show("Invalid Euro amount");
            }
        }
    }
}
