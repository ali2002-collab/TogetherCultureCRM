namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Member
{
    partial class EventMemberForm
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
            this.lblMemberEvents = new System.Windows.Forms.Label();
            this.pnlMemberEventPosts = new System.Windows.Forms.Panel();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnOpenAttendingEventsListForm = new System.Windows.Forms.Button();
            this.lblWhenNoEvents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMemberEvents
            // 
            this.lblMemberEvents.AutoSize = true;
            this.lblMemberEvents.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberEvents.Font = new System.Drawing.Font("Poppins", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblMemberEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.lblMemberEvents.Location = new System.Drawing.Point(7, 9);
            this.lblMemberEvents.Name = "lblMemberEvents";
            this.lblMemberEvents.Size = new System.Drawing.Size(118, 50);
            this.lblMemberEvents.TabIndex = 11;
            this.lblMemberEvents.Text = "Events";
            // 
            // pnlMemberEventPosts
            // 
            this.pnlMemberEventPosts.AutoScroll = true;
            this.pnlMemberEventPosts.Location = new System.Drawing.Point(4, 60);
            this.pnlMemberEventPosts.Name = "pnlMemberEventPosts";
            this.pnlMemberEventPosts.Size = new System.Drawing.Size(1148, 462);
            this.pnlMemberEventPosts.TabIndex = 36;
            this.pnlMemberEventPosts.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMemberEventPosts_Paint);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.Location = new System.Drawing.Point(459, 528);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(111, 38);
            this.btnPreviousPage.TabIndex = 37;
            this.btnPreviousPage.Text = "< Previous";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(576, 528);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(111, 38);
            this.btnNextPage.TabIndex = 38;
            this.btnNextPage.Text = "Next >";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnOpenAttendingEventsListForm
            // 
            this.btnOpenAttendingEventsListForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnOpenAttendingEventsListForm.FlatAppearance.BorderSize = 0;
            this.btnOpenAttendingEventsListForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAttendingEventsListForm.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAttendingEventsListForm.ForeColor = System.Drawing.Color.White;
            this.btnOpenAttendingEventsListForm.Location = new System.Drawing.Point(994, 16);
            this.btnOpenAttendingEventsListForm.Name = "btnOpenAttendingEventsListForm";
            this.btnOpenAttendingEventsListForm.Size = new System.Drawing.Size(150, 38);
            this.btnOpenAttendingEventsListForm.TabIndex = 39;
            this.btnOpenAttendingEventsListForm.Text = "Events Attending";
            this.btnOpenAttendingEventsListForm.UseVisualStyleBackColor = false;
            this.btnOpenAttendingEventsListForm.Click += new System.EventHandler(this.btnOpenAttendingEventsListForm_Click);
            // 
            // lblWhenNoEvents
            // 
            this.lblWhenNoEvents.AutoSize = true;
            this.lblWhenNoEvents.BackColor = System.Drawing.Color.Transparent;
            this.lblWhenNoEvents.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblWhenNoEvents.ForeColor = System.Drawing.Color.Black;
            this.lblWhenNoEvents.Location = new System.Drawing.Point(436, 24);
            this.lblWhenNoEvents.Name = "lblWhenNoEvents";
            this.lblWhenNoEvents.Size = new System.Drawing.Size(309, 30);
            this.lblWhenNoEvents.TabIndex = 40;
            this.lblWhenNoEvents.Text = "Sorry No UP Coming Events ATM :(";
            this.lblWhenNoEvents.Click += new System.EventHandler(this.lblWhenNoEvents_Click);
            // 
            // EventMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 612);
            this.Controls.Add(this.lblWhenNoEvents);
            this.Controls.Add(this.btnOpenAttendingEventsListForm);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.pnlMemberEventPosts);
            this.Controls.Add(this.lblMemberEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventMemberForm";
            this.Text = "EventMemberForm";
            this.Load += new System.EventHandler(this.EventMemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberEvents;
        private System.Windows.Forms.Panel pnlMemberEventPosts;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnOpenAttendingEventsListForm;
        private System.Windows.Forms.Label lblWhenNoEvents;
    }
}