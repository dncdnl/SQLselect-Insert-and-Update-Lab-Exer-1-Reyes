using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

        }

    }
}
