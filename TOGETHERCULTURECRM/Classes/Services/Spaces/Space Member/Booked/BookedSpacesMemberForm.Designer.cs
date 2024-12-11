namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Member.Booked
{
    partial class BookedSpacesMemberForm
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
            this.dataGridViewListOfBookedSpaces = new System.Windows.Forms.DataGridView();
            this.btnLoadMemberBookedSpaces = new System.Windows.Forms.Button();
            this.btnMemberUnbookSpaces = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfBookedSpaces)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListOfBookedSpaces
            // 
            this.dataGridViewListOfBookedSpaces.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListOfBookedSpaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOfBookedSpaces.Location = new System.Drawing.Point(260, 53);
            this.dataGridViewListOfBookedSpaces.Name = "dataGridViewListOfBookedSpaces";
            this.dataGridViewListOfBookedSpaces.Size = new System.Drawing.Size(330, 224);
            this.dataGridViewListOfBookedSpaces.TabIndex = 0;
            this.dataGridViewListOfBookedSpaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListOfBookedSpaces_CellContentClick);
            // 
            // btnLoadMemberBookedSpaces
            // 
            this.btnLoadMemberBookedSpaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnLoadMemberBookedSpaces.FlatAppearance.BorderSize = 0;
            this.btnLoadMemberBookedSpaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadMemberBookedSpaces.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadMemberBookedSpaces.ForeColor = System.Drawing.Color.White;
            this.btnLoadMemberBookedSpaces.Location = new System.Drawing.Point(376, 293);
            this.btnLoadMemberBookedSpaces.Name = "btnLoadMemberBookedSpaces";
            this.btnLoadMemberBookedSpaces.Size = new System.Drawing.Size(103, 38);
            this.btnLoadMemberBookedSpaces.TabIndex = 16;
            this.btnLoadMemberBookedSpaces.Text = "Load";
            this.btnLoadMemberBookedSpaces.UseVisualStyleBackColor = false;
            this.btnLoadMemberBookedSpaces.Click += new System.EventHandler(this.btnLoadMemberBookedSpaces_Click);
            // 
            // btnMemberUnbookSpaces
            // 
            this.btnMemberUnbookSpaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnMemberUnbookSpaces.FlatAppearance.BorderSize = 0;
            this.btnMemberUnbookSpaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberUnbookSpaces.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberUnbookSpaces.ForeColor = System.Drawing.Color.White;
            this.btnMemberUnbookSpaces.Location = new System.Drawing.Point(609, 144);
            this.btnMemberUnbookSpaces.Name = "btnMemberUnbookSpaces";
            this.btnMemberUnbookSpaces.Size = new System.Drawing.Size(103, 38);
            this.btnMemberUnbookSpaces.TabIndex = 17;
            this.btnMemberUnbookSpaces.Text = "Delete";
            this.btnMemberUnbookSpaces.UseVisualStyleBackColor = false;
            this.btnMemberUnbookSpaces.Click += new System.EventHandler(this.btnMemberUnbookSpaces_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(376, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 38);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BookedSpacesMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMemberUnbookSpaces);
            this.Controls.Add(this.btnLoadMemberBookedSpaces);
            this.Controls.Add(this.dataGridViewListOfBookedSpaces);
            this.Name = "BookedSpacesMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookedSpacesMemberForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfBookedSpaces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListOfBookedSpaces;
        private System.Windows.Forms.Button btnLoadMemberBookedSpaces;
        private System.Windows.Forms.Button btnMemberUnbookSpaces;
        private System.Windows.Forms.Button btnCancel;
    }
}