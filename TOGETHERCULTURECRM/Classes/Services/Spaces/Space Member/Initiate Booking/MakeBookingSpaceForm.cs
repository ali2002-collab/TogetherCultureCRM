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

namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Member.Initiate_Booking
{
    public partial class MakeBookingSpaceForm : Form
    {
        private readonly int _spaceId;
        private readonly SpaceService _spaceService;

        public MakeBookingSpaceForm(int spaceId)
        {
            InitializeComponent();
            _spaceId = spaceId;
            _spaceService = new SpaceService();
        }

        private void btnBookSpace_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime bookingDate = dtpSpaceBookDate.Value.Date;
                TimeSpan startTime = dtpStartTime.Value.TimeOfDay;
                TimeSpan endTime = dtpEndTime.Value.TimeOfDay;
                string purpose = txtSpacePurpose.Text;

                // Validate booking times
                if (startTime >= endTime)
                {
                    MessageBox.Show("Start time must be earlier than end time.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if the booking times fall within the opening and closing times
                var spaceDetails = _spaceService.GetSpaceDetails(_spaceId);
                TimeSpan openingTime = TimeSpan.Parse(spaceDetails["opening_time"].ToString());
                TimeSpan closingTime = TimeSpan.Parse(spaceDetails["closing_time"].ToString());

                if (startTime < openingTime || endTime > closingTime)
                {
                    MessageBox.Show($"Booking must be within opening ({openingTime}) and closing ({closingTime}) times.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if capacity allows the booking
                int currentBookings = _spaceService.GetSpaceBookingCount(_spaceId, bookingDate);
                int capacity = int.Parse(spaceDetails["capacity"].ToString());

                if (currentBookings >= capacity)
                {
                    MessageBox.Show("The space is fully booked for the selected date and time. Please select another time.", "Fully Booked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Proceed with booking
                bool success = _spaceService.BookSpace(_spaceId, LoggedInUser.UserId, bookingDate, startTime, endTime, purpose);
                if (success)
                {
                    MessageBox.Show("Space booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to book space. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error booking space: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSpacePurpose_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpEndTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpSpaceBookDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
