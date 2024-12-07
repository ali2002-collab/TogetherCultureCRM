namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Member
{
    partial class ListOfEventsPartcipating
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
            this.dataGridViewListOFEventsParticipating = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLoadEventList = new System.Windows.Forms.Button();
            this.btnNotAttend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOFEventsParticipating)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListOFEventsParticipating
            // 
            this.dataGridViewListOFEventsParticipating.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListOFEventsParticipating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOFEventsParticipating.Location = new System.Drawing.Point(237, 64);
            this.dataGridViewListOFEventsParticipating.Name = "dataGridViewListOFEventsParticipating";
            this.dataGridViewListOFEventsParticipating.ReadOnly = true;
            this.dataGridViewListOFEventsParticipating.Size = new System.Drawing.Size(313, 234);
            this.dataGridViewListOFEventsParticipating.TabIndex = 0;
            this.dataGridViewListOFEventsParticipating.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListOFEventsParticipating_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(321, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 38);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLoadEventList
            // 
            this.btnLoadEventList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnLoadEventList.FlatAppearance.BorderSize = 0;
            this.btnLoadEventList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadEventList.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadEventList.ForeColor = System.Drawing.Color.White;
            this.btnLoadEventList.Location = new System.Drawing.Point(589, 150);
            this.btnLoadEventList.Name = "btnLoadEventList";
            this.btnLoadEventList.Size = new System.Drawing.Size(150, 38);
            this.btnLoadEventList.TabIndex = 42;
            this.btnLoadEventList.Text = "Load";
            this.btnLoadEventList.UseVisualStyleBackColor = false;
            this.btnLoadEventList.Click += new System.EventHandler(this.btnLoadEventList_Click);
            // 
            // btnNotAttend
            // 
            this.btnNotAttend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnNotAttend.FlatAppearance.BorderSize = 0;
            this.btnNotAttend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotAttend.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotAttend.ForeColor = System.Drawing.Color.White;
            this.btnNotAttend.Location = new System.Drawing.Point(321, 304);
            this.btnNotAttend.Name = "btnNotAttend";
            this.btnNotAttend.Size = new System.Drawing.Size(150, 38);
            this.btnNotAttend.TabIndex = 43;
            this.btnNotAttend.Text = "Withdraw";
            this.btnNotAttend.UseVisualStyleBackColor = false;
            this.btnNotAttend.Click += new System.EventHandler(this.btnNotAttend_Click);
            // 
            // ListOfEventsPartcipating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNotAttend);
            this.Controls.Add(this.btnLoadEventList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridViewListOFEventsParticipating);
            this.Name = "ListOfEventsPartcipating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOFEventsParticipating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListOFEventsParticipating;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoadEventList;
        private System.Windows.Forms.Button btnNotAttend;
    }
}