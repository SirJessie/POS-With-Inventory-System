namespace Artisan_De_Fleur_Management_System
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.gbUserInformation = new System.Windows.Forms.GroupBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbUsertype = new System.Windows.Forms.ComboBox();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtbMI = new System.Windows.Forms.TextBox();
            this.lblMI = new System.Windows.Forms.Label();
            this.txtbLastname = new System.Windows.Forms.TextBox();
            this.txtbFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtbUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.gbUserAccount = new System.Windows.Forms.GroupBox();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.txtbConfirmpass = new System.Windows.Forms.TextBox();
            this.lblConfirmpass = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gbUserInformation.SuspendLayout();
            this.gbUserAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserInformation
            // 
            this.gbUserInformation.BackColor = System.Drawing.Color.Transparent;
            this.gbUserInformation.Controls.Add(this.dtpBirthday);
            this.gbUserInformation.Controls.Add(this.cmbGender);
            this.gbUserInformation.Controls.Add(this.cmbUsertype);
            this.gbUserInformation.Controls.Add(this.txtbAddress);
            this.gbUserInformation.Controls.Add(this.lblLastname);
            this.gbUserInformation.Controls.Add(this.lblAddress);
            this.gbUserInformation.Controls.Add(this.txtbPhone);
            this.gbUserInformation.Controls.Add(this.lblPhone);
            this.gbUserInformation.Controls.Add(this.lblBirthday);
            this.gbUserInformation.Controls.Add(this.lblGender);
            this.gbUserInformation.Controls.Add(this.txtbMI);
            this.gbUserInformation.Controls.Add(this.lblMI);
            this.gbUserInformation.Controls.Add(this.txtbLastname);
            this.gbUserInformation.Controls.Add(this.txtbFirstname);
            this.gbUserInformation.Controls.Add(this.lblFirstname);
            this.gbUserInformation.Controls.Add(this.lblUserType);
            this.gbUserInformation.Controls.Add(this.txtbUserID);
            this.gbUserInformation.Controls.Add(this.lblUserID);
            this.gbUserInformation.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gbUserInformation.Location = new System.Drawing.Point(12, 12);
            this.gbUserInformation.Name = "gbUserInformation";
            this.gbUserInformation.Size = new System.Drawing.Size(661, 280);
            this.gbUserInformation.TabIndex = 1;
            this.gbUserInformation.TabStop = false;
            this.gbUserInformation.Text = "USER INFORMATION";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Checked = false;
            this.dtpBirthday.CustomFormat = "";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(266, 124);
            this.dtpBirthday.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(116, 29);
            this.dtpBirthday.TabIndex = 6;
            this.dtpBirthday.Value = new System.DateTime(2022, 4, 21, 0, 0, 0, 0);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbGender.Location = new System.Drawing.Point(69, 123);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(107, 28);
            this.cmbGender.TabIndex = 5;
            // 
            // cmbUsertype
            // 
            this.cmbUsertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsertype.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsertype.FormattingEnabled = true;
            this.cmbUsertype.Items.AddRange(new object[] {
            "ADMIN",
            "CASHIER"});
            this.cmbUsertype.Location = new System.Drawing.Point(448, 25);
            this.cmbUsertype.Name = "cmbUsertype";
            this.cmbUsertype.Size = new System.Drawing.Size(203, 27);
            this.cmbUsertype.TabIndex = 1;
            this.cmbUsertype.SelectedIndexChanged += new System.EventHandler(this.cmbUsertype_SelectedIndexChanged);
            // 
            // txtbAddress
            // 
            this.txtbAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAddress.Location = new System.Drawing.Point(94, 168);
            this.txtbAddress.MaxLength = 255;
            this.txtbAddress.Multiline = true;
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(548, 101);
            this.txtbAddress.TabIndex = 8;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblLastname.Location = new System.Drawing.Point(237, 66);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(81, 20);
            this.lblLastname.TabIndex = 0;
            this.lblLastname.Text = "LASTNAME";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblAddress.Location = new System.Drawing.Point(7, 168);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 20);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "ADDRESS:";
            // 
            // txtbPhone
            // 
            this.txtbPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbPhone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPhone.Location = new System.Drawing.Point(486, 124);
            this.txtbPhone.MaxLength = 13;
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(165, 26);
            this.txtbPhone.TabIndex = 7;
            this.txtbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbPhone.TextChanged += new System.EventHandler(this.txtbPhone_TextChanged);
            this.txtbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPhone_KeyDown);
            this.txtbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPhone_KeyPress);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblPhone.Location = new System.Drawing.Point(388, 126);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(98, 20);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "CONTACT NO:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblBirthday.Location = new System.Drawing.Point(182, 126);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(78, 20);
            this.lblBirthday.TabIndex = 0;
            this.lblBirthday.Text = "BIRTHDAY:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblGender.Location = new System.Drawing.Point(7, 126);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 20);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "GENDER";
            // 
            // txtbMI
            // 
            this.txtbMI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbMI.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMI.Location = new System.Drawing.Point(452, 88);
            this.txtbMI.MaxLength = 50;
            this.txtbMI.Name = "txtbMI";
            this.txtbMI.Size = new System.Drawing.Size(199, 26);
            this.txtbMI.TabIndex = 4;
            this.txtbMI.TextChanged += new System.EventHandler(this.txtbMI_TextChanged);
            this.txtbMI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbMI_KeyDown);
            this.txtbMI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbMI_KeyPress);
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblMI.Location = new System.Drawing.Point(457, 65);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(97, 20);
            this.lblMI.TabIndex = 0;
            this.lblMI.Text = "MIDDLENAME";
            // 
            // txtbLastname
            // 
            this.txtbLastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbLastname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLastname.Location = new System.Drawing.Point(241, 88);
            this.txtbLastname.MaxLength = 50;
            this.txtbLastname.Name = "txtbLastname";
            this.txtbLastname.Size = new System.Drawing.Size(205, 26);
            this.txtbLastname.TabIndex = 3;
            this.txtbLastname.TextChanged += new System.EventHandler(this.txtbLastname_TextChanged);
            this.txtbLastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbLastname_KeyDown);
            this.txtbLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbLastname_KeyPress);
            // 
            // txtbFirstname
            // 
            this.txtbFirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbFirstname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFirstname.Location = new System.Drawing.Point(11, 88);
            this.txtbFirstname.MaxLength = 50;
            this.txtbFirstname.Name = "txtbFirstname";
            this.txtbFirstname.Size = new System.Drawing.Size(224, 26);
            this.txtbFirstname.TabIndex = 2;
            this.txtbFirstname.TextChanged += new System.EventHandler(this.txtbFirstname_TextChanged);
            this.txtbFirstname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbFirstname_KeyDown);
            this.txtbFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFirstname_KeyPress);
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblFirstname.Location = new System.Drawing.Point(7, 66);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(85, 20);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "FIRSTNAME";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblUserType.Location = new System.Drawing.Point(399, 28);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(47, 20);
            this.lblUserType.TabIndex = 0;
            this.lblUserType.Text = "TYPE:";
            // 
            // txtbUserID
            // 
            this.txtbUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbUserID.Enabled = false;
            this.txtbUserID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUserID.Location = new System.Drawing.Point(94, 25);
            this.txtbUserID.Name = "txtbUserID";
            this.txtbUserID.Size = new System.Drawing.Size(230, 26);
            this.txtbUserID.TabIndex = 0;
            this.txtbUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblUserID.Location = new System.Drawing.Point(7, 28);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(66, 20);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "USER ID:";
            // 
            // gbUserAccount
            // 
            this.gbUserAccount.BackColor = System.Drawing.Color.Transparent;
            this.gbUserAccount.Controls.Add(this.cbShow);
            this.gbUserAccount.Controls.Add(this.txtbConfirmpass);
            this.gbUserAccount.Controls.Add(this.lblConfirmpass);
            this.gbUserAccount.Controls.Add(this.txtbPassword);
            this.gbUserAccount.Controls.Add(this.lblPassword);
            this.gbUserAccount.Controls.Add(this.txtbUsername);
            this.gbUserAccount.Controls.Add(this.lblUsername);
            this.gbUserAccount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gbUserAccount.Location = new System.Drawing.Point(12, 298);
            this.gbUserAccount.Name = "gbUserAccount";
            this.gbUserAccount.Size = new System.Drawing.Size(398, 157);
            this.gbUserAccount.TabIndex = 2;
            this.gbUserAccount.TabStop = false;
            this.gbUserAccount.Text = "USER ACCOUNT";
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.cbShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbShow.Location = new System.Drawing.Point(180, 128);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(106, 21);
            this.cbShow.TabIndex = 14;
            this.cbShow.Text = "Show password";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // txtbConfirmpass
            // 
            this.txtbConfirmpass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbConfirmpass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbConfirmpass.Location = new System.Drawing.Point(180, 96);
            this.txtbConfirmpass.MaxLength = 255;
            this.txtbConfirmpass.Name = "txtbConfirmpass";
            this.txtbConfirmpass.PasswordChar = '*';
            this.txtbConfirmpass.Size = new System.Drawing.Size(203, 26);
            this.txtbConfirmpass.TabIndex = 10;
            this.txtbConfirmpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbConfirmpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbConfirmpass_KeyDown);
            // 
            // lblConfirmpass
            // 
            this.lblConfirmpass.AutoSize = true;
            this.lblConfirmpass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblConfirmpass.Location = new System.Drawing.Point(7, 96);
            this.lblConfirmpass.Name = "lblConfirmpass";
            this.lblConfirmpass.Size = new System.Drawing.Size(152, 20);
            this.lblConfirmpass.TabIndex = 0;
            this.lblConfirmpass.Text = "CONFIRM PASSWORD:";
            // 
            // txtbPassword
            // 
            this.txtbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassword.Location = new System.Drawing.Point(180, 60);
            this.txtbPassword.MaxLength = 255;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(203, 26);
            this.txtbPassword.TabIndex = 9;
            this.txtbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblPassword.Location = new System.Drawing.Point(7, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 20);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // txtbUsername
            // 
            this.txtbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbUsername.Enabled = false;
            this.txtbUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsername.Location = new System.Drawing.Point(180, 25);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(203, 26);
            this.txtbUsername.TabIndex = 9;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblUsername.Location = new System.Drawing.Point(7, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "USERNAME:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegister.Location = new System.Drawing.Point(460, 394);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(186, 50);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "CREATE ACCOUNT";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(683, 461);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.gbUserAccount);
            this.Controls.Add(this.gbUserInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARTISAN DE FLEUR | ADMIN";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.gbUserInformation.ResumeLayout(false);
            this.gbUserInformation.PerformLayout();
            this.gbUserAccount.ResumeLayout(false);
            this.gbUserAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserInformation;
        public System.Windows.Forms.DateTimePicker dtpBirthday;
        public System.Windows.Forms.ComboBox cmbGender;
        public System.Windows.Forms.ComboBox cmbUsertype;
        public System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblGender;
        public System.Windows.Forms.TextBox txtbMI;
        private System.Windows.Forms.Label lblMI;
        public System.Windows.Forms.TextBox txtbLastname;
        public System.Windows.Forms.TextBox txtbFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblUserType;
        public System.Windows.Forms.TextBox txtbUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.GroupBox gbUserAccount;
        private System.Windows.Forms.CheckBox cbShow;
        public System.Windows.Forms.TextBox txtbConfirmpass;
        private System.Windows.Forms.Label lblConfirmpass;
        public System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Button btnRegister;
    }
}