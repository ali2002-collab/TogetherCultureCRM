using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Auth;

namespace TOGETHERCULTURECRM.Classes.MembersDashboard.Profile
{
    public partial class EditProfileForm : Form
    {
        private ProfileManager profileManager = new ProfileManager();
        public EditProfileForm()
        {
            InitializeComponent();
            LoadCurrentDetails();
        }

        private void LoadCurrentDetails()
        {
            if (!string.IsNullOrEmpty(LoggedInUser.Email))
            {
                txtEPFCurrentEmail.Text = $"{LoggedInUser.Email}";
            }
            else
            {
                txtEPFCurrentEmail.Text = "Current Email: Not Available";
            }

            if (LoggedInUser.ProfilePicture != null)
            {
                using (MemoryStream ms = new MemoryStream(LoggedInUser.ProfilePicture))
                {
                    picEditProfile.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picEditProfile.Image = Properties.Resources.Profile_avatar_placeholder_large;
            }
        }
        private void EditProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveEmail_Click(object sender, EventArgs e)
        {
            string newEmail = txtNewEmail.Text.Trim();

            if (string.IsNullOrEmpty(newEmail))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (profileManager.UpdateEmail(newEmail))
            {
                MessageBox.Show("Email updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update email. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!profileManager.ValidateCurrentPassword(currentPassword))
            {
                MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (profileManager.UpdatePassword(newPassword))
            {
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;",
                Title = "Select a Profile Picture"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] profilePicture = File.ReadAllBytes(fileDialog.FileName);

                if (profileManager.UpdateProfilePicture(profilePicture))
                {
                    MessageBox.Show("Profile picture updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (MemoryStream ms = new MemoryStream(profilePicture))
                    {
                        picEditProfile.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to update profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
