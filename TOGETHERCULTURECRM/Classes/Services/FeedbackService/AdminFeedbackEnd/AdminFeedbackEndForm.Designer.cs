namespace TOGETHERCULTURECRM.Classes.Services.FeedbackService.AdminFeedbackEnd
{
    partial class AdminFeedbackEndForm
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
            this.dgvFeedbackList = new System.Windows.Forms.DataGridView();
            this.btnLoadFeedback = new System.Windows.Forms.Button();
            this.btnDeleteFeedback = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbackList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeedbackList
            // 
            this.dgvFeedbackList.BackgroundColor = System.Drawing.Color.White;
            this.dgvFeedbackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedbackList.Location = new System.Drawing.Point(225, 64);
            this.dgvFeedbackList.Name = "dgvFeedbackList";
            this.dgvFeedbackList.Size = new System.Drawing.Size(330, 234);
            this.dgvFeedbackList.TabIndex = 0;
            this.dgvFeedbackList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedbackList_CellContentClick);
            // 
            // btnLoadFeedback
            // 
            this.btnLoadFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnLoadFeedback.FlatAppearance.BorderSize = 0;
            this.btnLoadFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFeedback.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFeedback.ForeColor = System.Drawing.Color.White;
            this.btnLoadFeedback.Location = new System.Drawing.Point(593, 94);
            this.btnLoadFeedback.Name = "btnLoadFeedback";
            this.btnLoadFeedback.Size = new System.Drawing.Size(120, 38);
            this.btnLoadFeedback.TabIndex = 16;
            this.btnLoadFeedback.Text = "Load";
            this.btnLoadFeedback.UseVisualStyleBackColor = false;
            this.btnLoadFeedback.Click += new System.EventHandler(this.btnLoadFeedback_Click);
            // 
            // btnDeleteFeedback
            // 
            this.btnDeleteFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnDeleteFeedback.FlatAppearance.BorderSize = 0;
            this.btnDeleteFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFeedback.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFeedback.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFeedback.Location = new System.Drawing.Point(593, 167);
            this.btnDeleteFeedback.Name = "btnDeleteFeedback";
            this.btnDeleteFeedback.Size = new System.Drawing.Size(120, 38);
            this.btnDeleteFeedback.TabIndex = 17;
            this.btnDeleteFeedback.Text = "Delete";
            this.btnDeleteFeedback.UseVisualStyleBackColor = false;
            this.btnDeleteFeedback.Click += new System.EventHandler(this.btnDeleteFeedback_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(593, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AdminFeedbackEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteFeedback);
            this.Controls.Add(this.btnLoadFeedback);
            this.Controls.Add(this.dgvFeedbackList);
            this.Name = "AdminFeedbackEndForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFeedbackEndForm";
            this.Load += new System.EventHandler(this.AdminFeedbackEndForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbackList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeedbackList;
        private System.Windows.Forms.Button btnLoadFeedback;
        private System.Windows.Forms.Button btnDeleteFeedback;
        private System.Windows.Forms.Button btnCancel;
    }
}