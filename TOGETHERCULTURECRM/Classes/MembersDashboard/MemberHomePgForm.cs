using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Auth;
using TOGETHERCULTURECRM.Classes.DbManager;
using TOGETHERCULTURECRM.Classes.MembersDashboard.Home;
using TOGETHERCULTURECRM.Classes.MembersDashboard.Profile;
using TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Member;
using TOGETHERCULTURECRM.Classes.Services.FeedbackService.MemberFeedbackEnd;
using TOGETHERCULTURECRM.Classes.Services.Friends;
using TOGETHERCULTURECRM.Classes.Services.Search;
using TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Member;

namespace TOGETHERCULTURECRM.Classes.MembersDashboard
{
    public partial class MemberHomePgForm : Form
    {
        private Button activeButton = null; // Track the currently active button
        private Color defaultButtonColor = Color.FromArgb(210, 20, 50); // Default button color
        private Color activeButtonColor = Color.FromArgb(72, 19, 38);  // Selected button color
        private readonly SearchManager _searchManager = new SearchManager();

        public MemberHomePgForm()
        {
            InitializeComponent();
            LoadDefaultPage();
        }
        private void LoadDefaultPage()
        {
            // Simulate a click on the HomePage navigator button to load it by default
            BtnHomePageNavigator_Click(BtnHomePageNavigator, EventArgs.Empty);
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
            panelMainPg.Controls.Clear();

            // Set up the new form to fill the panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Add the form to the panel and show it
            panelMainPg.Controls.Add(form);
            form.Show();
        }

        //updating is_online to false once user logs out
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




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Any existing functionality for pictureBox1 click
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

        private void panelSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHomePageNavigator_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);

            // Load the HomePage form into the main panel
            HomeForm homeform = new HomeForm(); // Replace with your actual HomePage form
            LoadFormIntoPanel(homeform);

        }

        private void btnDigitalContent_Click(object sender, EventArgs e)
        {

        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            EventMemberForm eventMemberForm = new EventMemberForm(LoggedInUser.UserId);
            LoadFormIntoPanel(eventMemberForm);
        }

        private void btnSpaceBook_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            SpaceMemberForm spaceMemberForm = new SpaceMemberForm();
            LoadFormIntoPanel(spaceMemberForm);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            MemberProfileForm MemberProfileForm = new MemberProfileForm();
            LoadFormIntoPanel(MemberProfileForm);
        }

        private void btnConnections_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as Button);
            FriendsServiceForm friendServiceForm = new FriendsServiceForm();
            LoadFormIntoPanel(friendServiceForm);
        }

        private void linkFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MemberFeedbackEndForm memberFeedbackEndForm = new MemberFeedbackEndForm(LoggedInUser.UserId);
            memberFeedbackEndForm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Please enter a search keyword.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Perform the search
            DataTable results = _searchManager.SearchAll(LoggedInUser.UserId, keyword);

            if (results != null && results.Rows.Count > 0)
            {
                // Load the results into the SearchResultForm
                var searchResultForm = new SearchResultForm();
                searchResultForm.LoadSearchResults(results);
                LoadFormIntoPanel(searchResultForm); // Load SearchResultForm in the main panel
            }
            else
            {
                MessageBox.Show("No results found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panelMainPg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNotification_Click(object sender, EventArgs e)
        {

        }


    }
}
