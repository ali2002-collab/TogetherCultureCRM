using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Services.Membership;
using TOGETHERCULTURECRM.Classes.Auth;

namespace TOGETHERCULTURECRM.Classes.Services.Membership
{
    // Form for selecting and submitting a membership plan in the Together Culture CRM application
    public partial class SelectMembershipPlanForm : Form
    {
        // Instance of MembershipManager to handle membership-related operations
        private MembershipManager membershipManager = new MembershipManager();

        // Constructor to initialize the form and load membership plans
        public SelectMembershipPlanForm()
        {
            InitializeComponent();
            LoadMembershipPlans(); // Load membership plans into the ComboBox
        }

        // Method to load membership plans into the ComboBox for user selection
        private void LoadMembershipPlans()
        {
            // List of membership plans with corresponding IDs and names
            List<KeyValuePair<int, string>> membershipPlans = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(4, "Community"),
                new KeyValuePair<int, string>(5, "Key-Access"),
                new KeyValuePair<int, string>(6, "Premium")
            };

            // Set the data source for the ComboBox
            PlanSelection.DataSource = membershipPlans;
            PlanSelection.DisplayMember = "Value"; // Display the plan name
            PlanSelection.ValueMember = "Key"; // Use the plan ID as the value
        }

        // Event handler for when the selected membership plan changes
        private void PlanSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic to handle membership plan selection, if needed
        }

        // Event handler for the "Pay Now and Interest" button click event
        private void payNowAndInterest_Click(object sender, EventArgs e)
        {
            // Ensure a plan is selected
            if (PlanSelection.SelectedItem == null)
            {
                MessageBox.Show("Please select a membership plan.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected plan ID and logged-in user ID
            int selectedPlanId = (int)PlanSelection.SelectedValue;
            int userId = LoggedInUser.UserId;

            // Submit the membership request
            bool requestSubmitted = membershipManager.SubmitMembershipRequest(userId, selectedPlanId);

            if (requestSubmitted)
            {
                MessageBox.Show("Your membership request has been sent for admin approval.", "Request Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form
            }
            else
            {
                MessageBox.Show("Failed to submit your membership request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
