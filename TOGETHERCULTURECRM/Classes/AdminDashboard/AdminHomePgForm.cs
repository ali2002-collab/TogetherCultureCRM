using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.AdminDashboard.ApproveMembers;
using TOGETHERCULTURECRM.Classes.Auth;
using TOGETHERCULTURECRM.Classes.DbManager;
using TOGETHERCULTURECRM.Classes.MembersDashboard.Home;
using TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin;
using TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Admin;

namespace TOGETHERCULTURECRM.Classes.AdminDashboard
{
    public partial class AdminHomePgForm : Form
    {
        private Button activeButton = null; // Track the currently active button
        private Color defaultButtonColor = Color.FromArgb(210, 20, 50); // Default button color
        private Color activeButtonColor = Color.FromArgb(72, 19, 38);  // Selected button color
        public AdminHomePgForm()
        {
            InitializeComponent();
            LoadDefaultPage();
        }
        private void LoadDefaultPage()
        {
            // Simulate a click on the HomePage navigator button to load it by default
            BtnHomePageNavigatorAdmin_Click(BtnHomePageNavigatorAdmin, EventArgs.Empty);
        }

        private void SetActiveButton(Button button)
        {
            // Reset the color of the previously active button
            if (activeButton != null)
            {
                activeButton.BackColor = defaultButtonColor;
            }

            // Highlight the currently active button
            activeButton = button;
            activeButton.BackColor = activeButtonColor;
        }

        private void LoadFormIntoPanel(Form form)
        {
            // Clear the current content of the main panel
            panelMainPgAdmin.Controls.Clear();

            // Set up the new form to fill the panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Add the form to the panel and show it
            panelMainPgAdmin.Controls.Add(form);
            form.Show();
        }
        private void UpdateIsOnlineStatus(int userId, bool isOnline)
        {
            string query = "UPDATE Users SET is_online = @IsOnline WHERE user_id = @UserId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IsOnline", isOnline ? 1 : 0),
                new SqlParameter("@UserId", userId)
            };

            DbHelper dbHelper = new DbHelper();
            dbHelper.ExecuteNonQuery(query, parameters);
        }

        private void BtnHomePageNavigatorAdmin_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);

            // Load the HomePage form into the main panel
            //HomeForm homeform = new HomeForm(); // Replace with your actual HomePage form
            //LoadFormIntoPanel(homeform);
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
           SetActiveButton(sender as Button);
           ApproveMembersForm ApproveMembersForm = new ApproveMembersForm();
           LoadFormIntoPanel(ApproveMembersForm);
            
        }

        private void btnManageEvents_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            EventAdminForm eventAdminForm = new EventAdminForm();
            LoadFormIntoPanel(eventAdminForm);
        }

        private void btnManageSpaceBook_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            SpaceAdminForm spaceAdminForm = new SpaceAdminForm();
            LoadFormIntoPanel(spaceAdminForm);
        }

        private void linkSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnNotification_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Confirm logout action
            var confirmResult = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                // Update is_online to false (0)
                UpdateIsOnlineStatus(LoggedInUser.UserId, false);

                // Clear the logged-in user details
                LoggedInUser.Clear();

                // Close the current member dashboard form
                this.Close();
            }
        }
    }
}
