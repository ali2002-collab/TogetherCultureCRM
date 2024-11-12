namespace TOGETHERCULTURECRM.Classes.Auth
{
    partial class registerForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegisterTitle = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.lblLN = new System.Windows.Forms.Label();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.lblRegisterEmail = new System.Windows.Forms.Label();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtpRegisterDOB = new System.Windows.Forms.DateTimePicker();
            this.lblRegisterDOB = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblAlreadyHaveAcc = new System.Windows.Forms.Label();
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TOGETHERCULTURECRM.Properties.Resources.TC_Logos_01;
            this.pictureBox1.Location = new System.Drawing.Point(61, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterTitle
            // 
            this.RegisterTitle.AutoSize = true;
            this.RegisterTitle.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterTitle.ForeColor = System.Drawing.Color.White;
            this.RegisterTitle.Location = new System.Drawing.Point(576, 20);
            this.RegisterTitle.Name = "RegisterTitle";
            this.RegisterTitle.Size = new System.Drawing.Size(146, 51);
            this.RegisterTitle.TabIndex = 2;
            this.RegisterTitle.Text = "Register";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.ForeColor = System.Drawing.Color.White;
            this.lblFN.Location = new System.Drawing.Point(463, 83);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(90, 23);
            this.lblFN.TabIndex = 3;
            this.lblFN.Text = "First Name";
            // 
            // txtFN
            // 
            this.txtFN.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFN.Location = new System.Drawing.Point(559, 86);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(182, 27);
            this.txtFN.TabIndex = 4;
            this.txtFN.TextChanged += new System.EventHandler(this.txtFN_TextChanged);
            // 
            // txtLN
            // 
            this.txtLN.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLN.Location = new System.Drawing.Point(559, 128);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(182, 27);
            this.txtLN.TabIndex = 5;
            this.txtLN.TextChanged += new System.EventHandler(this.txtLN_TextChanged);
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.ForeColor = System.Drawing.Color.White;
            this.lblLN.Location = new System.Drawing.Point(464, 125);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(89, 23);
            this.lblLN.TabIndex = 6;
            this.lblLN.Text = "Last Name";
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterEmail.Location = new System.Drawing.Point(559, 170);
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(182, 27);
            this.txtRegisterEmail.TabIndex = 7;
            this.txtRegisterEmail.TextChanged += new System.EventHandler(this.txtRegisterEmail_TextChanged);
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.AutoSize = true;
            this.lblRegisterEmail.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterEmail.ForeColor = System.Drawing.Color.White;
            this.lblRegisterEmail.Location = new System.Drawing.Point(502, 167);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(51, 23);
            this.lblRegisterEmail.TabIndex = 8;
            this.lblRegisterEmail.Text = "Email";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(559, 212);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '*';
            this.txtRegisterPassword.Size = new System.Drawing.Size(182, 27);
            this.txtRegisterPassword.TabIndex = 9;
            this.txtRegisterPassword.TextChanged += new System.EventHandler(this.txtRegisterPassword_TextChanged);
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.ForeColor = System.Drawing.Color.White;
            this.lblRegisterPassword.Location = new System.Drawing.Point(471, 209);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(82, 23);
            this.lblRegisterPassword.TabIndex = 10;
            this.lblRegisterPassword.Text = "Password";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(559, 254);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(182, 27);
            this.cmbGender.TabIndex = 11;
            this.cmbGender.Text = "Select";
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(489, 251);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 23);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // dtpRegisterDOB
            // 
            this.dtpRegisterDOB.Location = new System.Drawing.Point(559, 296);
            this.dtpRegisterDOB.Name = "dtpRegisterDOB";
            this.dtpRegisterDOB.Size = new System.Drawing.Size(182, 20);
            this.dtpRegisterDOB.TabIndex = 13;
            this.dtpRegisterDOB.ValueChanged += new System.EventHandler(this.dtpRegisterDOB_ValueChanged);
            // 
            // lblRegisterDOB
            // 
            this.lblRegisterDOB.AutoSize = true;
            this.lblRegisterDOB.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterDOB.ForeColor = System.Drawing.Color.White;
            this.lblRegisterDOB.Location = new System.Drawing.Point(513, 289);
            this.lblRegisterDOB.Name = "lblRegisterDOB";
            this.lblRegisterDOB.Size = new System.Drawing.Size(40, 23);
            this.lblRegisterDOB.TabIndex = 14;
            this.lblRegisterDOB.Text = "DOB";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(559, 335);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(182, 38);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblAlreadyHaveAcc
            // 
            this.lblAlreadyHaveAcc.AutoSize = true;
            this.lblAlreadyHaveAcc.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlreadyHaveAcc.ForeColor = System.Drawing.Color.White;
            this.lblAlreadyHaveAcc.Location = new System.Drawing.Point(560, 383);
            this.lblAlreadyHaveAcc.Name = "lblAlreadyHaveAcc";
            this.lblAlreadyHaveAcc.Size = new System.Drawing.Size(180, 19);
            this.lblAlreadyHaveAcc.TabIndex = 16;
            this.lblAlreadyHaveAcc.Text = "Already Have An Account?";
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.BackColor = System.Drawing.Color.Transparent;
            this.LoginLink.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLink.ForeColor = System.Drawing.Color.White;
            this.LoginLink.LinkColor = System.Drawing.Color.MidnightBlue;
            this.LoginLink.Location = new System.Drawing.Point(629, 400);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(46, 23);
            this.LoginLink.TabIndex = 17;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Login";
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.lblAlreadyHaveAcc);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblRegisterDOB);
            this.Controls.Add(this.dtpRegisterDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.lblRegisterEmail);
            this.Controls.Add(this.txtRegisterEmail);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.RegisterTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registerUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label RegisterTitle;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.Label lblRegisterEmail;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DateTimePicker dtpRegisterDOB;
        private System.Windows.Forms.Label lblRegisterDOB;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblAlreadyHaveAcc;
        private System.Windows.Forms.LinkLabel LoginLink;
    }
}