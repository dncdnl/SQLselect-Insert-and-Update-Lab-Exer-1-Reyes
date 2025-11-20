using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLselect_Insert_and_Update_Lab_Exer_1
{
    public partial class FrmUpdateMember : Form
    {
        // SQL Server connection objects
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        


        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            //Declaring variables
            long StudentID = long.Parse(cbStuNO.Text);
            string FirstName = tbFN2.Text;
            string MiddleName = tbMN2.Text;
            string LastName = tbLN2.Text;
            int Age = int.Parse(tbAge2.Text);
            string Gender = cbGender2.Text;
            string Program = cbProgram2.Text;

            //Instantiating the ClubRegistrationQuery class
            ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        }
        //Creating the UpdateStudent method that returns a boolean value true
        public bool UpdateStudent(long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            
                string query = "UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program WHERE StudentID = @StudentID";
                sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
                sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                return true;
            
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            //Initializing the SQL Server connection object with the connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ClubDB.mdf;Integrated Security=True;";
            sqlConnection = new SqlConnection(connectionString);
        }
    }
}
