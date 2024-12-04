using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Auth;

namespace TOGETHERCULTURECRM.Classes.Services.Friends
{
    public partial class FriendsServiceForm : Form
    {
        private FriendService friendService = new FriendService();
        public FriendsServiceForm()
        {
            InitializeComponent();
        }


        private void dataGridViewFriendList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblFriendsCount_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadFriendList_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable friends = friendService.GetFriendsList(LoggedInUser.UserId);
                dataGridViewFriendList.DataSource = friends;

                lblFriendsCount.Text = $"Total Friends: {friends.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading friends list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemoveFriend_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewFriendList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a friend to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the column exists before accessing it
                if (!dataGridViewFriendList.Columns.Contains("user_id"))
                {
                    MessageBox.Show("The 'friend_id' column is missing. Please refresh the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the friend ID from the selected row
                int friendId = Convert.ToInt32(dataGridViewFriendList.SelectedRows[0].Cells["user_id"].Value);

                // Confirm removal
                if (MessageBox.Show("Do you really want to remove this friend?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (friendService.RemoveFriend(LoggedInUser.UserId, friendId))
                    {
                        MessageBox.Show("Friend removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLoadFriendList_Click(sender, e); // Reload the friend list
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove friend.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing the friend: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewAddFriends_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            if (dataGridViewAddFriends.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to send a friend request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int receiverId = (int)dataGridViewAddFriends.SelectedRows[0].Cells["user_id"].Value;

            if (friendService.SendFriendRequest(LoggedInUser.UserId, receiverId))
            {
                MessageBox.Show("Friend request sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAddConnectionLoad_Click(sender, e); // Reload list
            }
            else
            {
                MessageBox.Show("Failed to send friend request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFriendRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {
            if (dataGridViewFriendRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a friend request to reject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int requestId = (int)dataGridViewFriendRequests.SelectedRows[0].Cells["request_id"].Value;

            if (friendService.RejectFriendRequest(requestId))
            {
                MessageBox.Show("Friend request rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConnectionRequestLoad_Click(sender, e); // Reload requests
            }
            else
            {
                MessageBox.Show("Failed to reject friend request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcceptRequest_Click(object sender, EventArgs e)
        {
            if (dataGridViewFriendRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a friend request to accept.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int requestId = (int)dataGridViewFriendRequests.SelectedRows[0].Cells["request_id"].Value;
            int senderId = (int)dataGridViewFriendRequests.SelectedRows[0].Cells["sender_id"].Value;

            if (friendService.AcceptFriendRequest(requestId, senderId, LoggedInUser.UserId))
            {
                MessageBox.Show("Friend request accepted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConnectionRequestLoad_Click(sender, e); // Reload requests
                btnLoadFriendList_Click(sender, e);        // Reload friends list
            }
            else
            {
                MessageBox.Show("Failed to accept friend request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddConnectionLoad_Click(object sender, EventArgs e)
        {
            // Load the list of potential friends
            try
            {
                DataTable nonFriends = friendService.GetNonFriendsList(LoggedInUser.UserId);
                dataGridViewAddFriends.DataSource = nonFriends;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading potential connections: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnectionRequestLoad_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable friendRequests = friendService.GetPendingFriendRequests(LoggedInUser.UserId);
                dataGridViewFriendRequests.DataSource = friendRequests;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading friend requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
