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

namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin.Admin_Edit_Event
{
    public partial class AdminEditEventForm : Form
    {
        private EventsService eventsService = new EventsService();
        private int eventId; // Store the event ID

        public AdminEditEventForm(int eventId)
        {
            InitializeComponent();
            this.eventId = eventId; // Assign event ID
            LoadEventDetails(); // Load event details into the form
        }

        private void LoadEventDetails()
        {
            try
            {
                DataTable eventDetails = eventsService.GetEvents(); // Get all events
                DataRow eventData = eventDetails.Select($"event_id = {eventId}").FirstOrDefault();

                if (eventData != null)
                {
                    txtEditEventName.Text = eventData["event_name"].ToString();
                    txtEditEventDescription.Text = eventData["event_description"]?.ToString();
                    cmbEditEventType.Text = eventData["event_type"].ToString();
                    numEditAttendanceLimit.Value = eventData["attendance_limit"] != DBNull.Value
                        ? Convert.ToDecimal(eventData["attendance_limit"])
                        : 0;
                    txtEditEventLocation.Text = eventData["location"].ToString();
                    txtEditEventFee.Text = eventData["fee"] != DBNull.Value ? eventData["fee"].ToString() : "0";
                    dtpEditEventDate.Value = Convert.ToDateTime(eventData["event_date"]);

                    // Load image if available
                    if (eventData["image"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])eventData["image"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            picEditEventImage.Image = Image.FromStream(ms);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Event not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading event details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void AdminEditEventForm_Load(object sender, EventArgs e)
        {

        }

        private void txtEditEventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEditEventDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEditEventLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEditEventFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void picEditEventImage_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;",
                Title = "Select Event Image"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                picEditEventImage.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void btnCancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEditEventType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numEditAttendanceLimit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpEditEventDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtEditEventName.Text;
                string description = txtEditEventDescription.Text;
                string type = cmbEditEventType.Text;
                int? limit = numEditAttendanceLimit.Value > 0 ? (int?)numEditAttendanceLimit.Value : null;
                string location = txtEditEventLocation.Text;
                DateTime date = dtpEditEventDate.Value;
                decimal? fee = !string.IsNullOrWhiteSpace(txtEditEventFee.Text) ? Convert.ToDecimal(txtEditEventFee.Text) : (decimal?)null;

                byte[] image = null;
                if (picEditEventImage.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picEditEventImage.Image.Save(ms, picEditEventImage.Image.RawFormat);
                        image = ms.ToArray();
                    }
                }

                bool updated = eventsService.UpdateEvent(eventId, name, description, type, limit, location, date, fee, image);

                if (updated)
                {
                    MessageBox.Show("Event updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
