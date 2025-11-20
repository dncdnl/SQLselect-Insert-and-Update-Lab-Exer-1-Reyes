using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLselect_Insert_and_Update_Lab_Exer_1
{
    internal class ClubRegistrationQuery
    {
        // SQL Server connection objects
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        // Data handling objects
        public DataTable dataTable;
        public BindingSource bindingSource;

        // Connection string to connect to the SQL Server database
        private string connectionString;

        // Constructor to initialize the connection string and other objects
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;

        //Constructor class
        ClubRegistrationQuery()
        {
            // Initialize connection string
            connectionString = "Data Source=Danica-Reyes\\SQLEXPRESS;Initial Catalog=ClubDB;Integrated Security=True;Trust Server Certificate=True";

            // Initialize SQL Server connection objects
            new SqlConnection(connectionString);

            //Instantiating data handling objects
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }
        //Creating a Display list method that returns a boolean value true
        public bool DisplayList()
        {
            //Declaring a string variable to hold the SQL query
            string ViewClubMembers = "SELECT @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program FROM ClubMembers";
        }
    }
}
