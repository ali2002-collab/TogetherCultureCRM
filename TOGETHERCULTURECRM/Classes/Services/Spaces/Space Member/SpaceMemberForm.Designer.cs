namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Member
{
    partial class SpaceMemberForm
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
            this.lblSpace = new System.Windows.Forms.Label();
            this.lblCreateDifference = new System.Windows.Forms.Label();
            this.btnMemberOpenBookedSpaceForm = new System.Windows.Forms.Button();
            this.pnlMemberSpacePosts = new System.Windows.Forms.Panel();
            this.lblNoSpaces = new System.Windows.Forms.Label();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = true;
            this.lblSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblSpace.Font = new System.Drawing.Font("Poppins", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblSpace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.lblSpace.Location = new System.Drawing.Point(12, 9);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(204, 50);
            this.lblSpace.TabIndex = 12;
            this.lblSpace.Text = "Book Spaces";
            // 
            // lblCreateDifference
            // 
            this.lblCreateDifference.AutoSize = true;
            this.lblCreateDifference.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateDifference.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblCreateDifference.ForeColor = System.Drawing.Color.Black;
            this.lblCreateDifference.Location = new System.Drawing.Point(357, 22);
            this.lblCreateDifference.Name = "lblCreateDifference";
            this.lblCreateDifference.Size = new System.Drawing.Size(338, 30);
            this.lblCreateDifference.TabIndex = 14;
            this.lblCreateDifference.Text = "Lets Book Some Productivity Sessions";
            // 
            // btnMemberOpenBookedSpaceForm
            // 
            this.btnMemberOpenBookedSpaceForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnMemberOpenBookedSpaceForm.FlatAppearance.BorderSize = 0;
            this.btnMemberOpenBookedSpaceForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberOpenBookedSpaceForm.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberOpenBookedSpaceForm.ForeColor = System.Drawing.Color.White;
            this.btnMemberOpenBookedSpaceForm.Location = new System.Drawing.Point(984, 18);
            this.btnMemberOpenBookedSpaceForm.Name = "btnMemberOpenBookedSpaceForm";
            this.btnMemberOpenBookedSpaceForm.Size = new System.Drawing.Size(138, 38);
            this.btnMemberOpenBookedSpaceForm.TabIndex = 15;
            this.btnMemberOpenBookedSpaceForm.Text = "Booked Spaces";
            this.btnMemberOpenBookedSpaceForm.UseVisualStyleBackColor = false;
            this.btnMemberOpenBookedSpaceForm.Click += new System.EventHandler(this.btnMemberOpenBookedSpaceForm_Click);
            // 
            // pnlMemberSpacePosts
            // 
            this.pnlMemberSpacePosts.AutoScroll = true;
            this.pnlMemberSpacePosts.Location = new System.Drawing.Point(12, 93);
            this.pnlMemberSpacePosts.Name = "pnlMemberSpacePosts";
            this.pnlMemberSpacePosts.Size = new System.Drawing.Size(1148, 418);
            this.pnlMemberSpacePosts.TabIndex = 37;
            this.pnlMemberSpacePosts.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMemberSpacePosts_Paint);
            // 
            // lblNoSpaces
            // 
            this.lblNoSpaces.AutoSize = true;
            this.lblNoSpaces.BackColor = System.Drawing.Color.Transparent;
            this.lblNoSpaces.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblNoSpaces.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNoSpaces.Location = new System.Drawing.Point(393, 60);
            this.lblNoSpaces.Name = "lblNoSpaces";
            this.lblNoSpaces.Size = new System.Drawing.Size(255, 30);
            this.lblNoSpaces.TabIndex = 40;
            this.lblNoSpaces.Text = "No Space Available to book";
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.Location = new System.Drawing.Point(429, 517);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(111, 38);
            this.btnPreviousPage.TabIndex = 41;
            this.btnPreviousPage.Text = "< Previous";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(546, 517);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(111, 38);
            this.btnNextPage.TabIndex = 42;
            this.btnNextPage.Text = "Next >";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // SpaceMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 651);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.lblNoSpaces);
            this.Controls.Add(this.pnlMemberSpacePosts);
            this.Controls.Add(this.btnMemberOpenBookedSpaceForm);
            this.Controls.Add(this.lblCreateDifference);
            this.Controls.Add(this.lblSpace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpaceMemberForm";
            this.Text = "SpaceMemberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpace;
        private System.Windows.Forms.Label lblCreateDifference;
        private System.Windows.Forms.Button btnMemberOpenBookedSpaceForm;
        private System.Windows.Forms.Panel pnlMemberSpacePosts;
        private System.Windows.Forms.Label lblNoSpaces;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
    }
}