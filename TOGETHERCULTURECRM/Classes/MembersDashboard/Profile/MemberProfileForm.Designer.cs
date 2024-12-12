namespace TOGETHERCULTURECRM.Classes.MembersDashboard.Profile
{
    partial class MemberProfileForm
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
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSelectInterests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile.Location = new System.Drawing.Point(934, 40);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(102, 30);
            this.btnEditProfile.TabIndex = 7;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // picProfile
            // 
            this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfile.Location = new System.Drawing.Point(515, 40);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(150, 150);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 8;
            this.picProfile.TabStop = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Poppins", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(506, 208);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(177, 50);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // btnSelectInterests
            // 
            this.btnSelectInterests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnSelectInterests.FlatAppearance.BorderSize = 0;
            this.btnSelectInterests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectInterests.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectInterests.ForeColor = System.Drawing.Color.White;
            this.btnSelectInterests.Location = new System.Drawing.Point(518, 330);
            this.btnSelectInterests.Name = "btnSelectInterests";
            this.btnSelectInterests.Size = new System.Drawing.Size(156, 39);
            this.btnSelectInterests.TabIndex = 10;
            this.btnSelectInterests.Text = "Select Interest";
            this.btnSelectInterests.UseVisualStyleBackColor = false;
            this.btnSelectInterests.Click += new System.EventHandler(this.btnSelectInterests_Click);
            // 
            // MemberProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 651);
            this.Controls.Add(this.btnSelectInterests);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.btnEditProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberProfileForm";
            this.Text = "MemberProfileForm";
            this.Load += new System.EventHandler(this.MemberProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSelectInterests;
    }
}