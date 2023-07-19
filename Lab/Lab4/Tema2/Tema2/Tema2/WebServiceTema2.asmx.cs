using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Tema2
{
    /// <summary>
    /// Summary description for WebServiceTema2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceTema2 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int AddToBiblioteca(int id, string title, string author, string editura, int yearPublished)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\II\Lab\Lab4\Tema2\ClientTema2\ClientTema2\DbTema2.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Biblioteca VALUES (@id, @title, @author, @editura, @year)");
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@editura", editura);
                command.Parameters.AddWithValue("@year", yearPublished);
                command.Connection = connection;
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowsAffected;
        }

        [WebMethod]
        public void DeleteFromBiblioteca(int id)
        {
            // Define the connection string for the database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\II\Lab\Lab4\Tema2\ClientTema2\ClientTema2\DbTema2.mdf;Integrated Security=True;Connect Timeout=30";

            // Create a SqlConnection object to connect to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Define the SQL command to delete data from the Biblioteca table
                string query = "DELETE FROM Biblioteca WHERE ID = @id";
                SqlCommand command = new SqlCommand(query, connection);

                // Add the ID parameter to the command
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    // Open the database connection
                    connection.Open();

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    throw new Exception("An error occurred while deleting data from the Biblioteca table", ex);
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }
            }
        }

        [WebMethod]
        public void ModifyBibliotecaData(int id, string title, string author, string editura, int year)
        {
            // Define the connection string for the database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\II\Lab\Lab4\Tema2\ClientTema2\ClientTema2\DbTema2.mdf;Integrated Security=True;Connect Timeout=30";

            // Create a SqlConnection object to connect to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Define the SQL command to update data in the Biblioteca table
                string query = "UPDATE Biblioteca SET Titlu = @title, Autor = @author, "
                    + "Editura = @editura, AnPublicare = @year WHERE ID = @id";
                SqlCommand command = new SqlCommand(query, connection);

                // Add the parameters to the command
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@editura", editura);
                command.Parameters.AddWithValue("@year", year);

                try
                {
                    // Open the database connection
                    connection.Open();

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    throw new Exception("An error occurred while modifying data in the Biblioteca table", ex);
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }
            }
        }
    }
}
