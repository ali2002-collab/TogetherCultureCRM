namespace TOGETHERCULTURECRM.Classes.AdminDashboard.ApproveMembers
{
    partial class ApproveMembersForm
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
            this.membershipRequestsGrid = new System.Windows.Forms.DataGridView();
            this.ApproveReq = new System.Windows.Forms.Button();
            this.btnLoadRequests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.membershipRequestsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // membershipRequestsGrid
            // 
            this.membershipRequestsGrid.BackgroundColor = System.Drawing.Color.White;
            this.membershipRequestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membershipRequestsGrid.Location = new System.Drawing.Point(292, 45);
            this.membershipRequestsGrid.Name = "membershipRequestsGrid";
            this.membershipRequestsGrid.Size = new System.Drawing.Size(240, 150);
            this.membershipRequestsGrid.TabIndex = 0;
            this.membershipRequestsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.membershipRequestsGrid_CellContentClick);
            // 
            // ApproveReq
            // 
            this.ApproveReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.ApproveReq.FlatAppearance.BorderSize = 0;
            this.ApproveReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveReq.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveReq.ForeColor = System.Drawing.Color.White;
            this.ApproveReq.Location = new System.Drawing.Point(315, 223);
            this.ApproveReq.Name = "ApproveReq";
            this.ApproveReq.Size = new System.Drawing.Size(197, 40);
            this.ApproveReq.TabIndex = 4;
            this.ApproveReq.Text = "Approve";
            this.ApproveReq.UseVisualStyleBackColor = false;
            this.ApproveReq.Click += new System.EventHandler(this.ApproveReq_Click);
            // 
            // btnLoadRequests
            // 
            this.btnLoadRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnLoadRequests.FlatAppearance.BorderSize = 0;
            this.btnLoadRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRequests.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRequests.ForeColor = System.Drawing.Color.White;
            this.btnLoadRequests.Location = new System.Drawing.Point(110, 112);
            this.btnLoadRequests.Name = "btnLoadRequests";
            this.btnLoadRequests.Size = new System.Drawing.Size(134, 40);
            this.btnLoadRequests.TabIndex = 5;
            this.btnLoadRequests.Text = "Load";
            this.btnLoadRequests.UseVisualStyleBackColor = false;
            this.btnLoadRequests.Click += new System.EventHandler(this.btnLoadRequests_Click);
            // 
            // ApproveMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadRequests);
            this.Controls.Add(this.ApproveReq);
            this.Controls.Add(this.membershipRequestsGrid);
            this.Name = "ApproveMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApproveMembersForm";
            ((System.ComponentModel.ISupportInitialize)(this.membershipRequestsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView membershipRequestsGrid;
        private System.Windows.Forms.Button ApproveReq;
        private System.Windows.Forms.Button btnLoadRequests;
    }
}