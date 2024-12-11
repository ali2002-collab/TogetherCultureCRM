namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Admin.Create
{
    partial class AdminSpaceCreateForm
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
            this.lblSpaceName = new System.Windows.Forms.Label();
            this.txtSpaceName = new System.Windows.Forms.TextBox();
            this.lblSpaceLocation = new System.Windows.Forms.Label();
            this.txtSpacelocation = new System.Windows.Forms.TextBox();
            this.btnCancelForm = new System.Windows.Forms.Button();
            this.btnCreateSpace = new System.Windows.Forms.Button();
            this.lblSpaceType = new System.Windows.Forms.Label();
            this.cmbSpaceType = new System.Windows.Forms.ComboBox();
            this.lblCapacityLimit = new System.Windows.Forms.Label();
            this.numCapacityLimit = new System.Windows.Forms.NumericUpDown();
            this.dtpOpeningTime = new System.Windows.Forms.DateTimePicker();
            this.lblSpaceOpningTime = new System.Windows.Forms.Label();
            this.lblClosingTime = new System.Windows.Forms.Label();
            this.dtpClosingTime = new System.Windows.Forms.DateTimePicker();
            this.lblSpaceDescription = new System.Windows.Forms.Label();
            this.txtSpaceDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacityLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSpaceName
            // 
            this.lblSpaceName.AutoSize = true;
            this.lblSpaceName.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceName.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceName.ForeColor = System.Drawing.Color.White;
            this.lblSpaceName.Location = new System.Drawing.Point(33, 37);
            this.lblSpaceName.Name = "lblSpaceName";
            this.lblSpaceName.Size = new System.Drawing.Size(96, 22);
            this.lblSpaceName.TabIndex = 14;
            this.lblSpaceName.Text = "Space Name";
            // 
            // txtSpaceName
            // 
            this.txtSpaceName.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpaceName.Location = new System.Drawing.Point(37, 62);
            this.txtSpaceName.Name = "txtSpaceName";
            this.txtSpaceName.Size = new System.Drawing.Size(182, 27);
            this.txtSpaceName.TabIndex = 15;
            this.txtSpaceName.TextChanged += new System.EventHandler(this.txtSpaceName_TextChanged);
            // 
            // lblSpaceLocation
            // 
            this.lblSpaceLocation.AutoSize = true;
            this.lblSpaceLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceLocation.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceLocation.ForeColor = System.Drawing.Color.White;
            this.lblSpaceLocation.Location = new System.Drawing.Point(33, 250);
            this.lblSpaceLocation.Name = "lblSpaceLocation";
            this.lblSpaceLocation.Size = new System.Drawing.Size(69, 22);
            this.lblSpaceLocation.TabIndex = 18;
            this.lblSpaceLocation.Text = "Location";
            // 
            // txtSpacelocation
            // 
            this.txtSpacelocation.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpacelocation.Location = new System.Drawing.Point(37, 275);
            this.txtSpacelocation.Name = "txtSpacelocation";
            this.txtSpacelocation.Size = new System.Drawing.Size(182, 27);
            this.txtSpacelocation.TabIndex = 19;
            this.txtSpacelocation.TextChanged += new System.EventHandler(this.txtSpacelocation_TextChanged);
            // 
            // btnCancelForm
            // 
            this.btnCancelForm.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancelForm.FlatAppearance.BorderSize = 0;
            this.btnCancelForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelForm.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelForm.ForeColor = System.Drawing.Color.White;
            this.btnCancelForm.Location = new System.Drawing.Point(348, 144);
            this.btnCancelForm.Name = "btnCancelForm";
            this.btnCancelForm.Size = new System.Drawing.Size(127, 32);
            this.btnCancelForm.TabIndex = 31;
            this.btnCancelForm.Text = "Cancel";
            this.btnCancelForm.UseVisualStyleBackColor = false;
            this.btnCancelForm.Click += new System.EventHandler(this.btnCancelForm_Click);
            // 
            // btnCreateSpace
            // 
            this.btnCreateSpace.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateSpace.FlatAppearance.BorderSize = 0;
            this.btnCreateSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSpace.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSpace.ForeColor = System.Drawing.Color.White;
            this.btnCreateSpace.Location = new System.Drawing.Point(348, 195);
            this.btnCreateSpace.Name = "btnCreateSpace";
            this.btnCreateSpace.Size = new System.Drawing.Size(127, 32);
            this.btnCreateSpace.TabIndex = 32;
            this.btnCreateSpace.Text = "Create Space";
            this.btnCreateSpace.UseVisualStyleBackColor = false;
            this.btnCreateSpace.Click += new System.EventHandler(this.btnCreateSpace_Click);
            // 
            // lblSpaceType
            // 
            this.lblSpaceType.AutoSize = true;
            this.lblSpaceType.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceType.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceType.ForeColor = System.Drawing.Color.White;
            this.lblSpaceType.Location = new System.Drawing.Point(599, 37);
            this.lblSpaceType.Name = "lblSpaceType";
            this.lblSpaceType.Size = new System.Drawing.Size(89, 22);
            this.lblSpaceType.TabIndex = 33;
            this.lblSpaceType.Text = "Space Type";
            // 
            // cmbSpaceType
            // 
            this.cmbSpaceType.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpaceType.FormattingEnabled = true;
            this.cmbSpaceType.Items.AddRange(new object[] {
            "Meeting Room",
            "Lounge",
            "Workspace"});
            this.cmbSpaceType.Location = new System.Drawing.Point(603, 62);
            this.cmbSpaceType.Name = "cmbSpaceType";
            this.cmbSpaceType.Size = new System.Drawing.Size(182, 27);
            this.cmbSpaceType.TabIndex = 34;
            this.cmbSpaceType.Text = "Select";
            this.cmbSpaceType.SelectedIndexChanged += new System.EventHandler(this.cmbSpaceType_SelectedIndexChanged);
            // 
            // lblCapacityLimit
            // 
            this.lblCapacityLimit.AutoSize = true;
            this.lblCapacityLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacityLimit.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacityLimit.ForeColor = System.Drawing.Color.White;
            this.lblCapacityLimit.Location = new System.Drawing.Point(599, 119);
            this.lblCapacityLimit.Name = "lblCapacityLimit";
            this.lblCapacityLimit.Size = new System.Drawing.Size(118, 22);
            this.lblCapacityLimit.TabIndex = 35;
            this.lblCapacityLimit.Text = "Space Capacity";
            // 
            // numCapacityLimit
            // 
            this.numCapacityLimit.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.numCapacityLimit.Location = new System.Drawing.Point(603, 144);
            this.numCapacityLimit.Name = "numCapacityLimit";
            this.numCapacityLimit.Size = new System.Drawing.Size(182, 27);
            this.numCapacityLimit.TabIndex = 36;
            this.numCapacityLimit.ValueChanged += new System.EventHandler(this.numCapacityLimit_ValueChanged);
            // 
            // dtpOpeningTime
            // 
            this.dtpOpeningTime.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOpeningTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOpeningTime.Location = new System.Drawing.Point(603, 245);
            this.dtpOpeningTime.Name = "dtpOpeningTime";
            this.dtpOpeningTime.ShowUpDown = true;
            this.dtpOpeningTime.Size = new System.Drawing.Size(182, 27);
            this.dtpOpeningTime.TabIndex = 37;
            this.dtpOpeningTime.Value = new System.DateTime(2024, 12, 6, 0, 0, 0, 0);
            this.dtpOpeningTime.ValueChanged += new System.EventHandler(this.dtpOpeningTime_ValueChanged);
            // 
            // lblSpaceOpningTime
            // 
            this.lblSpaceOpningTime.AutoSize = true;
            this.lblSpaceOpningTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceOpningTime.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceOpningTime.ForeColor = System.Drawing.Color.White;
            this.lblSpaceOpningTime.Location = new System.Drawing.Point(599, 220);
            this.lblSpaceOpningTime.Name = "lblSpaceOpningTime";
            this.lblSpaceOpningTime.Size = new System.Drawing.Size(105, 22);
            this.lblSpaceOpningTime.TabIndex = 38;
            this.lblSpaceOpningTime.Text = "Opening Time";
            // 
            // lblClosingTime
            // 
            this.lblClosingTime.AutoSize = true;
            this.lblClosingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblClosingTime.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosingTime.ForeColor = System.Drawing.Color.White;
            this.lblClosingTime.Location = new System.Drawing.Point(599, 301);
            this.lblClosingTime.Name = "lblClosingTime";
            this.lblClosingTime.Size = new System.Drawing.Size(99, 22);
            this.lblClosingTime.TabIndex = 39;
            this.lblClosingTime.Text = "Closing Time";
            // 
            // dtpClosingTime
            // 
            this.dtpClosingTime.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpClosingTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClosingTime.Location = new System.Drawing.Point(603, 326);
            this.dtpClosingTime.Name = "dtpClosingTime";
            this.dtpClosingTime.ShowUpDown = true;
            this.dtpClosingTime.Size = new System.Drawing.Size(182, 27);
            this.dtpClosingTime.TabIndex = 40;
            this.dtpClosingTime.Value = new System.DateTime(2024, 12, 6, 0, 0, 0, 0);
            this.dtpClosingTime.ValueChanged += new System.EventHandler(this.dtpClosingTime_ValueChanged);
            // 
            // lblSpaceDescription
            // 
            this.lblSpaceDescription.AutoSize = true;
            this.lblSpaceDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceDescription.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceDescription.ForeColor = System.Drawing.Color.White;
            this.lblSpaceDescription.Location = new System.Drawing.Point(33, 119);
            this.lblSpaceDescription.Name = "lblSpaceDescription";
            this.lblSpaceDescription.Size = new System.Drawing.Size(135, 22);
            this.lblSpaceDescription.TabIndex = 16;
            this.lblSpaceDescription.Text = "Space Description";
            // 
            // txtSpaceDescription
            // 
            this.txtSpaceDescription.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpaceDescription.Location = new System.Drawing.Point(37, 144);
            this.txtSpaceDescription.Multiline = true;
            this.txtSpaceDescription.Name = "txtSpaceDescription";
            this.txtSpaceDescription.Size = new System.Drawing.Size(182, 83);
            this.txtSpaceDescription.TabIndex = 17;
            this.txtSpaceDescription.TextChanged += new System.EventHandler(this.txtSpaceDescription_TextChanged);
            // 
            // AdminSpaceCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpClosingTime);
            this.Controls.Add(this.lblClosingTime);
            this.Controls.Add(this.lblSpaceOpningTime);
            this.Controls.Add(this.dtpOpeningTime);
            this.Controls.Add(this.numCapacityLimit);
            this.Controls.Add(this.lblCapacityLimit);
            this.Controls.Add(this.cmbSpaceType);
            this.Controls.Add(this.lblSpaceType);
            this.Controls.Add(this.btnCreateSpace);
            this.Controls.Add(this.btnCancelForm);
            this.Controls.Add(this.txtSpacelocation);
            this.Controls.Add(this.lblSpaceLocation);
            this.Controls.Add(this.txtSpaceDescription);
            this.Controls.Add(this.lblSpaceDescription);
            this.Controls.Add(this.txtSpaceName);
            this.Controls.Add(this.lblSpaceName);
            this.Name = "AdminSpaceCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSpaceCreateForm";
            ((System.ComponentModel.ISupportInitialize)(this.numCapacityLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpaceName;
        private System.Windows.Forms.TextBox txtSpaceName;
        private System.Windows.Forms.Label lblSpaceLocation;
        private System.Windows.Forms.TextBox txtSpacelocation;
        private System.Windows.Forms.Button btnCancelForm;
        private System.Windows.Forms.Button btnCreateSpace;
        private System.Windows.Forms.Label lblSpaceType;
        private System.Windows.Forms.ComboBox cmbSpaceType;
        private System.Windows.Forms.Label lblCapacityLimit;
        private System.Windows.Forms.NumericUpDown numCapacityLimit;
        private System.Windows.Forms.DateTimePicker dtpOpeningTime;
        private System.Windows.Forms.Label lblSpaceOpningTime;
        private System.Windows.Forms.Label lblClosingTime;
        private System.Windows.Forms.DateTimePicker dtpClosingTime;
        private System.Windows.Forms.Label lblSpaceDescription;
        private System.Windows.Forms.TextBox txtSpaceDescription;
    }
}