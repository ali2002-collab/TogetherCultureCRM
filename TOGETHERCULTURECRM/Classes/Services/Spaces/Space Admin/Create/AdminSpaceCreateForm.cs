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

namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Admin.Create
{
    public partial class AdminSpaceCreateForm : Form
    {
        private readonly SpaceService _spaceService;
        public AdminSpaceCreateForm()
        {
            InitializeComponent();
            _spaceService = new SpaceService();
        }

        private void txtSpaceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpaceDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpacelocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSpaceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numCapacityLimit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpOpeningTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpClosingTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateSpace_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve inputs from form fields
                string location = txtSpacelocation.Text.Trim();
                string spaceType = cmbSpaceType.SelectedItem?.ToString();
                int capacity = (int)numCapacityLimit.Value;
                TimeSpan openingTime = dtpOpeningTime.Value.TimeOfDay;
                TimeSpan closingTime = dtpClosingTime.Value.TimeOfDay;
                string description = txtSpaceDescription.Text.Trim();

                // Validate inputs
                if (string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("Location is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(spaceType))
                {
                    MessageBox.Show("Please select a space type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (openingTime >= closingTime)
                {
                    MessageBox.Show("Opening time must be earlier than closing time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call the service to create space
                bool success = _spaceService.CreateSpace(location, spaceType, capacity, openingTime, closingTime, description, LoggedInUser.UserId);

                if (success)
                {
                    MessageBox.Show("Space created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form upon success
                }
                else
                {
                    MessageBox.Show("Failed to create space. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating space: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
