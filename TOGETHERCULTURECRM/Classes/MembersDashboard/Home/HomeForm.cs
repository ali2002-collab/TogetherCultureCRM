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
using TOGETHERCULTURECRM.Classes.Services.Events;

namespace TOGETHERCULTURECRM.Classes.MembersDashboard.Home
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            lblWelcomeFirstName.Text = $"{LoggedInUser.FirstName}!";
            LoadLatestEvent();
        }


        private EventsService eventsService = new EventsService();

        private void LoadLatestEvent()
        {
            try
            {
                DataRow latestEvent = eventsService.GetLatestAvailableEvent(LoggedInUser.UserId);

                if (latestEvent != null)
                {
                    Panel eventPanel = CreateEventPanel(latestEvent);
                    panelViewEvents1.Controls.Clear(); // Clear any existing content
                    panelViewEvents1.Controls.Add(eventPanel);
                }
                else
                {
                    Label noEventLabel = new Label
                    {
                        Text = "No new events available.",
                        Font = new Font("Arial", 14, FontStyle.Bold),
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Location = new Point(10, 10)
                    };
                    panelViewEvents1.Controls.Clear();
                    panelViewEvents1.Controls.Add(noEventLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading latest event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Panel CreateEventPanel(DataRow eventRow)
        {
            Panel panel = new Panel
            {
                Size = new Size(panelViewEvents1.Width - 20, 200),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(254, 26, 55),
                Padding = new Padding(10)
            };

            Label lblEventName = new Label
            {
                Text = $"Event Name: {eventRow["event_name"]}",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblEventDate = new Label
            {
                Text = $"Date: {Convert.ToDateTime(eventRow["event_date"]).ToShortDateString()}",
                Font = new Font("Arial", 12),
                ForeColor = Color.White,
                Location = new Point(10, 40),
                AutoSize = true
            };

            Label lblEventLocation = new Label
            {
                Text = $"Location: {eventRow["location"]}",
                Font = new Font("Arial", 12),
                ForeColor = Color.White,
                Location = new Point(10, 70),
                AutoSize = true
            };

            TextBox txtEventDescription = new TextBox
            {
                Text = eventRow["event_description"]?.ToString() ?? "No Description Provided",
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Size = new Size(panel.Width - 40, 80),
                Location = new Point(10, 100)
            };


            panel.Controls.Add(lblEventName);
            panel.Controls.Add(lblEventDate);
            panel.Controls.Add(lblEventLocation);
            panel.Controls.Add(txtEventDescription);

            return panel;
        }

        private void lblWelcomeFirstName_Click(object sender, EventArgs e)
        {

        }

        private void linkMyProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MemberHomePgForm parentForm = (MemberHomePgForm)this.ParentForm;

            if (parentForm != null)
            {
                parentForm.LoadProfileFromHome(); // Custom method in MemberHomePgForm
            }
        }

        private void linkBookSpace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MemberHomePgForm parentForm = (MemberHomePgForm)this.ParentForm;

            if (parentForm != null)
            {
                parentForm.LoadSpaceBookingFromHome(); // Custom method in MemberHomePgForm
            }
        }

        private void btnViewMoreEvents_Click(object sender, EventArgs e)
        {
            MemberHomePgForm parentForm = (MemberHomePgForm)this.ParentForm;

            if (parentForm != null)
            {
                parentForm.LoadeventsForm(); // Custom method in MemberHomePgForm
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberHomePgForm parentForm = (MemberHomePgForm)this.ParentForm;

            if (parentForm != null)
            {
                parentForm.LoadDigitalContent(); // Custom method in MemberHomePgForm
            }
        }

        private void panelViewEvents1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
