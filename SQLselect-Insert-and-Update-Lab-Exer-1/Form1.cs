using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private long StudentID;

        //creating a method 
        public void RefreshListOfClubMembers()
        {
            //Instantiating the ClubRegistrationQuery class
            clubRegistrationQuery.DisplayList();

            //Binding the dataGridView DataSource to the bindingSource
            dataGridView.DataSource = clubRegistrationQuery.bindingSource;

        }
    }
}
