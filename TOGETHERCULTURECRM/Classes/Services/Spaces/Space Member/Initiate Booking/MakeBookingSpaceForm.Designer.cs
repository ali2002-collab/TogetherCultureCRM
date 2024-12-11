namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Member.Initiate_Booking
{
    partial class MakeBookingSpaceForm
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
            this.lblMmemberSpaceStartTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.txtSpacePurpose = new System.Windows.Forms.TextBox();
            this.dtpSpaceBookDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.btnBookSpace = new System.Windows.Forms.Button();
            this.btnCancelForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMmemberSpaceStartTime
            // 
            this.lblMmemberSpaceStartTime.AutoSize = true;
            this.lblMmemberSpaceStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lblMmemberSpaceStartTime.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMmemberSpaceStartTime.ForeColor = System.Drawing.Color.White;
            this.lblMmemberSpaceStartTime.Location = new System.Drawing.Point(30, 136);
            this.lblMmemberSpaceStartTime.Name = "lblMmemberSpaceStartTime";
            this.lblMmemberSpaceStartTime.Size = new System.Drawing.Size(80, 22);
            this.lblMmemberSpaceStartTime.TabIndex = 39;
            this.lblMmemberSpaceStartTime.Text = "Start Time";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(34, 161);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(182, 27);
            this.dtpStartTime.TabIndex = 40;
            this.dtpStartTime.Value = new System.DateTime(2024, 12, 6, 0, 0, 0, 0);
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEndTime.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.Color.White;
            this.lblEndTime.Location = new System.Drawing.Point(30, 213);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(72, 22);
            this.lblEndTime.TabIndex = 41;
            this.lblEndTime.Text = "End Time";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(34, 238);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(182, 27);
            this.dtpEndTime.TabIndex = 42;
            this.dtpEndTime.Value = new System.DateTime(2024, 12, 6, 0, 0, 0, 0);
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.dtpEndTime_ValueChanged);
            // 
            // txtSpacePurpose
            // 
            this.txtSpacePurpose.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpacePurpose.Location = new System.Drawing.Point(326, 115);
            this.txtSpacePurpose.Multiline = true;
            this.txtSpacePurpose.Name = "txtSpacePurpose";
            this.txtSpacePurpose.Size = new System.Drawing.Size(234, 120);
            this.txtSpacePurpose.TabIndex = 43;
            this.txtSpacePurpose.TextChanged += new System.EventHandler(this.txtSpacePurpose_TextChanged);
            // 
            // dtpSpaceBookDate
            // 
            this.dtpSpaceBookDate.Location = new System.Drawing.Point(34, 75);
            this.dtpSpaceBookDate.Name = "dtpSpaceBookDate";
            this.dtpSpaceBookDate.Size = new System.Drawing.Size(182, 20);
            this.dtpSpaceBookDate.TabIndex = 44;
            this.dtpSpaceBookDate.ValueChanged += new System.EventHandler(this.dtpSpaceBookDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(30, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 22);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Start Time";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.BackColor = System.Drawing.Color.Transparent;
            this.lblPurpose.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.ForeColor = System.Drawing.Color.White;
            this.lblPurpose.Location = new System.Drawing.Point(322, 90);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(66, 22);
            this.lblPurpose.TabIndex = 46;
            this.lblPurpose.Text = "Purpose";
            // 
            // btnBookSpace
            // 
            this.btnBookSpace.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBookSpace.FlatAppearance.BorderSize = 0;
            this.btnBookSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSpace.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSpace.ForeColor = System.Drawing.Color.White;
            this.btnBookSpace.Location = new System.Drawing.Point(379, 324);
            this.btnBookSpace.Name = "btnBookSpace";
            this.btnBookSpace.Size = new System.Drawing.Size(116, 32);
            this.btnBookSpace.TabIndex = 47;
            this.btnBookSpace.Text = "Book";
            this.btnBookSpace.UseVisualStyleBackColor = false;
            this.btnBookSpace.Click += new System.EventHandler(this.btnBookSpace_Click);
            // 
            // btnCancelForm
            // 
            this.btnCancelForm.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancelForm.FlatAppearance.BorderSize = 0;
            this.btnCancelForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelForm.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelForm.ForeColor = System.Drawing.Color.White;
            this.btnCancelForm.Location = new System.Drawing.Point(379, 276);
            this.btnCancelForm.Name = "btnCancelForm";
            this.btnCancelForm.Size = new System.Drawing.Size(116, 32);
            this.btnCancelForm.TabIndex = 48;
            this.btnCancelForm.Text = "Cancel";
            this.btnCancelForm.UseVisualStyleBackColor = false;
            this.btnCancelForm.Click += new System.EventHandler(this.btnCancelForm_Click);
            // 
            // MakeBookingSpaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelForm);
            this.Controls.Add(this.btnBookSpace);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpSpaceBookDate);
            this.Controls.Add(this.txtSpacePurpose);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.lblMmemberSpaceStartTime);
            this.Name = "MakeBookingSpaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeBookingSpaceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMmemberSpaceStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.TextBox txtSpacePurpose;
        private System.Windows.Forms.DateTimePicker dtpSpaceBookDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Button btnBookSpace;
        private System.Windows.Forms.Button btnCancelForm;
    }
}