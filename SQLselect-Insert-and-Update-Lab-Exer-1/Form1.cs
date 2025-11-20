using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLselect_Insert_and_Update_Lab_Exer_1
{
    public partial class FrmClubRegistration : Form
    {
        public FrmClubRegistration()
        {
            InitializeComponent();
        }
        //Declaring variables
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void butRefresh_Click(object sender, EventArgs e)
        {
            //Calling the RefreshListOfClubMembers method
            RefreshListOfClubMembers();
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            //Assigning values to the variables
            ID = RegistrationID();
            StudentID = long.Parse(tbStuNo.Text);
            FirstName = tbFN.Text;
            MiddleName = tbMN.Text;
            LastName = tbLN.Text;
            Age = int.Parse(tbAge.Text);
            Gender = cbGender.Text;
            Program = cbProgram.Text;
            //Calling the RegisterStudent method from the ClubRegistrationQuery class
            clubRegistrationQuery.RegisterStudent(ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program);
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            //Initalizing the ClubRegistrationQuery class
            clubRegistrationQuery = new ClubRegistrationQuery();

            //Calling the RefreshListOfClubMembers method
            RefreshListOfClubMembers();
        }

        private long StudentID;

        //creating a method 
        public void RefreshListOfClubMembers()
        {
            //Instantiating the ClubRegistrationQuery class
            clubRegistrationQuery.DisplayList();

            //Binding the dataGridView DataSource to the bindingSource
            dataGridView.DataSource = clubRegistrationQuery.bindingSource;

        }

        //Creating a method to generate RegistrationID
        public int RegistrationID()
        {
            count++;
            return count;
        }
    }
}
