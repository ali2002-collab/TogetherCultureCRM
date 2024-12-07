namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin.Admin_Event_Stats
{
    partial class AdminEventStatsForm
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
            this.dataGridViewEventStats = new System.Windows.Forms.DataGridView();
            this.btnLoadEventStats = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCurrentAttendance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventStats)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEventStats
            // 
            this.dataGridViewEventStats.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEventStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventStats.Location = new System.Drawing.Point(260, 46);
            this.dataGridViewEventStats.Name = "dataGridViewEventStats";
            this.dataGridViewEventStats.ReadOnly = true;
            this.dataGridViewEventStats.Size = new System.Drawing.Size(311, 206);
            this.dataGridViewEventStats.TabIndex = 0;
            this.dataGridViewEventStats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEventStats_CellContentClick);
            // 
            // btnLoadEventStats
            // 
            this.btnLoadEventStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnLoadEventStats.FlatAppearance.BorderSize = 0;
            this.btnLoadEventStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadEventStats.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadEventStats.ForeColor = System.Drawing.Color.White;
            this.btnLoadEventStats.Location = new System.Drawing.Point(344, 290);
            this.btnLoadEventStats.Name = "btnLoadEventStats";
            this.btnLoadEventStats.Size = new System.Drawing.Size(152, 39);
            this.btnLoadEventStats.TabIndex = 21;
            this.btnLoadEventStats.Text = "Load";
            this.btnLoadEventStats.UseVisualStyleBackColor = false;
            this.btnLoadEventStats.Click += new System.EventHandler(this.btnLoadEventStats_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(344, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 39);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCurrentAttendance
            // 
            this.lblCurrentAttendance.AutoSize = true;
            this.lblCurrentAttendance.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAttendance.ForeColor = System.Drawing.Color.White;
            this.lblCurrentAttendance.Location = new System.Drawing.Point(312, 9);
            this.lblCurrentAttendance.Name = "lblCurrentAttendance";
            this.lblCurrentAttendance.Size = new System.Drawing.Size(212, 34);
            this.lblCurrentAttendance.TabIndex = 23;
            this.lblCurrentAttendance.Text = "Current Attendance";
            this.lblCurrentAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentAttendance.Click += new System.EventHandler(this.lblCurrentAttendance_Click);
            // 
            // AdminEventStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCurrentAttendance);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoadEventStats);
            this.Controls.Add(this.dataGridViewEventStats);
            this.Name = "AdminEventStatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEventStatsForm";
            this.Load += new System.EventHandler(this.AdminEventStatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEventStats;
        private System.Windows.Forms.Button btnLoadEventStats;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCurrentAttendance;
    }
}