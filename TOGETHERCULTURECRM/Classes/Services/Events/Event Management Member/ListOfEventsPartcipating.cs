using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Member
{
    public partial class ListOfEventsPartcipating : Form
    {
        private readonly EventsService _eventsService;
        private readonly int _userId;

        public ListOfEventsPartcipating(int userId)
        {
            InitializeComponent();
            _eventsService = new EventsService();
            _userId = userId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewListOFEventsParticipating_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadEventList_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch the list of events the user is attending
                DataTable eventsAttending = _eventsService.GetUserAttendingEvents(_userId);

                if (eventsAttending.Rows.Count == 0)
                {
                    MessageBox.Show("You are not attending any events.", "No Events", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewListOFEventsParticipating.DataSource = null;
                }
                else
                {
                    dataGridViewListOFEventsParticipating.DataSource = eventsAttending;

                    // Ensure the column exists
                    if (!eventsAttending.Columns.Contains("event_id"))
                    {
                        throw new Exception("The event_id column is missing from the data source.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading event list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNotAttend_Click(object sender, EventArgs e)
        {
            if (dataGridViewListOFEventsParticipating.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an event to withdraw from.", "No Event Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int eventId = Convert.ToInt32(dataGridViewListOFEventsParticipating.SelectedRows[0].Cells["event_id"].Value);

            if (MessageBox.Show("Are you sure you want to withdraw from this event?", "Confirm Withdrawal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (_eventsService.WithdrawFromEvent(eventId, _userId))
                    {
                        MessageBox.Show("You have successfully withdrawn from the event.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload the list of events the user is attending
                        btnLoadEventList_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to withdraw from the event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error withdrawing from the event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
