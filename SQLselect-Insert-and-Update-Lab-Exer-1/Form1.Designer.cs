namespace SQLselect_Insert_and_Update_Lab_Exer_1
{
    partial class FrmClubRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStuID = new System.Windows.Forms.Label();
            this.tbStuNo = new System.Windows.Forms.TextBox();
            this.lblLastN = new System.Windows.Forms.Label();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lblFN = new System.Windows.Forms.Label();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.lblMN = new System.Windows.Forms.Label();
            this.tbMN = new System.Windows.Forms.TextBox();
            this.panelLOCM = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblLOCM = new System.Windows.Forms.Label();
            this.butRegister = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butRefresh = new System.Windows.Forms.Button();
            this.panelLOCM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuID.Location = new System.Drawing.Point(13, 13);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(103, 15);
            this.lblStuID.TabIndex = 0;
            this.lblStuID.Text = "Student ID: ";
            // 
            // tbStuNo
            // 
            this.tbStuNo.Location = new System.Drawing.Point(16, 31);
            this.tbStuNo.Name = "tbStuNo";
            this.tbStuNo.Size = new System.Drawing.Size(154, 20);
            this.tbStuNo.TabIndex = 1;
            // 
            // lblLastN
            // 
            this.lblLastN.AutoSize = true;
            this.lblLastN.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastN.Location = new System.Drawing.Point(12, 67);
            this.lblLastN.Name = "lblLastN";
            this.lblLastN.Size = new System.Drawing.Size(95, 15);
            this.lblLastN.TabIndex = 2;
            this.lblLastN.Text = "Last Name: ";
            // 
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(16, 85);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(154, 20);
            this.tbLN.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(12, 118);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(47, 15);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age: ";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(16, 136);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(154, 20);
            this.tbAge.TabIndex = 5;
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(205, 67);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(103, 15);
            this.lblFN.TabIndex = 6;
            this.lblFN.Text = "First Name: ";
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(208, 85);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(154, 20);
            this.tbFN.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(205, 118);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(71, 15);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender: ";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cbGender.Location = new System.Drawing.Point(208, 134);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 9;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(385, 13);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(79, 15);
            this.lblProgram.TabIndex = 10;
            this.lblProgram.Text = "Program: ";
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "Information & Communications Technology",
            "BS in Information Technology (BSIT)",
            "BS in Computer Science (BSCS)",
            "BS in Information Systems (BSIS)",
            "",
            "Business & Management",
            "BS in Business Administration (BSBA)",
            "BS in Accountancy (BSA)",
            "BS in Accounting Information System (BSAIS)",
            "BS in Management Accounting (BSMA)",
            "BS in Retail Technology and Consumer Science (BSRTCS)",
            "2-yr. Associate in Retail Technology (ART)",
            "",
            "Hospitality Management",
            "BS in Hospitality Management (BSHM)",
            "BS in Culinary Management (BSCM)",
            "3-yr. Hotel and Restaurant Administration (HRA)",
            "2-yr. Hospitality and Restaurant Services (HRS)",
            "",
            "Tourism Management",
            "BS in Tourism Management (BSTM)",
            "",
            "Engineering",
            "BS in Computer Engineering (BSCpE)",
            "",
            "Arts & Sciences",
            "Bachelor of Arts in Psychology",
            "Bachelor of Multimedia Arts (BMMA)",
            "BA in Communication (BACOMM)",
            "",
            "Maritime",
            "Bachelor of Science in Marine Transportation (BSMT)",
            "Bachelor of Science in Marine Engineering (BSMarE)",
            "Bachelor of Science in Naval Architecture and Marine Engineering (BSNAME)",
            "",
            "Criminal Justice Education",
            "Bachelor of Science in Criminology"});
            this.cbProgram.Location = new System.Drawing.Point(388, 29);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(292, 21);
            this.cbProgram.TabIndex = 11;
            // 
            // lblMN
            // 
            this.lblMN.AutoSize = true;
            this.lblMN.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMN.Location = new System.Drawing.Point(386, 67);
            this.lblMN.Name = "lblMN";
            this.lblMN.Size = new System.Drawing.Size(111, 15);
            this.lblMN.TabIndex = 12;
            this.lblMN.Text = "Middle Name: ";
            // 
            // tbMN
            // 
            this.tbMN.Location = new System.Drawing.Point(388, 85);
            this.tbMN.Name = "tbMN";
            this.tbMN.Size = new System.Drawing.Size(154, 20);
            this.tbMN.TabIndex = 13;
            // 
            // panelLOCM
            // 
            this.panelLOCM.Controls.Add(this.dataGridView);
            this.panelLOCM.Location = new System.Drawing.Point(16, 211);
            this.panelLOCM.Name = "panelLOCM";
            this.panelLOCM.Size = new System.Drawing.Size(629, 227);
            this.panelLOCM.TabIndex = 14;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(629, 227);
            this.dataGridView.TabIndex = 0;
            // 
            // lblLOCM
            // 
            this.lblLOCM.AutoSize = true;
            this.lblLOCM.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOCM.Location = new System.Drawing.Point(14, 183);
            this.lblLOCM.Name = "lblLOCM";
            this.lblLOCM.Size = new System.Drawing.Size(241, 22);
            this.lblLOCM.TabIndex = 15;
            this.lblLOCM.Text = "List of Club Members:";
            // 
            // butRegister
            // 
            this.butRegister.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegister.Location = new System.Drawing.Point(690, 20);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(99, 37);
            this.butRegister.TabIndex = 16;
            this.butRegister.Text = "Register";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.Location = new System.Drawing.Point(689, 63);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(99, 37);
            this.butUpdate.TabIndex = 17;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            // 
            // butRefresh
            // 
            this.butRefresh.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRefresh.Location = new System.Drawing.Point(690, 211);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(99, 37);
            this.butRefresh.TabIndex = 18;
            this.butRefresh.Text = "Refresh";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // FrmClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butRegister);
            this.Controls.Add(this.lblLOCM);
            this.Controls.Add(this.panelLOCM);
            this.Controls.Add(this.tbMN);
            this.Controls.Add(this.lblMN);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.tbLN);
            this.Controls.Add(this.lblLastN);
            this.Controls.Add(this.tbStuNo);
            this.Controls.Add(this.lblStuID);
            this.Name = "FrmClubRegistration";
            this.Text = "frmClubRegistration";
            this.Load += new System.EventHandler(this.FrmClubRegistration_Load);
            this.panelLOCM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuID;
        private System.Windows.Forms.TextBox tbStuNo;
        private System.Windows.Forms.Label lblLastN;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Label lblMN;
        private System.Windows.Forms.TextBox tbMN;
        private System.Windows.Forms.Panel panelLOCM;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblLOCM;
        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butRefresh;
    }
}

