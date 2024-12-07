namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin.Admin_Create_Event
{
    partial class CreateNewEventForm
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
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventDescription = new System.Windows.Forms.Label();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.txtEventLocation = new System.Windows.Forms.TextBox();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.txtEventFee = new System.Windows.Forms.TextBox();
            this.lblEventFee = new System.Windows.Forms.Label();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.lblEventType = new System.Windows.Forms.Label();
            this.numAttendanceLimit = new System.Windows.Forms.NumericUpDown();
            this.lblAttendanceLimit = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.btnCancelForm = new System.Windows.Forms.Button();
            this.picEventImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAttendanceLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEventImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(36, 83);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(182, 27);
            this.txtEventName.TabIndex = 12;
            this.txtEventName.TextChanged += new System.EventHandler(this.txtEventName_TextChanged);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.BackColor = System.Drawing.Color.Transparent;
            this.lblEventName.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.Location = new System.Drawing.Point(32, 58);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(91, 22);
            this.lblEventName.TabIndex = 13;
            this.lblEventName.Text = "Event Name";
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblEventDescription.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDescription.ForeColor = System.Drawing.Color.White;
            this.lblEventDescription.Location = new System.Drawing.Point(32, 133);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(130, 22);
            this.lblEventDescription.TabIndex = 14;
            this.lblEventDescription.Text = "Event Description";
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDescription.Location = new System.Drawing.Point(36, 158);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(182, 83);
            this.txtEventDescription.TabIndex = 15;
            this.txtEventDescription.TextChanged += new System.EventHandler(this.txtEventDescription_TextChanged);
            // 
            // txtEventLocation
            // 
            this.txtEventLocation.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventLocation.Location = new System.Drawing.Point(36, 289);
            this.txtEventLocation.Name = "txtEventLocation";
            this.txtEventLocation.Size = new System.Drawing.Size(182, 27);
            this.txtEventLocation.TabIndex = 16;
            this.txtEventLocation.TextChanged += new System.EventHandler(this.txtEventLocation_TextChanged);
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblEventLocation.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventLocation.ForeColor = System.Drawing.Color.White;
            this.lblEventLocation.Location = new System.Drawing.Point(32, 264);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(69, 22);
            this.lblEventLocation.TabIndex = 17;
            this.lblEventLocation.Text = "Location";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Location = new System.Drawing.Point(340, 222);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(152, 39);
            this.btnUploadImage.TabIndex = 20;
            this.btnUploadImage.Text = "Upload Picture";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // txtEventFee
            // 
            this.txtEventFee.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventFee.Location = new System.Drawing.Point(36, 364);
            this.txtEventFee.Name = "txtEventFee";
            this.txtEventFee.Size = new System.Drawing.Size(182, 27);
            this.txtEventFee.TabIndex = 21;
            this.txtEventFee.TextChanged += new System.EventHandler(this.txtEventFee_TextChanged);
            // 
            // lblEventFee
            // 
            this.lblEventFee.AutoSize = true;
            this.lblEventFee.BackColor = System.Drawing.Color.Transparent;
            this.lblEventFee.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventFee.ForeColor = System.Drawing.Color.White;
            this.lblEventFee.Location = new System.Drawing.Point(32, 339);
            this.lblEventFee.Name = "lblEventFee";
            this.lblEventFee.Size = new System.Drawing.Size(33, 22);
            this.lblEventFee.TabIndex = 22;
            this.lblEventFee.Text = "Fee";
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateEvent.FlatAppearance.BorderSize = 0;
            this.btnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEvent.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEvent.ForeColor = System.Drawing.Color.White;
            this.btnCreateEvent.Location = new System.Drawing.Point(353, 362);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(127, 32);
            this.btnCreateEvent.TabIndex = 23;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = false;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // cmbEventType
            // 
            this.cmbEventType.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Items.AddRange(new object[] {
            "Citizenship",
            "Wellbeing"});
            this.cmbEventType.Location = new System.Drawing.Point(588, 83);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(182, 27);
            this.cmbEventType.TabIndex = 24;
            this.cmbEventType.Text = "Select";
            this.cmbEventType.SelectedIndexChanged += new System.EventHandler(this.cmbEventType_SelectedIndexChanged);
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.BackColor = System.Drawing.Color.Transparent;
            this.lblEventType.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventType.ForeColor = System.Drawing.Color.White;
            this.lblEventType.Location = new System.Drawing.Point(584, 58);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(84, 22);
            this.lblEventType.TabIndex = 25;
            this.lblEventType.Text = "Event Type";
            // 
            // numAttendanceLimit
            // 
            this.numAttendanceLimit.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.numAttendanceLimit.Location = new System.Drawing.Point(588, 158);
            this.numAttendanceLimit.Name = "numAttendanceLimit";
            this.numAttendanceLimit.Size = new System.Drawing.Size(182, 27);
            this.numAttendanceLimit.TabIndex = 26;
            this.numAttendanceLimit.ValueChanged += new System.EventHandler(this.numAttendanceLimit_ValueChanged);
            // 
            // lblAttendanceLimit
            // 
            this.lblAttendanceLimit.AutoSize = true;
            this.lblAttendanceLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendanceLimit.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceLimit.ForeColor = System.Drawing.Color.White;
            this.lblAttendanceLimit.Location = new System.Drawing.Point(584, 133);
            this.lblAttendanceLimit.Name = "lblAttendanceLimit";
            this.lblAttendanceLimit.Size = new System.Drawing.Size(130, 22);
            this.lblAttendanceLimit.TabIndex = 27;
            this.lblAttendanceLimit.Text = "Event Attendance";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Location = new System.Drawing.Point(588, 244);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(182, 27);
            this.dtpEventDate.TabIndex = 28;
            this.dtpEventDate.Value = new System.DateTime(2024, 12, 6, 0, 0, 0, 0);
            this.dtpEventDate.ValueChanged += new System.EventHandler(this.dtpEventDate_ValueChanged);
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEventDate.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.ForeColor = System.Drawing.Color.White;
            this.lblEventDate.Location = new System.Drawing.Point(584, 219);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(83, 22);
            this.lblEventDate.TabIndex = 29;
            this.lblEventDate.Text = "Event Date";
            // 
            // btnCancelForm
            // 
            this.btnCancelForm.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancelForm.FlatAppearance.BorderSize = 0;
            this.btnCancelForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelForm.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelForm.ForeColor = System.Drawing.Color.White;
            this.btnCancelForm.Location = new System.Drawing.Point(353, 311);
            this.btnCancelForm.Name = "btnCancelForm";
            this.btnCancelForm.Size = new System.Drawing.Size(127, 32);
            this.btnCancelForm.TabIndex = 30;
            this.btnCancelForm.Text = "Cancel";
            this.btnCancelForm.UseVisualStyleBackColor = false;
            this.btnCancelForm.Click += new System.EventHandler(this.btnCancelForm_Click);
            // 
            // picEventImage
            // 
            this.picEventImage.BackColor = System.Drawing.Color.White;
            this.picEventImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEventImage.Location = new System.Drawing.Point(292, 51);
            this.picEventImage.Name = "picEventImage";
            this.picEventImage.Size = new System.Drawing.Size(251, 165);
            this.picEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEventImage.TabIndex = 18;
            this.picEventImage.TabStop = false;
            this.picEventImage.Click += new System.EventHandler(this.picEventImage_Click);
            // 
            // CreateNewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelForm);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.lblAttendanceLimit);
            this.Controls.Add(this.numAttendanceLimit);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.cmbEventType);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.lblEventFee);
            this.Controls.Add(this.txtEventFee);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.picEventImage);
            this.Controls.Add(this.lblEventLocation);
            this.Controls.Add(this.txtEventLocation);
            this.Controls.Add(this.txtEventDescription);
            this.Controls.Add(this.lblEventDescription);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.txtEventName);
            this.Name = "CreateNewEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.numAttendanceLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEventImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.TextBox txtEventLocation;
        private System.Windows.Forms.Label lblEventLocation;
        private System.Windows.Forms.PictureBox picEventImage;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.TextBox txtEventFee;
        private System.Windows.Forms.Label lblEventFee;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.NumericUpDown numAttendanceLimit;
        private System.Windows.Forms.Label lblAttendanceLimit;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Button btnCancelForm;
    }
}