using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Admin.Edit
{
    public partial class EditSpaceForm : Form
    {
        private readonly SpaceService _spaceService;
        private readonly int _spaceId;
        

        public EditSpaceForm(int spaceId)
        {
            InitializeComponent();
            _spaceService = new SpaceService();
            _spaceId = spaceId;
        }
        private void EditSpaceForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Fetch the space details from the database
                Dictionary<string, object> spaceDetails = _spaceService.GetSpaceDetails(_spaceId);

                if (spaceDetails != null)
                {
                    // Preload data into form fields
                    txtEditSpacelocation.Text = spaceDetails["location"].ToString();
                    cmbEditSpaceType.SelectedItem = spaceDetails["space_type"].ToString();
                    numEditCapacityLimit.Value = Convert.ToInt32(spaceDetails["capacity"]);
                    dtpEditOpeningTime.Value = DateTime.Today.Add((TimeSpan)spaceDetails["opening_time"]);
                    dtpEditClosingTime.Value = DateTime.Today.Add((TimeSpan)spaceDetails["closing_time"]);
                    txtEditSpaceDescription.Text = spaceDetails["description"]?.ToString() ?? string.Empty;
                }
                else
                {
                    MessageBox.Show("Space details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading space details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void txtEditSpaceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEditSpaceDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEditSpacelocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEditSpaceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numEditCapacityLimit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpEditOpeningTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpEditClosingTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditSpace_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect updated values from form controls
                string updatedLocation = txtEditSpacelocation.Text;
                string updatedType = cmbEditSpaceType.SelectedItem?.ToString();
                int updatedCapacity = (int)numEditCapacityLimit.Value;
                TimeSpan updatedOpeningTime = dtpEditOpeningTime.Value.TimeOfDay;
                TimeSpan updatedClosingTime = dtpEditClosingTime.Value.TimeOfDay;
                string updatedDescription = txtEditSpaceDescription.Text;

                // Validate inputs
                if (string.IsNullOrWhiteSpace(updatedLocation))
                {
                    MessageBox.Show("Location cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(updatedType))
                {
                    MessageBox.Show("Please select a space type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (updatedOpeningTime >= updatedClosingTime)
                {
                    MessageBox.Show("Opening time must be earlier than closing time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call service to update the space in the database
                bool isUpdated = _spaceService.UpdateSpace(_spaceId, updatedLocation, updatedType, updatedCapacity, updatedOpeningTime, updatedClosingTime, updatedDescription);

                if (isUpdated)
                {
                    MessageBox.Show("Space updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update space.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating space: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
