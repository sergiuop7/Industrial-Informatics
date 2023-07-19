using ClientTema2.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ClientTema2
{
    public partial class Form1 : Form
    {

        SqlConnection myCon = new SqlConnection();
        DataSet dsBiblioteca;
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DbTema2.mdf;Integrated Security=True";
            myCon.Open();
            dsBiblioteca = new DataSet();
            SqlDataAdapter daBiblioteca = new SqlDataAdapter("SELECT * FROM Biblioteca", myCon);
            daBiblioteca.Fill(dsBiblioteca, "Biblioteca");
            foreach (DataRow dr in dsBiblioteca.Tables["Biblioteca"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString() + " - " + dr.ItemArray.GetValue(2).ToString();
                listBox_Biblioteca.Items.Add(name);
            }
            myCon.Close();
        }

        ClientTema2.ServiceReference1.WebServiceTema2SoapClient service = new ClientTema2.ServiceReference1.WebServiceTema2SoapClient();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox_Biblioteca.SelectedItem)
            {
                case "Maitreyi - Mircea Eliade":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab4\\Tema2\\Tema2\\Carti\\Maitreyi.jpg");
                    break;
                case "Cel mai iubit dintre pamanteni - Marin Preda":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab4\\Tema2\\Tema2\\Carti\\CMIDP.jpg");
                    break;
                case "Enigma Otiliei - George Calinescu":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab4\\Tema2\\Tema2\\Carti\\Enigma Otiliei.jpg");
                    break;
                case "Morometii vol1 - Marin Preda":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab4\\Tema2\\Tema2\\Carti\\Morometii.jpg");
                    break;
                case "Ultima noapte de dragoste, intaia noapte de razboi - Camil Petrescu":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab4\\Tema2\\Tema2\\Carti\\UNDDINDR.jpg");
                    break;
                case "Invitatia la vals - Mihail Drumes":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab4\\Tema2\\Tema2\\Carti\\Invitatia la vals.jpg");
                    break;
                case "Patul lui Procust - Camil Petrescu":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab4\\Tema2\\Tema2\\Carti\\Patul lui Procust.jpg");
                    break;
                case "Panza de paianjen - Cella Serghi":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab4\\Tema2\\Tema2\\Carti\\Morometii.jpg");
                    break;
                case "Romanul adolescentului miop - Mircea Eliade":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab4\\Tema2\\Tema2\\Carti\\Romanul adolescentului miop.jpg");
                    break;
                case "Adam si Eva - Liviu Rebreanu":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab4\\Tema2\\Tema2\\Carti\\Adam si Eva.jpg");
                    break;
                case "Amintiri din copilarie - Ion Creanga":
                    pictureBox1.BackgroundImage = Image.FromFile("D:\\II\\Lab\\Lab4\\Tema2\\Tema2\\Carti\\Amintiri din copilarie.jpg");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowsAffected = service.AddToBiblioteca(int.Parse(textBox_Id.Text), textBox_Title.Text, textBox_Author.Text, textBox_Editura.Text, int.Parse(textBox_Year.Text));
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data added to Biblioteca table.");
            }
            else
            {
                MessageBox.Show("Failed to add data to Biblioteca table.");
            }

            dsBiblioteca.Clear();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Biblioteca", myCon);
            daUniv.Fill(dsBiblioteca, "Biblioteca");

            // Afisam numele noii carti adaugate in biblioteca
            string numeCarteNoua = textBox_Title.Text + " - " + textBox_Author.Text;
            listBox_Biblioteca.Items.Add(numeCarteNoua);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the ID of the record to delete from the user input
            int id = int.Parse(textBox_Id.Text);

            try
            {
                // Create a new instance of the web service client
                WebServiceTema2SoapClient service = new WebServiceTema2SoapClient();

                // Call the DeleteFromBiblioteca web method to delete the record with the specified ID
                service.DeleteFromBiblioteca(id);

                // Display a success message to the user
                MessageBox.Show("Record deleted successfully.");
            }
            catch (Exception ex)
            {
                // Handle any exceptions and display an error message to the user
                MessageBox.Show("An error occurred while deleting the record: " + ex.Message);
            }
             
            dsBiblioteca.Clear();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Biblioteca", myCon);
            daUniv.Fill(dsBiblioteca, "Biblioteca");

            // Stergem detaliile cartii cu id-ul din textbox din biblioteca
            string numeCarteStearsa = textBox_Title.Text + " - " + textBox_Author.Text;
            listBox_Biblioteca.Items.Remove(numeCarteStearsa);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get the ID of the record to update from the user input
            int id = int.Parse(textBox_Id.Text);

            // Get the new information from the user input
            string title = textBox_Title.Text;
            string author = textBox_Author.Text;
            string editura = textBox_Editura.Text;
            int year = int.Parse(textBox_Year.Text);

            try
            {
                // Create a new instance of the web service client
                WebServiceTema2SoapClient service = new WebServiceTema2SoapClient();

                // Call the ModifyInBiblioteca web method to update the record with the specified ID
                service.ModifyBibliotecaData(id, title, author, editura, year);

                // Display a success message to the user
                MessageBox.Show("Record updated successfully.");
            }
            catch (Exception ex)
            {
                // Handle any exceptions and display an error message to the user
                MessageBox.Show("An error occurred while updating the record: " + ex.Message);
            }

            dsBiblioteca.Clear();
            SqlDataAdapter daBiblioteca = new SqlDataAdapter("SELECT * FROM Biblioteca", myCon);
            daBiblioteca.Fill(dsBiblioteca, "Biblioteca");

            // Update the listbox with the new data
            listBox_Biblioteca.Items.Clear();
            foreach (DataRow dr in dsBiblioteca.Tables["Biblioteca"].Rows)
            {
                listBox_Biblioteca.Items.Add(dr.ItemArray.GetValue(1).ToString() + " - " + dr.ItemArray.GetValue(2).ToString());
            }
        }
    }
}
