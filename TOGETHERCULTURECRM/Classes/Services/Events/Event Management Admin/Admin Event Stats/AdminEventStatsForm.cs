using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin.Admin_Event_Stats
{
    public partial class AdminEventStatsForm : Form
    {
        private int eventId;
        public AdminEventStatsForm(int eventId)
        {
            InitializeComponent();
            this.eventId = eventId;
        }
        private int GetAttendanceLimit(int eventId)
        {
            // Fetch attendance limit for the event from database
            return Convert.ToInt32(new EventsService().GetEvents()
                .AsEnumerable()
                .FirstOrDefault(row => Convert.ToInt32(row["event_id"]) == eventId)?["attendance_limit"] ?? 0);
        }

        private void AdminEventStatsForm_Load(object sender, EventArgs e)
        {

        }

        private void lblCurrentAttendance_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEventStats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadEventStats_Click(object sender, EventArgs e)
        {
            EventsService eventsService = new EventsService();
            DataTable attendanceList = eventsService.GetAttendanceList(eventId);

            if (attendanceList != null)
            {
                dataGridViewEventStats.DataSource = attendanceList;
                int currentAttendance = attendanceList.Rows.Count;

                lblCurrentAttendance.Text = $"Current Attendance: {currentAttendance}";

                if (currentAttendance >= GetAttendanceLimit(eventId))
                {
                    lblCurrentAttendance.Text = "Fully Booked";
                }
            }
            else
            {
                MessageBox.Show("Error loading event stats.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
