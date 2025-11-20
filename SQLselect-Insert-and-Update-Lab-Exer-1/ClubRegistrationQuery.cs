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
        public ClubRegistrationQuery()
        {
            // Initialize connection string
            connectionString = "Data Source=Danica-Reyes\\SQLEXPRESS;Initial Catalog=ClubDB;Integrated Security=True";

            // Initialize SQL Server connection objects
            sqlConnect = new SqlConnection(connectionString);

            //Instantiating data handling objects
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }
        //Creating a Display list method that returns a boolean value true
        public bool DisplayList()
        {
            //Declaring a string variable to hold the SQL query
            string ViewClubMembers = "SELECT StudentID, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";

            //Initializing previusly created SqlAdapter
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);

            //Using the given code on number 6 letter c
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;

            return true;
        }
        //Pasting the given code on number 8
        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID; 
            sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID; 
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID; 
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName; 
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName; 
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName; 
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age; 
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender; 
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open(); 
            sqlCommand.ExecuteNonQuery(); 
            sqlConnect.Close();
            return true;
        }
        //Creating a method to select StudentId and display it in the ComboBox
        public void IdSelect(ComboBox cb)
        {
            string selectId = "SELECT StudentId FROM ClubMembers ";
            sqlCommand = new SqlCommand(selectId, sqlConnect);
            sqlCommand.CommandText = selectId;
            sqlConnect.Open();
            sqlReader = sqlCommand.ExecuteReader();
            while (sqlReader.Read())
            {
                cb.Items.Add(sqlReader["StudentId"].ToString());
            }
            sqlConnect.Close();
        }
        //Creating a method to auto search the selected StudentId from the ComboBox
        public void AutoSearch(TextBox tbFirstName, TextBox tbMiddleName, TextBox tbLastName, TextBox tbAge, ComboBox cbGender, ComboBox cbProgram, int ID)
        {
            string selectId = "SELECT FirstName,MiddleName,LastName,Age,Gender,Program FROM ClubMembers WHERE StudentId = @ID ";
            sqlCommand = new SqlCommand(selectId, sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.CommandText = selectId;
            sqlConnect.Open();
            sqlReader = sqlCommand.ExecuteReader();
            while (sqlReader.Read())
            {
                tbFirstName.Text = (sqlReader["FirstName"].ToString());
                tbMiddleName.Text = (sqlReader["MiddleName"].ToString());
                tbLastName.Text = (sqlReader["LastName"].ToString());
                tbAge.Text = (sqlReader["Age"].ToString());
                cbGender.Text = (sqlReader["Gender"].ToString());
                cbProgram.Text = (sqlReader["Program"].ToString());
            }
            sqlConnect.Close();
        }
        //Creating a method to update the selected StudentId
        public void UpdateStudent(long StudentID, string FirstName, string
                                MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("UPDATE ClubMembers SET FirstName = @FirstName,MiddleName = @MiddleName,LastName= @LastName,Age= @Age,Gender= @Gender,Program= @Program WHERE StudentId = @StudentID", sqlConnect);

            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }
    }
}
