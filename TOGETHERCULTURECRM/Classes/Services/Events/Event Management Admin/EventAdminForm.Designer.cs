namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin
{
    partial class EventAdminForm
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
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.lblManageEvents = new System.Windows.Forms.Label();
            this.btnOpenCreateEventForm = new System.Windows.Forms.Button();
            this.lblLetsHost = new System.Windows.Forms.Label();
            this.lblWhenNoEvents = new System.Windows.Forms.Label();
            this.pnlEventPosts = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(624, 545);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(111, 38);
            this.btnNextPage.TabIndex = 7;
            this.btnNextPage.Text = "Next >";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.Location = new System.Drawing.Point(492, 545);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(111, 38);
            this.btnPreviousPage.TabIndex = 8;
            this.btnPreviousPage.Text = "< Previous";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // lblManageEvents
            // 
            this.lblManageEvents.AutoSize = true;
            this.lblManageEvents.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEvents.Font = new System.Drawing.Font("Poppins", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblManageEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.lblManageEvents.Location = new System.Drawing.Point(12, 9);
            this.lblManageEvents.Name = "lblManageEvents";
            this.lblManageEvents.Size = new System.Drawing.Size(243, 50);
            this.lblManageEvents.TabIndex = 10;
            this.lblManageEvents.Text = "Manage Events";
            // 
            // btnOpenCreateEventForm
            // 
            this.btnOpenCreateEventForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnOpenCreateEventForm.FlatAppearance.BorderSize = 0;
            this.btnOpenCreateEventForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCreateEventForm.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCreateEventForm.ForeColor = System.Drawing.Color.White;
            this.btnOpenCreateEventForm.Location = new System.Drawing.Point(988, 18);
            this.btnOpenCreateEventForm.Name = "btnOpenCreateEventForm";
            this.btnOpenCreateEventForm.Size = new System.Drawing.Size(120, 38);
            this.btnOpenCreateEventForm.TabIndex = 11;
            this.btnOpenCreateEventForm.Text = "Create New +";
            this.btnOpenCreateEventForm.UseVisualStyleBackColor = false;
            this.btnOpenCreateEventForm.Click += new System.EventHandler(this.btnOpenCreateEventForm_Click);
            // 
            // lblLetsHost
            // 
            this.lblLetsHost.AutoSize = true;
            this.lblLetsHost.BackColor = System.Drawing.Color.Transparent;
            this.lblLetsHost.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblLetsHost.ForeColor = System.Drawing.Color.Black;
            this.lblLetsHost.Location = new System.Drawing.Point(463, 22);
            this.lblLetsHost.Name = "lblLetsHost";
            this.lblLetsHost.Size = new System.Drawing.Size(258, 30);
            this.lblLetsHost.TabIndex = 12;
            this.lblLetsHost.Text = "lets host something exciting";
            // 
            // lblWhenNoEvents
            // 
            this.lblWhenNoEvents.AutoSize = true;
            this.lblWhenNoEvents.BackColor = System.Drawing.Color.Transparent;
            this.lblWhenNoEvents.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblWhenNoEvents.ForeColor = System.Drawing.Color.Black;
            this.lblWhenNoEvents.Location = new System.Drawing.Point(444, 77);
            this.lblWhenNoEvents.Name = "lblWhenNoEvents";
            this.lblWhenNoEvents.Size = new System.Drawing.Size(309, 30);
            this.lblWhenNoEvents.TabIndex = 34;
            this.lblWhenNoEvents.Text = "Sorry No UP Coming Events ATM :(";
            this.lblWhenNoEvents.Click += new System.EventHandler(this.lblWhenNoEvents_Click);
            // 
            // pnlEventPosts
            // 
            this.pnlEventPosts.AutoScroll = true;
            this.pnlEventPosts.Location = new System.Drawing.Point(12, 110);
            this.pnlEventPosts.Name = "pnlEventPosts";
            this.pnlEventPosts.Size = new System.Drawing.Size(1148, 418);
            this.pnlEventPosts.TabIndex = 35;
            // 
            // EventAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 651);
            this.Controls.Add(this.lblWhenNoEvents);
            this.Controls.Add(this.pnlEventPosts);
            this.Controls.Add(this.lblLetsHost);
            this.Controls.Add(this.btnOpenCreateEventForm);
            this.Controls.Add(this.lblManageEvents);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventAdminForm";
            this.Text = "EventAdminForm";
            this.Load += new System.EventHandler(this.EventAdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Label lblManageEvents;
        private System.Windows.Forms.Button btnOpenCreateEventForm;
        private System.Windows.Forms.Label lblLetsHost;
        private System.Windows.Forms.Label lblWhenNoEvents;
        private System.Windows.Forms.Panel pnlEventPosts;
    }
}