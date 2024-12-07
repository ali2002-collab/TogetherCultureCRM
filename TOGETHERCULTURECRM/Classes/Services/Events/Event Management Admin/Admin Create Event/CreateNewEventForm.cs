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

namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin.Admin_Create_Event
{
    public partial class CreateNewEventForm : Form
    {
        private EventsService eventsService = new EventsService(); // Backend service instance
        private byte[] eventImage = null;

        public CreateNewEventForm()
        {
            InitializeComponent();
        }

        private void btnCancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEventDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEventLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEventFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void picEventImage_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            // Open file dialog to upload an image
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                Title = "Select Event Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load image into the PictureBox
                picEventImage.Image = Image.FromFile(openFileDialog.FileName);

                // Convert image to byte array
                using (MemoryStream ms = new MemoryStream())
                {
                    picEventImage.Image.Save(ms, picEventImage.Image.RawFormat);
                    eventImage = ms.ToArray();
                }
            }

        }

        private void cmbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numAttendanceLimit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpEventDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtEventName.Text) ||
                    string.IsNullOrWhiteSpace(txtEventLocation.Text) ||
                    string.IsNullOrWhiteSpace(cmbEventType.Text))
                {
                    MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get form data
                string eventName = txtEventName.Text.Trim();
                string eventDescription = txtEventDescription.Text.Trim();
                string eventLocation = txtEventLocation.Text.Trim();
                decimal? eventFee = !string.IsNullOrWhiteSpace(txtEventFee.Text) ? decimal.Parse(txtEventFee.Text.Trim()) : (decimal?)null;
                string eventType = cmbEventType.SelectedItem.ToString();
                int? attendanceLimit = (int)numAttendanceLimit.Value > 0 ? (int)numAttendanceLimit.Value : (int?)null;
                DateTime eventDate = dtpEventDate.Value;

                // Call service to create the event
                bool isCreated = eventsService.CreateEvent(eventName, eventDescription, eventType, attendanceLimit, eventLocation, eventDate, eventFee, eventImage, LoggedInUser.UserId);

                if (isCreated)
                {
                    MessageBox.Show("Event created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form after success
                }
                else
                {
                    MessageBox.Show("Failed to create event. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
