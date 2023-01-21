namespace DITEC
{
    partial class FormRegister
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
            this.labelSkillsLogo = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.groupBoxStudentRegistration = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.groupBoxCdetails = new System.Windows.Forms.GroupBox();
            this.textBoxHome = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxBasicInf = new System.Windows.Forms.GroupBox();
            this.dateTimePickerBdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRegNo = new System.Windows.Forms.TextBox();
            this.labelRegNo = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxStudentRegistration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxCdetails.SuspendLayout();
            this.groupBoxBasicInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSkillsLogo
            // 
            this.labelSkillsLogo.AutoSize = true;
            this.labelSkillsLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSkillsLogo.Location = new System.Drawing.Point(232, 9);
            this.labelSkillsLogo.Name = "labelSkillsLogo";
            this.labelSkillsLogo.Size = new System.Drawing.Size(228, 32);
            this.labelSkillsLogo.TabIndex = 5;
            this.labelSkillsLogo.Text = "Skills International";
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(54, 17);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(42, 15);
            this.linkLabelLogout.TabIndex = 6;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_Clicked);
            // 
            // groupBoxStudentRegistration
            // 
            this.groupBoxStudentRegistration.Controls.Add(this.groupBox1);
            this.groupBoxStudentRegistration.Controls.Add(this.groupBoxCdetails);
            this.groupBoxStudentRegistration.Controls.Add(this.groupBoxBasicInf);
            this.groupBoxStudentRegistration.Controls.Add(this.textBoxRegNo);
            this.groupBoxStudentRegistration.Controls.Add(this.labelRegNo);
            this.groupBoxStudentRegistration.Location = new System.Drawing.Point(12, 44);
            this.groupBoxStudentRegistration.Name = "groupBoxStudentRegistration";
            this.groupBoxStudentRegistration.Size = new System.Drawing.Size(565, 561);
            this.groupBoxStudentRegistration.TabIndex = 7;
            this.groupBoxStudentRegistration.TabStop = false;
            this.groupBoxStudentRegistration.Text = "Student Registration";
            this.groupBoxStudentRegistration.Enter += new System.EventHandler(this.groupBoxStudentRegistration_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxNIC);
            this.groupBox1.Controls.Add(this.textBoxPname);
            this.groupBox1.Location = new System.Drawing.Point(26, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parent details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Contact Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "NIC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Parent Name";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(115, 92);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(145, 23);
            this.textBoxContact.TabIndex = 1;
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.Location = new System.Drawing.Point(115, 59);
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(144, 23);
            this.textBoxNIC.TabIndex = 1;
            // 
            // textBoxPname
            // 
            this.textBoxPname.Location = new System.Drawing.Point(115, 26);
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(389, 23);
            this.textBoxPname.TabIndex = 1;
            // 
            // groupBoxCdetails
            // 
            this.groupBoxCdetails.Controls.Add(this.textBoxHome);
            this.groupBoxCdetails.Controls.Add(this.textBoxMobile);
            this.groupBoxCdetails.Controls.Add(this.textBoxEmail);
            this.groupBoxCdetails.Controls.Add(this.textBoxAddress);
            this.groupBoxCdetails.Controls.Add(this.label8);
            this.groupBoxCdetails.Controls.Add(this.label7);
            this.groupBoxCdetails.Controls.Add(this.label6);
            this.groupBoxCdetails.Controls.Add(this.label5);
            this.groupBoxCdetails.Location = new System.Drawing.Point(22, 234);
            this.groupBoxCdetails.Name = "groupBoxCdetails";
            this.groupBoxCdetails.Size = new System.Drawing.Size(523, 162);
            this.groupBoxCdetails.TabIndex = 4;
            this.groupBoxCdetails.TabStop = false;
            this.groupBoxCdetails.Text = "Contact Details";
            // 
            // textBoxHome
            // 
            this.textBoxHome.Location = new System.Drawing.Point(366, 126);
            this.textBoxHome.Name = "textBoxHome";
            this.textBoxHome.Size = new System.Drawing.Size(144, 23);
            this.textBoxHome.TabIndex = 1;
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(119, 124);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(144, 23);
            this.textBoxMobile.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(118, 91);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(392, 23);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(118, 26);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(392, 56);
            this.textBoxAddress.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Home Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mobile Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            // 
            // groupBoxBasicInf
            // 
            this.groupBoxBasicInf.Controls.Add(this.dateTimePickerBdate);
            this.groupBoxBasicInf.Controls.Add(this.label4);
            this.groupBoxBasicInf.Controls.Add(this.label3);
            this.groupBoxBasicInf.Controls.Add(this.radioButtonFemale);
            this.groupBoxBasicInf.Controls.Add(this.radioButtonMale);
            this.groupBoxBasicInf.Controls.Add(this.label2);
            this.groupBoxBasicInf.Controls.Add(this.textBoxLname);
            this.groupBoxBasicInf.Controls.Add(this.textBoxFname);
            this.groupBoxBasicInf.Controls.Add(this.label1);
            this.groupBoxBasicInf.Location = new System.Drawing.Point(18, 64);
            this.groupBoxBasicInf.Name = "groupBoxBasicInf";
            this.groupBoxBasicInf.Size = new System.Drawing.Size(527, 158);
            this.groupBoxBasicInf.TabIndex = 3;
            this.groupBoxBasicInf.TabStop = false;
            this.groupBoxBasicInf.Text = "BasicInfo";
            // 
            // dateTimePickerBdate
            // 
            this.dateTimePickerBdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBdate.Location = new System.Drawing.Point(122, 91);
            this.dateTimePickerBdate.Name = "dateTimePickerBdate";
            this.dateTimePickerBdate.Size = new System.Drawing.Size(145, 23);
            this.dateTimePickerBdate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date of Birth";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(225, 125);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(63, 19);
            this.radioButtonFemale.TabIndex = 2;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(122, 125);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(51, 19);
            this.radioButtonMale.TabIndex = 2;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(122, 58);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(392, 23);
            this.textBoxLname.TabIndex = 1;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(122, 25);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(392, 23);
            this.textBoxFname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // textBoxRegNo
            // 
            this.textBoxRegNo.AcceptsReturn = true;
            this.textBoxRegNo.AcceptsTab = true;
            this.textBoxRegNo.AllowDrop = true;
            this.textBoxRegNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxRegNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxRegNo.Location = new System.Drawing.Point(142, 26);
            this.textBoxRegNo.Name = "textBoxRegNo";
            this.textBoxRegNo.Size = new System.Drawing.Size(175, 23);
            this.textBoxRegNo.TabIndex = 1;
            this.textBoxRegNo.TextChanged += new System.EventHandler(this.textBoxRegNo_TextChanged);
            // 
            // labelRegNo
            // 
            this.labelRegNo.AutoSize = true;
            this.labelRegNo.Location = new System.Drawing.Point(38, 29);
            this.labelRegNo.Name = "labelRegNo";
            this.labelRegNo.Size = new System.Drawing.Size(46, 15);
            this.labelRegNo.TabIndex = 0;
            this.labelRegNo.Text = "Reg No";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.Location = new System.Drawing.Point(12, 644);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(84, 29);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.Location = new System.Drawing.Point(102, 644);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 29);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(492, 644);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(84, 29);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(402, 644);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(84, 29);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 680);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.groupBoxStudentRegistration);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.labelSkillsLogo);
            this.Name = "FormRegister";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.groupBoxStudentRegistration.ResumeLayout(false);
            this.groupBoxStudentRegistration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxCdetails.ResumeLayout(false);
            this.groupBoxCdetails.PerformLayout();
            this.groupBoxBasicInf.ResumeLayout(false);
            this.groupBoxBasicInf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSkillsLogo;
        private LinkLabel linkLabelLogout;
        private GroupBox groupBoxStudentRegistration;
        private Button buttonRegister;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonClear;
        private DateTimePicker dateTimePickerBdate;
        private GroupBox groupBoxBasicInf;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton radioButtonMale;
        private TextBox textBoxRegNo;
        private Label labelRegNo;
        private RadioButton radioButtonFemale;
        private TextBox textBoxLname;
        private TextBox textBoxFname;
        private GroupBox groupBoxCdetails;
        private TextBox textBoxAddress;
        private Label label5;
        private TextBox textBoxMobile;
        private TextBox textBoxEmail;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox groupBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBoxContact;
        private TextBox textBoxNIC;
        private TextBox textBoxPname;
        private TextBox textBoxHome;
    }
}