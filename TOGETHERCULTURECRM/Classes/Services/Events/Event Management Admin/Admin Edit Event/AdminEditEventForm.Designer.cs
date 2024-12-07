namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin.Admin_Edit_Event
{
    partial class AdminEditEventForm
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
            this.lblEditEventName = new System.Windows.Forms.Label();
            this.txtEditEventName = new System.Windows.Forms.TextBox();
            this.lblEditEventDescription = new System.Windows.Forms.Label();
            this.txtEditEventDescription = new System.Windows.Forms.TextBox();
            this.lblEditEventLocation = new System.Windows.Forms.Label();
            this.txtEditEventLocation = new System.Windows.Forms.TextBox();
            this.lblEditEventFee = new System.Windows.Forms.Label();
            this.txtEditEventFee = new System.Windows.Forms.TextBox();
            this.btnEditUploadImage = new System.Windows.Forms.Button();
            this.btnCancelForm = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.lblEditEventType = new System.Windows.Forms.Label();
            this.cmbEditEventType = new System.Windows.Forms.ComboBox();
            this.picEditEventImage = new System.Windows.Forms.PictureBox();
            this.lblEditAttendanceLimit = new System.Windows.Forms.Label();
            this.numEditAttendanceLimit = new System.Windows.Forms.NumericUpDown();
            this.lblEditEventDate = new System.Windows.Forms.Label();
            this.dtpEditEventDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picEditEventImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEditAttendanceLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditEventName
            // 
            this.lblEditEventName.AutoSize = true;
            this.lblEditEventName.BackColor = System.Drawing.Color.Transparent;
            this.lblEditEventName.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventName.ForeColor = System.Drawing.Color.White;
            this.lblEditEventName.Location = new System.Drawing.Point(32, 58);
            this.lblEditEventName.Name = "lblEditEventName";
            this.lblEditEventName.Size = new System.Drawing.Size(91, 22);
            this.lblEditEventName.TabIndex = 20;
            this.lblEditEventName.Text = "Event Name";
            // 
            // txtEditEventName
            // 
            this.txtEditEventName.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEventName.Location = new System.Drawing.Point(36, 83);
            this.txtEditEventName.Name = "txtEditEventName";
            this.txtEditEventName.Size = new System.Drawing.Size(182, 27);
            this.txtEditEventName.TabIndex = 21;
            this.txtEditEventName.TextChanged += new System.EventHandler(this.txtEditEventName_TextChanged);
            // 
            // lblEditEventDescription
            // 
            this.lblEditEventDescription.AutoSize = true;
            this.lblEditEventDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblEditEventDescription.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventDescription.ForeColor = System.Drawing.Color.White;
            this.lblEditEventDescription.Location = new System.Drawing.Point(32, 139);
            this.lblEditEventDescription.Name = "lblEditEventDescription";
            this.lblEditEventDescription.Size = new System.Drawing.Size(130, 22);
            this.lblEditEventDescription.TabIndex = 22;
            this.lblEditEventDescription.Text = "Event Description";
            // 
            // txtEditEventDescription
            // 
            this.txtEditEventDescription.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEventDescription.Location = new System.Drawing.Point(36, 164);
            this.txtEditEventDescription.Multiline = true;
            this.txtEditEventDescription.Name = "txtEditEventDescription";
            this.txtEditEventDescription.Size = new System.Drawing.Size(182, 83);
            this.txtEditEventDescription.TabIndex = 23;
            this.txtEditEventDescription.TextChanged += new System.EventHandler(this.txtEditEventDescription_TextChanged);
            // 
            // lblEditEventLocation
            // 
            this.lblEditEventLocation.AutoSize = true;
            this.lblEditEventLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblEditEventLocation.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventLocation.ForeColor = System.Drawing.Color.White;
            this.lblEditEventLocation.Location = new System.Drawing.Point(32, 278);
            this.lblEditEventLocation.Name = "lblEditEventLocation";
            this.lblEditEventLocation.Size = new System.Drawing.Size(69, 22);
            this.lblEditEventLocation.TabIndex = 24;
            this.lblEditEventLocation.Text = "Location";
            // 
            // txtEditEventLocation
            // 
            this.txtEditEventLocation.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEventLocation.Location = new System.Drawing.Point(36, 303);
            this.txtEditEventLocation.Name = "txtEditEventLocation";
            this.txtEditEventLocation.Size = new System.Drawing.Size(182, 27);
            this.txtEditEventLocation.TabIndex = 25;
            this.txtEditEventLocation.TextChanged += new System.EventHandler(this.txtEditEventLocation_TextChanged);
            // 
            // lblEditEventFee
            // 
            this.lblEditEventFee.AutoSize = true;
            this.lblEditEventFee.BackColor = System.Drawing.Color.Transparent;
            this.lblEditEventFee.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventFee.ForeColor = System.Drawing.Color.White;
            this.lblEditEventFee.Location = new System.Drawing.Point(32, 351);
            this.lblEditEventFee.Name = "lblEditEventFee";
            this.lblEditEventFee.Size = new System.Drawing.Size(33, 22);
            this.lblEditEventFee.TabIndex = 26;
            this.lblEditEventFee.Text = "Fee";
            // 
            // txtEditEventFee
            // 
            this.txtEditEventFee.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEventFee.Location = new System.Drawing.Point(36, 376);
            this.txtEditEventFee.Name = "txtEditEventFee";
            this.txtEditEventFee.Size = new System.Drawing.Size(182, 27);
            this.txtEditEventFee.TabIndex = 27;
            this.txtEditEventFee.TextChanged += new System.EventHandler(this.txtEditEventFee_TextChanged);
            // 
            // btnEditUploadImage
            // 
            this.btnEditUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnEditUploadImage.FlatAppearance.BorderSize = 0;
            this.btnEditUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUploadImage.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnEditUploadImage.Location = new System.Drawing.Point(341, 222);
            this.btnEditUploadImage.Name = "btnEditUploadImage";
            this.btnEditUploadImage.Size = new System.Drawing.Size(152, 39);
            this.btnEditUploadImage.TabIndex = 28;
            this.btnEditUploadImage.Text = "Change Picture";
            this.btnEditUploadImage.UseVisualStyleBackColor = false;
            this.btnEditUploadImage.Click += new System.EventHandler(this.btnEditUploadImage_Click);
            // 
            // btnCancelForm
            // 
            this.btnCancelForm.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancelForm.FlatAppearance.BorderSize = 0;
            this.btnCancelForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelForm.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelForm.ForeColor = System.Drawing.Color.White;
            this.btnCancelForm.Location = new System.Drawing.Point(353, 301);
            this.btnCancelForm.Name = "btnCancelForm";
            this.btnCancelForm.Size = new System.Drawing.Size(127, 32);
            this.btnCancelForm.TabIndex = 31;
            this.btnCancelForm.Text = "Cancel";
            this.btnCancelForm.UseVisualStyleBackColor = false;
            this.btnCancelForm.Click += new System.EventHandler(this.btnCancelForm_Click);
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateEvent.FlatAppearance.BorderSize = 0;
            this.btnUpdateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEvent.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEvent.Location = new System.Drawing.Point(353, 351);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(127, 32);
            this.btnUpdateEvent.TabIndex = 32;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = false;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // lblEditEventType
            // 
            this.lblEditEventType.AutoSize = true;
            this.lblEditEventType.BackColor = System.Drawing.Color.Transparent;
            this.lblEditEventType.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventType.ForeColor = System.Drawing.Color.White;
            this.lblEditEventType.Location = new System.Drawing.Point(584, 58);
            this.lblEditEventType.Name = "lblEditEventType";
            this.lblEditEventType.Size = new System.Drawing.Size(84, 22);
            this.lblEditEventType.TabIndex = 33;
            this.lblEditEventType.Text = "Event Type";
            // 
            // cmbEditEventType
            // 
            this.cmbEditEventType.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditEventType.FormattingEnabled = true;
            this.cmbEditEventType.Items.AddRange(new object[] {
            "Citizenship",
            "Wellbeing"});
            this.cmbEditEventType.Location = new System.Drawing.Point(588, 83);
            this.cmbEditEventType.Name = "cmbEditEventType";
            this.cmbEditEventType.Size = new System.Drawing.Size(182, 27);
            this.cmbEditEventType.TabIndex = 34;
            this.cmbEditEventType.Text = "Select";
            this.cmbEditEventType.SelectedIndexChanged += new System.EventHandler(this.cmbEditEventType_SelectedIndexChanged);
            // 
            // picEditEventImage
            // 
            this.picEditEventImage.BackColor = System.Drawing.Color.White;
            this.picEditEventImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEditEventImage.Location = new System.Drawing.Point(292, 51);
            this.picEditEventImage.Name = "picEditEventImage";
            this.picEditEventImage.Size = new System.Drawing.Size(251, 165);
            this.picEditEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEditEventImage.TabIndex = 19;
            this.picEditEventImage.TabStop = false;
            this.picEditEventImage.Click += new System.EventHandler(this.picEditEventImage_Click);
            // 
            // lblEditAttendanceLimit
            // 
            this.lblEditAttendanceLimit.AutoSize = true;
            this.lblEditAttendanceLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblEditAttendanceLimit.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditAttendanceLimit.ForeColor = System.Drawing.Color.White;
            this.lblEditAttendanceLimit.Location = new System.Drawing.Point(584, 139);
            this.lblEditAttendanceLimit.Name = "lblEditAttendanceLimit";
            this.lblEditAttendanceLimit.Size = new System.Drawing.Size(130, 22);
            this.lblEditAttendanceLimit.TabIndex = 35;
            this.lblEditAttendanceLimit.Text = "Event Attendance";
            // 
            // numEditAttendanceLimit
            // 
            this.numEditAttendanceLimit.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.numEditAttendanceLimit.Location = new System.Drawing.Point(588, 165);
            this.numEditAttendanceLimit.Name = "numEditAttendanceLimit";
            this.numEditAttendanceLimit.Size = new System.Drawing.Size(182, 27);
            this.numEditAttendanceLimit.TabIndex = 36;
            this.numEditAttendanceLimit.ValueChanged += new System.EventHandler(this.numEditAttendanceLimit_ValueChanged);
            // 
            // lblEditEventDate
            // 
            this.lblEditEventDate.AutoSize = true;
            this.lblEditEventDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEditEventDate.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEventDate.ForeColor = System.Drawing.Color.White;
            this.lblEditEventDate.Location = new System.Drawing.Point(584, 222);
            this.lblEditEventDate.Name = "lblEditEventDate";
            this.lblEditEventDate.Size = new System.Drawing.Size(83, 22);
            this.lblEditEventDate.TabIndex = 37;
            this.lblEditEventDate.Text = "Event Date";
            // 
            // dtpEditEventDate
            // 
            this.dtpEditEventDate.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEditEventDate.Location = new System.Drawing.Point(588, 247);
            this.dtpEditEventDate.Name = "dtpEditEventDate";
            this.dtpEditEventDate.Size = new System.Drawing.Size(182, 27);
            this.dtpEditEventDate.TabIndex = 38;
            this.dtpEditEventDate.Value = new System.DateTime(2024, 12, 6, 0, 0, 0, 0);
            this.dtpEditEventDate.ValueChanged += new System.EventHandler(this.dtpEditEventDate_ValueChanged);
            // 
            // AdminEditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpEditEventDate);
            this.Controls.Add(this.lblEditEventDate);
            this.Controls.Add(this.numEditAttendanceLimit);
            this.Controls.Add(this.lblEditAttendanceLimit);
            this.Controls.Add(this.cmbEditEventType);
            this.Controls.Add(this.lblEditEventType);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnCancelForm);
            this.Controls.Add(this.btnEditUploadImage);
            this.Controls.Add(this.txtEditEventFee);
            this.Controls.Add(this.lblEditEventFee);
            this.Controls.Add(this.txtEditEventLocation);
            this.Controls.Add(this.lblEditEventLocation);
            this.Controls.Add(this.txtEditEventDescription);
            this.Controls.Add(this.lblEditEventDescription);
            this.Controls.Add(this.txtEditEventName);
            this.Controls.Add(this.lblEditEventName);
            this.Controls.Add(this.picEditEventImage);
            this.Name = "AdminEditEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEditEventForm";
            this.Load += new System.EventHandler(this.AdminEditEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEditEventImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEditAttendanceLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEditEventImage;
        private System.Windows.Forms.Label lblEditEventName;
        private System.Windows.Forms.TextBox txtEditEventName;
        private System.Windows.Forms.Label lblEditEventDescription;
        private System.Windows.Forms.TextBox txtEditEventDescription;
        private System.Windows.Forms.Label lblEditEventLocation;
        private System.Windows.Forms.TextBox txtEditEventLocation;
        private System.Windows.Forms.Label lblEditEventFee;
        private System.Windows.Forms.TextBox txtEditEventFee;
        private System.Windows.Forms.Button btnEditUploadImage;
        private System.Windows.Forms.Button btnCancelForm;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Label lblEditEventType;
        private System.Windows.Forms.ComboBox cmbEditEventType;
        private System.Windows.Forms.Label lblEditAttendanceLimit;
        private System.Windows.Forms.NumericUpDown numEditAttendanceLimit;
        private System.Windows.Forms.Label lblEditEventDate;
        private System.Windows.Forms.DateTimePicker dtpEditEventDate;
    }
}