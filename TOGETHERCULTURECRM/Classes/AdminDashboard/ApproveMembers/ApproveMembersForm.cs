using System;
using System.Data;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.AdminDashboard.ApproveMembers;
using TOGETHERCULTURECRM.Classes.Auth;
using TOGETHERCULTURECRM.Classes.Services.Membership;

namespace TOGETHERCULTURECRM.Classes.AdminDashboard.ApproveMembers
{
    // Form for approving membership requests in the Together Culture CRM application
    public partial class ApproveMembersForm : Form
    {
        // Instance to handle membership approvals
        private ApproveMembers approveMembers = new ApproveMembers();
        // Instance to manage membership-related operations
        private MembershipManager membershipManager = new MembershipManager();

        // Constructor to initialize the form components
        public ApproveMembersForm()
        {
            InitializeComponent();
        }

        // Event handler for loading the form
        private void ApproveMembersForm_Load(object sender, EventArgs e)
        {
            // Currently, no specific actions are defined when the form loads
        }

        // Event handler for clicking the "Approve Request" button
        private void ApproveReq_Click(object sender, EventArgs e)
        {
            // Ensure a membership request is selected in the DataGridView
            if (membershipRequestsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a membership request to approve.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if no request is selected
            }

            // Retrieve the member ID and plan ID from the selected request
            int memberId = (int)membershipRequestsGrid.SelectedRows[0].Cells["member_id"].Value;
            int planId = (int)membershipRequestsGrid.SelectedRows[0].Cells["plan_id"].Value;
            int userId = LoggedInUser.UserId; // The user ID of the logged-in admin

            // Get the admin ID corresponding to the user ID
            int adminId = approveMembers.GetAdminIdByUserId(userId);

            // Check if the admin ID is valid
            if (adminId == 0)
            {
                MessageBox.Show("Error: Admin ID does not exist in the Admin table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if the admin ID is not valid
            }

            // Attempt to approve the membership request
            bool approved = approveMembers.ApproveMembership(memberId, planId, adminId);

            if (approved)
            {
                MessageBox.Show("Membership approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the list of pending membership requests
                try
                {
                    // Fetch the updated list of pending requests and display it
                    DataTable updatedRequests = approveMembers.GetPendingMembershipRequests();
                    membershipRequestsGrid.DataSource = updatedRequests;
                }
                catch (Exception ex)
                {
                    // Show an error message if there is an issue refreshing the requests
                    MessageBox.Show($"An error occurred while refreshing requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show an error message if the approval fails
                MessageBox.Show("Failed to approve membership. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for cell content click in the DataGridView
        private void membershipRequestsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Currently, no specific actions are defined for cell content clicks
        }

        // Event handler for clicking the "Load Requests" button
        private void btnLoadRequests_Click(object sender, EventArgs e)
        {
            try
            {
                // Load pending membership requests into the DataGridView
                DataTable requests = approveMembers.GetPendingMembershipRequests();

                // Check if there are any pending requests and display them
                if (requests.Rows.Count > 0)
                {
                    membershipRequestsGrid.DataSource = requests;
                }
                else
                {
                    // Show an information message if there are no pending requests
                    MessageBox.Show("No pending membership requests found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Show an error message if there is an issue loading the requests
                MessageBox.Show($"An error occurred while loading requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
