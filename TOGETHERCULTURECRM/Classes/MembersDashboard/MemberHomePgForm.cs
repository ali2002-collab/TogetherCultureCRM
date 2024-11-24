using System;
using System.Drawing;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Auth;
using TOGETHERCULTURECRM.Classes.MembersDashboard.Home;

namespace TOGETHERCULTURECRM.Classes.MembersDashboard
{
    public partial class MemberHomePgForm : Form
    {
        private Button activeButton = null; // Track the currently active button
        private Color defaultButtonColor = Color.FromArgb(210, 20, 50); // Default button color
        private Color activeButtonColor = Color.FromArgb(72, 19, 38);  // Selected button color


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

        }

        private void btnSpaceBook_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnConnections_Click(object sender, EventArgs e)
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

        private void panelMainPg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNotification_Click(object sender, EventArgs e)
        {

        }
    }
}
