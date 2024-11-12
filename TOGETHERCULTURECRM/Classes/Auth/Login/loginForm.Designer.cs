namespace TOGETHERCULTURECRM.Classes.Auth
{
    partial class loginForm
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
            this.LoginTitle = new System.Windows.Forms.Label();
            this.EmailTitle = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.PasswordTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.ForgetPassword = new System.Windows.Forms.LinkLabel();
            this.DontHaveAcc = new System.Windows.Forms.Label();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
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
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.ForeColor = System.Drawing.Color.White;
            this.LoginTitle.Location = new System.Drawing.Point(582, 85);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(103, 51);
            this.LoginTitle.TabIndex = 1;
            this.LoginTitle.Text = "Login";
            // 
            // EmailTitle
            // 
            this.EmailTitle.AutoSize = true;
            this.EmailTitle.BackColor = System.Drawing.Color.Transparent;
            this.EmailTitle.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTitle.ForeColor = System.Drawing.Color.White;
            this.EmailTitle.Location = new System.Drawing.Point(538, 147);
            this.EmailTitle.Name = "EmailTitle";
            this.EmailTitle.Size = new System.Drawing.Size(51, 23);
            this.EmailTitle.TabIndex = 2;
            this.EmailTitle.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(542, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 27);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(542, 244);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 27);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // PasswordTitle
            // 
            this.PasswordTitle.AutoSize = true;
            this.PasswordTitle.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTitle.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTitle.ForeColor = System.Drawing.Color.White;
            this.PasswordTitle.Location = new System.Drawing.Point(538, 218);
            this.PasswordTitle.Name = "PasswordTitle";
            this.PasswordTitle.Size = new System.Drawing.Size(82, 23);
            this.PasswordTitle.TabIndex = 5;
            this.PasswordTitle.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(542, 307);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(182, 38);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(627, 59);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 7;
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.AutoSize = true;
            this.ForgetPassword.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassword.ForeColor = System.Drawing.Color.White;
            this.ForgetPassword.LinkColor = System.Drawing.Color.White;
            this.ForgetPassword.Location = new System.Drawing.Point(542, 276);
            this.ForgetPassword.Name = "ForgetPassword";
            this.ForgetPassword.Size = new System.Drawing.Size(122, 19);
            this.ForgetPassword.TabIndex = 8;
            this.ForgetPassword.TabStop = true;
            this.ForgetPassword.Text = "Forget Password?";
            this.ForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetPassword_LinkClicked);
            // 
            // DontHaveAcc
            // 
            this.DontHaveAcc.AutoSize = true;
            this.DontHaveAcc.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DontHaveAcc.ForeColor = System.Drawing.Color.White;
            this.DontHaveAcc.Location = new System.Drawing.Point(549, 361);
            this.DontHaveAcc.Name = "DontHaveAcc";
            this.DontHaveAcc.Size = new System.Drawing.Size(167, 19);
            this.DontHaveAcc.TabIndex = 9;
            this.DontHaveAcc.Text = "Don\'t Have an Account ?";
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.BackColor = System.Drawing.Color.Transparent;
            this.RegisterLink.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLink.ForeColor = System.Drawing.Color.White;
            this.RegisterLink.LinkColor = System.Drawing.Color.MidnightBlue;
            this.RegisterLink.Location = new System.Drawing.Point(600, 377);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(65, 23);
            this.RegisterLink.TabIndex = 10;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Register";
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.RegisterLink);
            this.panelContainer.Controls.Add(this.DontHaveAcc);
            this.panelContainer.Controls.Add(this.ForgetPassword);
            this.panelContainer.Controls.Add(this.lblError);
            this.panelContainer.Controls.Add(this.btnLogin);
            this.panelContainer.Controls.Add(this.PasswordTitle);
            this.panelContainer.Controls.Add(this.txtPassword);
            this.panelContainer.Controls.Add(this.txtEmail);
            this.panelContainer.Controls.Add(this.EmailTitle);
            this.panelContainer.Controls.Add(this.LoginTitle);
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(801, 452);
            this.panelContainer.TabIndex = 11;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.Label EmailTitle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label PasswordTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.LinkLabel ForgetPassword;
        private System.Windows.Forms.Label DontHaveAcc;
        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.Panel panelContainer;
    }
}