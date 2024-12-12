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
using TOGETHERCULTURECRM.Classes.Services.Interest_Selection;

namespace TOGETHERCULTURECRM.Classes.MembersDashboard.Profile
{
    public partial class MemberProfileForm : Form
    {
        private ProfileManager profileManager = new ProfileManager();
        public MemberProfileForm()
        {
            InitializeComponent();
            LoadProfileDetails();
        }
        private void LoadProfileDetails()
        {
            // Load first name and profile picture
            lblFirstName.Text = $"Welcome {LoggedInUser.FirstName}";

            // Load profile picture if available
            if (LoggedInUser.ProfilePicture != null)
            {
                using (MemoryStream ms = new MemoryStream(LoggedInUser.ProfilePicture))
                {
                    picProfile.Image = Image.FromStream(ms);
                }
            }
            else
            {
                // Set default picture
                picProfile.Image = Properties.Resources.Profile_avatar_placeholder_large;
            }
        }
        private void MemberProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            // Open Edit Profile form
            EditProfileForm editProfileForm = new EditProfileForm();
            editProfileForm.ShowDialog();
            LoadProfileDetails();

        }

        private void btnSelectInterests_Click(object sender, EventArgs e)
        {
            InterestSelectionForm interestSelectionForm = new InterestSelectionForm(LoggedInUser.UserId);
            interestSelectionForm.ShowDialog();
        }
    }
}
