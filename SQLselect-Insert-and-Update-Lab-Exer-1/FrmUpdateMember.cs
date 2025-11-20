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
            clubRegistrationQuery.RegisterStudent(cbStuNO);
        }

    }

}

