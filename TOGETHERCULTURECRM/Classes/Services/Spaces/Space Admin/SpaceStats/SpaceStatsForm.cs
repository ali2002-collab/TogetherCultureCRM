using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Admin.SpaceStats
{
    public partial class SpaceStatsForm : Form
    {
        private readonly SpaceService _spaceService;
        private readonly int _spaceId;
        public SpaceStatsForm(int spaceId)
        {
            InitializeComponent();
            // Attach event handlers
            dataGridViewTotalBookingsList.DataError += dataGridViewTotalBookingsList_DataError;
            _spaceService = new SpaceService();
            _spaceId = spaceId;
        }

        private void dataGridViewTotalBookingsList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Handle data errors in the DataGridView
            MessageBox.Show($"Error displaying data in the grid: {e.Exception.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.ThrowException = false;
        }

        private void FormatDataGridView()
        {
            // Verify that each column exists before trying to access it
            if (dataGridViewTotalBookingsList.Columns["utilization_id"] != null)
            {
                dataGridViewTotalBookingsList.Columns["utilization_id"].Visible = false;
            }

            if (dataGridViewTotalBookingsList.Columns["user_id"] != null)
            {
                dataGridViewTotalBookingsList.Columns["user_id"].Visible = false;
            }

            if (dataGridViewTotalBookingsList.Columns["date"] != null)
            {
                dataGridViewTotalBookingsList.Columns["date"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dataGridViewTotalBookingsList.Columns["start_time"] != null)
            {
                dataGridViewTotalBookingsList.Columns["start_time"].DefaultCellStyle.Format = @"hh\:mm tt";
            }

            if (dataGridViewTotalBookingsList.Columns["end_time"] != null)
            {
                dataGridViewTotalBookingsList.Columns["end_time"].DefaultCellStyle.Format = @"hh\:mm tt";
            }

            // Auto-resize columns for better readability
            dataGridViewTotalBookingsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void lbltotalBooking_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTotalBookingsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadSpaceBookingStats_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable bookingDetails = _spaceService.GetSpaceBookings(_spaceId);

                if (bookingDetails != null)
                {
                    // Bind the data to the DataGridView
                    dataGridViewTotalBookingsList.DataSource = bookingDetails;

                    // Update the total bookings count
                    lbltotalBooking.Text = $"Total Bookings: {_spaceService.GetTotalBookings(_spaceId)}";

                    // Apply column formatting
                    dataGridViewTotalBookingsList.Columns["start_time"].DefaultCellStyle.Format = "hh\\:mm";
                    dataGridViewTotalBookingsList.Columns["end_time"].DefaultCellStyle.Format = "hh\\:mm";
                    dataGridViewTotalBookingsList.Columns["date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
                else
                {
                    MessageBox.Show("No bookings found for this space.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading space bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
