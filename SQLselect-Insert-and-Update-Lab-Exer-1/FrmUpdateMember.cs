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
        //Instantiating the ClubRegistrationQuery class
        ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();

        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            //Calling the IdSelect method to populate the cbStuNO ComboBox
            clubRegistrationQuery.IdSelect(cbStuNO);
        }

        //Creating an event handler for the Confirm button
        private void butConfirm_Click(object sender, EventArgs e)
        {
            clubRegistrationQuery.UpdateStudent(Convert.ToInt32(cbStuNO.Text), tbFN2.Text, tbLN2.Text, tbMN2.Text, Convert.ToInt32(tbAge2.Text), cbGender2.Text, cbProgram2.Text);
            FrmClubRegistration frmClubRegistration = new FrmClubRegistration();
            frmClubRegistration.RefreshListOfClubMembers();
        }
    }

}

