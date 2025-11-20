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
    public partial class FrmUpdateMember : Form
    {
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
    }
}
