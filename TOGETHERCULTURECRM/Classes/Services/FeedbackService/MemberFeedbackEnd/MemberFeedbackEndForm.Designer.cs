namespace TOGETHERCULTURECRM.Classes.Services.FeedbackService.MemberFeedbackEnd
{
    partial class MemberFeedbackEndForm
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
            this.cmbEntityType = new System.Windows.Forms.ComboBox();
            this.lblEntityType = new System.Windows.Forms.Label();
            this.txtFeedbackText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEntityType
            // 
            this.cmbEntityType.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntityType.FormattingEnabled = true;
            this.cmbEntityType.Items.AddRange(new object[] {
            "Membership",
            "Content",
            "Event"});
            this.cmbEntityType.Location = new System.Drawing.Point(326, 63);
            this.cmbEntityType.Name = "cmbEntityType";
            this.cmbEntityType.Size = new System.Drawing.Size(195, 31);
            this.cmbEntityType.TabIndex = 0;
            this.cmbEntityType.SelectedIndexChanged += new System.EventHandler(this.cmbEntityType_SelectedIndexChanged);
            // 
            // lblEntityType
            // 
            this.lblEntityType.AutoSize = true;
            this.lblEntityType.BackColor = System.Drawing.Color.Transparent;
            this.lblEntityType.Font = new System.Drawing.Font("Poppins", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblEntityType.ForeColor = System.Drawing.Color.White;
            this.lblEntityType.Location = new System.Drawing.Point(328, 37);
            this.lblEntityType.Name = "lblEntityType";
            this.lblEntityType.Size = new System.Drawing.Size(84, 23);
            this.lblEntityType.TabIndex = 11;
            this.lblEntityType.Text = "Entity Type";
            this.lblEntityType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFeedbackText
            // 
            this.txtFeedbackText.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedbackText.Location = new System.Drawing.Point(326, 145);
            this.txtFeedbackText.Multiline = true;
            this.txtFeedbackText.Name = "txtFeedbackText";
            this.txtFeedbackText.Size = new System.Drawing.Size(195, 59);
            this.txtFeedbackText.TabIndex = 12;
            this.txtFeedbackText.TextChanged += new System.EventHandler(this.feedback_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Feedback";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numRating
            // 
            this.numRating.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRating.Location = new System.Drawing.Point(326, 259);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(195, 27);
            this.numRating.TabIndex = 14;
            this.numRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.ValueChanged += new System.EventHandler(this.numRating_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(322, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rating (1-5)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnSubmitFeedback.FlatAppearance.BorderSize = 0;
            this.btnSubmitFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitFeedback.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitFeedback.ForeColor = System.Drawing.Color.White;
            this.btnSubmitFeedback.Location = new System.Drawing.Point(358, 319);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(120, 38);
            this.btnSubmitFeedback.TabIndex = 17;
            this.btnSubmitFeedback.Text = "Submit";
            this.btnSubmitFeedback.UseVisualStyleBackColor = false;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(358, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MemberFeedbackEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFeedbackText);
            this.Controls.Add(this.lblEntityType);
            this.Controls.Add(this.cmbEntityType);
            this.Name = "MemberFeedbackEndForm";
            this.Text = "MemberFeedbackEndForm";
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEntityType;
        private System.Windows.Forms.Label lblEntityType;
        private System.Windows.Forms.TextBox txtFeedbackText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmitFeedback;
        private System.Windows.Forms.Button btnCancel;
    }
}