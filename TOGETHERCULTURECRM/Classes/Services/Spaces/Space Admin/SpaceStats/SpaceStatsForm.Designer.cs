namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Admin.SpaceStats
{
    partial class SpaceStatsForm
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
            this.dataGridViewTotalBookingsList = new System.Windows.Forms.DataGridView();
            this.btnLoadSpaceBookingStats = new System.Windows.Forms.Button();
            this.lbltotalBooking = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalBookingsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTotalBookingsList
            // 
            this.dataGridViewTotalBookingsList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTotalBookingsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotalBookingsList.Location = new System.Drawing.Point(189, 66);
            this.dataGridViewTotalBookingsList.Name = "dataGridViewTotalBookingsList";
            this.dataGridViewTotalBookingsList.Size = new System.Drawing.Size(441, 244);
            this.dataGridViewTotalBookingsList.TabIndex = 0;
            this.dataGridViewTotalBookingsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTotalBookingsList_CellContentClick);
            // 
            // btnLoadSpaceBookingStats
            // 
            this.btnLoadSpaceBookingStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnLoadSpaceBookingStats.FlatAppearance.BorderSize = 0;
            this.btnLoadSpaceBookingStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSpaceBookingStats.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSpaceBookingStats.ForeColor = System.Drawing.Color.White;
            this.btnLoadSpaceBookingStats.Location = new System.Drawing.Point(335, 329);
            this.btnLoadSpaceBookingStats.Name = "btnLoadSpaceBookingStats";
            this.btnLoadSpaceBookingStats.Size = new System.Drawing.Size(152, 39);
            this.btnLoadSpaceBookingStats.TabIndex = 22;
            this.btnLoadSpaceBookingStats.Text = "Load";
            this.btnLoadSpaceBookingStats.UseVisualStyleBackColor = false;
            this.btnLoadSpaceBookingStats.Click += new System.EventHandler(this.btnLoadSpaceBookingStats_Click);
            // 
            // lbltotalBooking
            // 
            this.lbltotalBooking.AutoSize = true;
            this.lbltotalBooking.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalBooking.ForeColor = System.Drawing.Color.White;
            this.lbltotalBooking.Location = new System.Drawing.Point(329, 29);
            this.lbltotalBooking.Name = "lbltotalBooking";
            this.lbltotalBooking.Size = new System.Drawing.Size(161, 34);
            this.lbltotalBooking.TabIndex = 24;
            this.lbltotalBooking.Text = "Total Bookings";
            this.lbltotalBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltotalBooking.Click += new System.EventHandler(this.lbltotalBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(335, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 39);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SpaceStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbltotalBooking);
            this.Controls.Add(this.btnLoadSpaceBookingStats);
            this.Controls.Add(this.dataGridViewTotalBookingsList);
            this.Name = "SpaceStatsForm";
            this.Text = "SpaceStatsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalBookingsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTotalBookingsList;
        private System.Windows.Forms.Button btnLoadSpaceBookingStats;
        private System.Windows.Forms.Label lbltotalBooking;
        private System.Windows.Forms.Button btnCancel;
    }
}