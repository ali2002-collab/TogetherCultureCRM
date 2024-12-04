namespace TOGETHERCULTURECRM.Classes.Services.Friends
{
    partial class FriendsServiceForm
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
            this.dataGridViewFriendList = new System.Windows.Forms.DataGridView();
            this.lblWelcomeFirstName = new System.Windows.Forms.Label();
            this.btnLoadFriendList = new System.Windows.Forms.Button();
            this.btnRemoveFriend = new System.Windows.Forms.Button();
            this.lblFriendsCount = new System.Windows.Forms.Label();
            this.dataGridViewAddFriends = new System.Windows.Forms.DataGridView();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.dataGridViewFriendRequests = new System.Windows.Forms.DataGridView();
            this.btnAcceptRequest = new System.Windows.Forms.Button();
            this.btnRejectRequest = new System.Windows.Forms.Button();
            this.lblConnectionList = new System.Windows.Forms.Label();
            this.lblAddConnection = new System.Windows.Forms.Label();
            this.lblConnectionRequest = new System.Windows.Forms.Label();
            this.btnAddConnectionLoad = new System.Windows.Forms.Button();
            this.btnConnectionRequestLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFriendList
            // 
            this.dataGridViewFriendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriendList.Location = new System.Drawing.Point(33, 158);
            this.dataGridViewFriendList.Name = "dataGridViewFriendList";
            this.dataGridViewFriendList.Size = new System.Drawing.Size(317, 247);
            this.dataGridViewFriendList.TabIndex = 0;
            this.dataGridViewFriendList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFriendList_CellContentClick);
            // 
            // lblWelcomeFirstName
            // 
            this.lblWelcomeFirstName.AutoSize = true;
            this.lblWelcomeFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeFirstName.Font = new System.Drawing.Font("Poppins", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.lblWelcomeFirstName.Location = new System.Drawing.Point(474, 22);
            this.lblWelcomeFirstName.Name = "lblWelcomeFirstName";
            this.lblWelcomeFirstName.Size = new System.Drawing.Size(279, 50);
            this.lblWelcomeFirstName.TabIndex = 2;
            this.lblWelcomeFirstName.Text = "Your Connections";
            // 
            // btnLoadFriendList
            // 
            this.btnLoadFriendList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnLoadFriendList.FlatAppearance.BorderSize = 0;
            this.btnLoadFriendList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFriendList.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFriendList.ForeColor = System.Drawing.Color.White;
            this.btnLoadFriendList.Location = new System.Drawing.Point(218, 411);
            this.btnLoadFriendList.Name = "btnLoadFriendList";
            this.btnLoadFriendList.Size = new System.Drawing.Size(75, 38);
            this.btnLoadFriendList.TabIndex = 7;
            this.btnLoadFriendList.Text = "Load";
            this.btnLoadFriendList.UseVisualStyleBackColor = false;
            this.btnLoadFriendList.Click += new System.EventHandler(this.btnLoadFriendList_Click);
            // 
            // btnRemoveFriend
            // 
            this.btnRemoveFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnRemoveFriend.FlatAppearance.BorderSize = 0;
            this.btnRemoveFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFriend.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFriend.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFriend.Location = new System.Drawing.Point(308, 411);
            this.btnRemoveFriend.Name = "btnRemoveFriend";
            this.btnRemoveFriend.Size = new System.Drawing.Size(42, 38);
            this.btnRemoveFriend.TabIndex = 8;
            this.btnRemoveFriend.Text = "X";
            this.btnRemoveFriend.UseVisualStyleBackColor = false;
            this.btnRemoveFriend.Click += new System.EventHandler(this.btnRemoveFriend_Click);
            // 
            // lblFriendsCount
            // 
            this.lblFriendsCount.AutoSize = true;
            this.lblFriendsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblFriendsCount.Font = new System.Drawing.Font("Poppins", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblFriendsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.lblFriendsCount.Location = new System.Drawing.Point(28, 418);
            this.lblFriendsCount.Name = "lblFriendsCount";
            this.lblFriendsCount.Size = new System.Drawing.Size(151, 26);
            this.lblFriendsCount.TabIndex = 9;
            this.lblFriendsCount.Text = "Connection Count";
            this.lblFriendsCount.Click += new System.EventHandler(this.lblFriendsCount_Click);
            // 
            // dataGridViewAddFriends
            // 
            this.dataGridViewAddFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddFriends.Location = new System.Drawing.Point(421, 158);
            this.dataGridViewAddFriends.Name = "dataGridViewAddFriends";
            this.dataGridViewAddFriends.Size = new System.Drawing.Size(317, 247);
            this.dataGridViewAddFriends.TabIndex = 10;
            this.dataGridViewAddFriends.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddFriends_CellContentClick);
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnAddFriend.FlatAppearance.BorderSize = 0;
            this.btnAddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFriend.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.ForeColor = System.Drawing.Color.White;
            this.btnAddFriend.Location = new System.Drawing.Point(663, 411);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(75, 38);
            this.btnAddFriend.TabIndex = 11;
            this.btnAddFriend.Text = "Add";
            this.btnAddFriend.UseVisualStyleBackColor = false;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // dataGridViewFriendRequests
            // 
            this.dataGridViewFriendRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriendRequests.Location = new System.Drawing.Point(817, 158);
            this.dataGridViewFriendRequests.Name = "dataGridViewFriendRequests";
            this.dataGridViewFriendRequests.Size = new System.Drawing.Size(317, 247);
            this.dataGridViewFriendRequests.TabIndex = 12;
            this.dataGridViewFriendRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFriendRequests_CellContentClick);
            // 
            // btnAcceptRequest
            // 
            this.btnAcceptRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnAcceptRequest.FlatAppearance.BorderSize = 0;
            this.btnAcceptRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptRequest.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptRequest.ForeColor = System.Drawing.Color.White;
            this.btnAcceptRequest.Location = new System.Drawing.Point(1059, 411);
            this.btnAcceptRequest.Name = "btnAcceptRequest";
            this.btnAcceptRequest.Size = new System.Drawing.Size(75, 38);
            this.btnAcceptRequest.TabIndex = 13;
            this.btnAcceptRequest.Text = "Accept";
            this.btnAcceptRequest.UseVisualStyleBackColor = false;
            this.btnAcceptRequest.Click += new System.EventHandler(this.btnAcceptRequest_Click);
            // 
            // btnRejectRequest
            // 
            this.btnRejectRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnRejectRequest.FlatAppearance.BorderSize = 0;
            this.btnRejectRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejectRequest.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejectRequest.ForeColor = System.Drawing.Color.White;
            this.btnRejectRequest.Location = new System.Drawing.Point(969, 411);
            this.btnRejectRequest.Name = "btnRejectRequest";
            this.btnRejectRequest.Size = new System.Drawing.Size(75, 38);
            this.btnRejectRequest.TabIndex = 14;
            this.btnRejectRequest.Text = "Reject";
            this.btnRejectRequest.UseVisualStyleBackColor = false;
            this.btnRejectRequest.Click += new System.EventHandler(this.btnRejectRequest_Click);
            // 
            // lblConnectionList
            // 
            this.lblConnectionList.AutoSize = true;
            this.lblConnectionList.BackColor = System.Drawing.Color.Transparent;
            this.lblConnectionList.Font = new System.Drawing.Font("Poppins", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblConnectionList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.lblConnectionList.Location = new System.Drawing.Point(130, 129);
            this.lblConnectionList.Name = "lblConnectionList";
            this.lblConnectionList.Size = new System.Drawing.Size(109, 26);
            this.lblConnectionList.TabIndex = 15;
            this.lblConnectionList.Text = "Connections";
            // 
            // lblAddConnection
            // 
            this.lblAddConnection.AutoSize = true;
            this.lblAddConnection.BackColor = System.Drawing.Color.Transparent;
            this.lblAddConnection.Font = new System.Drawing.Font("Poppins", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblAddConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.lblAddConnection.Location = new System.Drawing.Point(513, 129);
            this.lblAddConnection.Name = "lblAddConnection";
            this.lblAddConnection.Size = new System.Drawing.Size(135, 26);
            this.lblAddConnection.TabIndex = 16;
            this.lblAddConnection.Text = "Add Connection";
            // 
            // lblConnectionRequest
            // 
            this.lblConnectionRequest.AutoSize = true;
            this.lblConnectionRequest.BackColor = System.Drawing.Color.Transparent;
            this.lblConnectionRequest.Font = new System.Drawing.Font("Poppins", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblConnectionRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.lblConnectionRequest.Location = new System.Drawing.Point(900, 129);
            this.lblConnectionRequest.Name = "lblConnectionRequest";
            this.lblConnectionRequest.Size = new System.Drawing.Size(166, 26);
            this.lblConnectionRequest.TabIndex = 17;
            this.lblConnectionRequest.Text = "Connection Request";
            // 
            // btnAddConnectionLoad
            // 
            this.btnAddConnectionLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnAddConnectionLoad.FlatAppearance.BorderSize = 0;
            this.btnAddConnectionLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConnectionLoad.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConnectionLoad.ForeColor = System.Drawing.Color.White;
            this.btnAddConnectionLoad.Location = new System.Drawing.Point(564, 411);
            this.btnAddConnectionLoad.Name = "btnAddConnectionLoad";
            this.btnAddConnectionLoad.Size = new System.Drawing.Size(75, 38);
            this.btnAddConnectionLoad.TabIndex = 18;
            this.btnAddConnectionLoad.Text = "Load";
            this.btnAddConnectionLoad.UseVisualStyleBackColor = false;
            this.btnAddConnectionLoad.Click += new System.EventHandler(this.btnAddConnectionLoad_Click);
            // 
            // btnConnectionRequestLoad
            // 
            this.btnConnectionRequestLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnConnectionRequestLoad.FlatAppearance.BorderSize = 0;
            this.btnConnectionRequestLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectionRequestLoad.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectionRequestLoad.ForeColor = System.Drawing.Color.White;
            this.btnConnectionRequestLoad.Location = new System.Drawing.Point(878, 411);
            this.btnConnectionRequestLoad.Name = "btnConnectionRequestLoad";
            this.btnConnectionRequestLoad.Size = new System.Drawing.Size(75, 38);
            this.btnConnectionRequestLoad.TabIndex = 19;
            this.btnConnectionRequestLoad.Text = "Load";
            this.btnConnectionRequestLoad.UseVisualStyleBackColor = false;
            this.btnConnectionRequestLoad.Click += new System.EventHandler(this.btnConnectionRequestLoad_Click);
            // 
            // FriendsServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 651);
            this.Controls.Add(this.btnConnectionRequestLoad);
            this.Controls.Add(this.btnAddConnectionLoad);
            this.Controls.Add(this.lblConnectionRequest);
            this.Controls.Add(this.lblAddConnection);
            this.Controls.Add(this.lblConnectionList);
            this.Controls.Add(this.btnRejectRequest);
            this.Controls.Add(this.btnAcceptRequest);
            this.Controls.Add(this.dataGridViewFriendRequests);
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.dataGridViewAddFriends);
            this.Controls.Add(this.lblFriendsCount);
            this.Controls.Add(this.btnRemoveFriend);
            this.Controls.Add(this.btnLoadFriendList);
            this.Controls.Add(this.lblWelcomeFirstName);
            this.Controls.Add(this.dataGridViewFriendList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FriendsServiceForm";
            this.Text = "FriendsServiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFriendList;
        private System.Windows.Forms.Label lblWelcomeFirstName;
        private System.Windows.Forms.Button btnLoadFriendList;
        private System.Windows.Forms.Button btnRemoveFriend;
        private System.Windows.Forms.Label lblFriendsCount;
        private System.Windows.Forms.DataGridView dataGridViewAddFriends;
        private System.Windows.Forms.Button btnAddFriend;
        private System.Windows.Forms.DataGridView dataGridViewFriendRequests;
        private System.Windows.Forms.Button btnAcceptRequest;
        private System.Windows.Forms.Button btnRejectRequest;
        private System.Windows.Forms.Label lblConnectionList;
        private System.Windows.Forms.Label lblAddConnection;
        private System.Windows.Forms.Label lblConnectionRequest;
        private System.Windows.Forms.Button btnAddConnectionLoad;
        private System.Windows.Forms.Button btnConnectionRequestLoad;
    }
}