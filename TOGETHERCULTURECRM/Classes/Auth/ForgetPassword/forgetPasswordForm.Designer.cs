namespace TOGETHERCULTURECRM.Classes.Auth.ForgetPassword
{
    partial class forgetPasswordForm
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
            this.txtConfirmEmail = new System.Windows.Forms.TextBox();
            this.confirmEmailLabel = new System.Windows.Forms.Label();
            this.txtconfirmDOBLabel = new System.Windows.Forms.Label();
            this.confirmEmailDOB = new System.Windows.Forms.Button();
            this.forgetPassPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.forgetPassPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConfirmEmail
            // 
            this.txtConfirmEmail.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmEmail.Location = new System.Drawing.Point(514, 177);
            this.txtConfirmEmail.Name = "txtConfirmEmail";
            this.txtConfirmEmail.Size = new System.Drawing.Size(182, 27);
            this.txtConfirmEmail.TabIndex = 1;
            this.txtConfirmEmail.TextChanged += new System.EventHandler(this.txtConfirmEmail_TextChanged);
            // 
            // confirmEmailLabel
            // 
            this.confirmEmailLabel.AutoSize = true;
            this.confirmEmailLabel.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmEmailLabel.ForeColor = System.Drawing.Color.White;
            this.confirmEmailLabel.Location = new System.Drawing.Point(510, 155);
            this.confirmEmailLabel.Name = "confirmEmailLabel";
            this.confirmEmailLabel.Size = new System.Drawing.Size(100, 19);
            this.confirmEmailLabel.TabIndex = 2;
            this.confirmEmailLabel.Text = "Confirm Email";
            // 
            // txtconfirmDOBLabel
            // 
            this.txtconfirmDOBLabel.AutoSize = true;
            this.txtconfirmDOBLabel.BackColor = System.Drawing.Color.Transparent;
            this.txtconfirmDOBLabel.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmDOBLabel.ForeColor = System.Drawing.Color.White;
            this.txtconfirmDOBLabel.Location = new System.Drawing.Point(510, 221);
            this.txtconfirmDOBLabel.Name = "txtconfirmDOBLabel";
            this.txtconfirmDOBLabel.Size = new System.Drawing.Size(92, 19);
            this.txtconfirmDOBLabel.TabIndex = 4;
            this.txtconfirmDOBLabel.Text = "Confirm DOB";
            // 
            // confirmEmailDOB
            // 
            this.confirmEmailDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.confirmEmailDOB.FlatAppearance.BorderSize = 0;
            this.confirmEmailDOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmEmailDOB.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmEmailDOB.ForeColor = System.Drawing.Color.White;
            this.confirmEmailDOB.Location = new System.Drawing.Point(514, 288);
            this.confirmEmailDOB.Name = "confirmEmailDOB";
            this.confirmEmailDOB.Size = new System.Drawing.Size(182, 38);
            this.confirmEmailDOB.TabIndex = 5;
            this.confirmEmailDOB.Text = "Confirm";
            this.confirmEmailDOB.UseVisualStyleBackColor = false;
            this.confirmEmailDOB.Click += new System.EventHandler(this.confirmEmailDOB_Click);
            // 
            // forgetPassPanel
            // 
            this.forgetPassPanel.Controls.Add(this.dateTimePicker);
            this.forgetPassPanel.Controls.Add(this.confirmEmailDOB);
            this.forgetPassPanel.Controls.Add(this.txtconfirmDOBLabel);
            this.forgetPassPanel.Controls.Add(this.confirmEmailLabel);
            this.forgetPassPanel.Controls.Add(this.txtConfirmEmail);
            this.forgetPassPanel.Controls.Add(this.pictureBox1);
            this.forgetPassPanel.Location = new System.Drawing.Point(1, 1);
            this.forgetPassPanel.Name = "forgetPassPanel";
            this.forgetPassPanel.Size = new System.Drawing.Size(800, 449);
            this.forgetPassPanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TOGETHERCULTURECRM.Properties.Resources.TC_Logos_01;
            this.pictureBox1.Location = new System.Drawing.Point(11, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(514, 243);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // forgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forgetPassPanel);
            this.Name = "forgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordForm";
            this.Load += new System.EventHandler(this.forgetPasswordForm_Load);
            this.forgetPassPanel.ResumeLayout(false);
            this.forgetPassPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtConfirmEmail;
        private System.Windows.Forms.Label confirmEmailLabel;
        private System.Windows.Forms.Label txtconfirmDOBLabel;
        private System.Windows.Forms.Button confirmEmailDOB;
        private System.Windows.Forms.Panel forgetPassPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}