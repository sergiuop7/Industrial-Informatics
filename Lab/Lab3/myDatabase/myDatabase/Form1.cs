using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace myDatabase
{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv; 
        DataSet dsFac;
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent(); 
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsUniv = new DataSet();
            dsFac = new DataSet();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon); 
            daFac.Fill(dsFac, "Facultati");
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox_Univ.Items.Add(name); 
            }
            myCon.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Fac.Items.Clear(); 
            textBox_City.Clear();
            int code = 0; 
            String UnivSelected = listBox_Univ.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString()) 
                {
                    textBox_City.Text = dr.ItemArray.GetValue(2).ToString(); 
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    textBox_CodeUniv.Text = code.ToString();
                }
            }
            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1))) 
                { 
                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBox_Fac.Items.Add(nameFac); 
                } 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCon.Open();

            string insertQuery = "INSERT INTO Universitati (Id, NameUniv, City, Code) VALUES " +
            "('" + textBox_Id.Text + "', '" + textBox_NumeUniv.Text + "', '" +
            textBox_Oras.Text + "', '" + textBox_Cod.Text + "')";

            // Cream un nou obiect SqlCommand cu interogarea SQL si conexiunea noastra
            SqlCommand cmd = new SqlCommand(insertQuery, myCon);

            // Executam interogarea
            cmd.ExecuteNonQuery();

            // Inchidem conexiunea cu baza de date
            myCon.Close();

            // Actualizam dataset-ul cu noile date inserate
            dsUniv.Clear();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");

            // Afisam numele noii universitati adaugate in lista de universitati
            string numeUniv = textBox_NumeUniv.Text;
            listBox_Univ.Items.Add(numeUniv);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myCon.Open();

            string deleteQuery = "DELETE FROM Universitati WHERE CAST(NameUniv AS varchar(MAX)) = '" + textBox_NumeUniv.Text + "'";

            // Cream un nou obiect SqlCommand cu interogarea SQL si conexiunea noastra
            SqlCommand cmd = new SqlCommand(deleteQuery, myCon);

            // Executam interogarea
            cmd.ExecuteNonQuery();
           
            // Inchidem conexiunea cu baza de date
            myCon.Close();

            // Actualizam dataset-ul cu noile date inserate
            dsUniv.Clear();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");

            string numeUniv = textBox_NumeUniv.Text;
            listBox_Univ.Items.Remove(numeUniv);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes
            string id = textBox_Id.Text;
            string nameUniv = textBox_NumeUniv.Text;
            string city = textBox_Oras.Text;
            string code = textBox_Cod.Text;

            // Create the update query
            string updateQuery = "UPDATE Universitati SET NameUniv='" + nameUniv + "', City='" + city + "', Code='" + code + "' WHERE Id='" + id + "'";

            // Open the connection
            myCon.Open();

            // Create a new SqlCommand with the update query and connection
            SqlCommand cmd = new SqlCommand(updateQuery, myCon);

            // Execute the update query
            cmd.ExecuteNonQuery();

            // Close the connection
            myCon.Close();

            // Update the listbox with the new name of the university
            dsUniv.Clear();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");

            // Update the listbox with the new data
            listBox_Univ.Items.Clear();
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                listBox_Univ.Items.Add(dr.ItemArray.GetValue(1).ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Facultati' table. You can move, or remove it, as needed.
            this.facultatiTableAdapter.Fill(this.database1DataSet.Facultati);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stergere_Fac_Click(object sender, EventArgs e)
        {
                if (dataGridView1.SelectedRows.Count > 0) // check if a row is selected
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index; // get the index of the selected row
                    dataGridView1.Rows.RemoveAt(rowIndex); // remove the row from the DataGridView
                    MessageBox.Show("Data Deleted Successfully");
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myCon.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Facultati values('" +
            Convert.ToInt32(textBox_Id_Fac.Text) + "','" + Convert.ToInt32(textBox_Cod_Fac.Text) + "','" +
            textBox_Nume_Fac.Text + "')", myCon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Added Successfully");
            myCon.Close();
            Display();
            Clear();
        }

        public void Display()
        {
            myCon.Open();
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            DataTable dtFac = new DataTable();
            daFac.Fill(dtFac);
            dataGridView1.DataSource = dtFac;
            myCon.Close();
        }

        public void Clear()
        {
            textBox_Nume_Fac.Text = "";
            textBox_Id_Fac.Text = "";
            textBox_Cod_Fac.Text = "";
        }

    }

}
