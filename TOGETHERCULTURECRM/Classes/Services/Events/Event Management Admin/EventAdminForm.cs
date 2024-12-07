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
using TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin.Admin_Create_Event;
using TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin.Admin_Edit_Event;
using TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin.Admin_Event_Stats;

namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Admin
{
    public partial class EventAdminForm : Form
    {
        private EventsService eventsService = new EventsService();
        private DataTable eventsData = new DataTable();
        private int currentPage = 0; // Track current page
        private const int postsPerPage = 3; // Number of posts per page

        public EventAdminForm()
        {
            InitializeComponent();
            LoadEvents();
        }


        private void LoadEvents()
        {
            try
            {
                // Fetch all events and store in DataTable
                eventsData = eventsService.GetEvents();

                if (eventsData.Rows.Count == 0)
                {
                    lblWhenNoEvents.Visible = true;
                    pnlEventPosts.Visible = false;
                }
                else
                {
                    lblWhenNoEvents.Visible = false;
                    pnlEventPosts.Visible = true;
                    ShowPage(currentPage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPage(int page)
        {
            // Clear existing placeholders
            pnlEventPosts.Controls.Clear();

            // Calculate start and end index for the current page
            int startIndex = page * postsPerPage;
            int endIndex = Math.Min(startIndex + postsPerPage, eventsData.Rows.Count);

            int verticalOffset = 10; // Initial vertical offset
            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow row = eventsData.Rows[i];
                Panel eventPost = CreateEventPost(row);
                eventPost.Location = new Point(10, verticalOffset); // Adjust vertical spacing dynamically
                pnlEventPosts.Controls.Add(eventPost);

                verticalOffset += eventPost.Height + 10; // Increase offset for the next post
            }

            // Enable or disable navigation buttons based on the current page index
            btnPreviousPage.Enabled = currentPage > 0; // Enable "Previous" if not on the first page
            btnNextPage.Enabled = (currentPage + 1) * postsPerPage < eventsData.Rows.Count; // Enable "Next" if there are more posts to show
        }



        private Panel CreateEventPost(DataRow row)
        {
            Panel panel = new Panel
            {
                Size = new Size(pnlEventPosts.Width - 40, 260), // Adjusted for scrolling and proper width
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(254, 26, 55),
                Padding = new Padding(10)
            };

            Label lblEventName = new Label
            {
                Text = row["event_name"].ToString(),
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblEventType = new Label
            {
                Text = $"Type: {row["event_type"]}",
                Font = new Font("Arial", 12),
                ForeColor = Color.White,
                Location = new Point(10, 40),
                AutoSize = true
            };

            Label lblEventDate = new Label
            {
                Text = $"Date: {Convert.ToDateTime(row["event_date"]).ToShortDateString()}",
                Font = new Font("Arial", 12),
                ForeColor = Color.White,
                Location = new Point(10, 70),
                AutoSize = true
            };

            Label lblEventLocation = new Label
            {
                Text = $"Location: {row["location"]}",
                Font = new Font("Arial", 12),
                ForeColor = Color.White,
                Location = new Point(10, 100),
                AutoSize = true
            };

            Label lblEventFee = new Label
            {
                Text = row["fee"] != DBNull.Value ? $"Fee: GBP{Convert.ToDecimal(row["fee"]):F2}" : "Fee: Free",
                Font = new Font("Arial", 12),
                ForeColor = Color.White,
                Location = new Point(10, 130),
                AutoSize = true
            };

            Label lblAttendanceLimit = new Label
            {
                Text = row["attendance_limit"] != DBNull.Value ? $"Attendance Limit: {row["attendance_limit"]}" : "No Limit",
                Font = new Font("Arial", 12),
                ForeColor = Color.White,
                Location = new Point(10, 160),
                AutoSize = true
            };

            TextBox txtDescription = new TextBox
            {
                Text = row["event_description"]?.ToString() ?? "No Description Provided",
                Font = new Font("Arial", 10),
                ForeColor = Color.Black,
                BackColor = Color.White,
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Size = new Size(panel.Width - 140, 60), // Adjust size
                Location = new Point(10, 190)
            };

            PictureBox picEventImage = new PictureBox
            {
                Size = new Size(100, 100),
                Location = new Point(panel.Width - 120, 10),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.White
            };

            if (row["image"] != DBNull.Value)
            {
                byte[] imageData = (byte[])row["image"];
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    picEventImage.Image = Image.FromStream(ms);
                }
            }

            Button btnStats = new Button
            {
                Text = "Stats",
                Size = new Size(80, 30),
                Location = new Point(panel.Width - 120, panel.Height - 115),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            btnStats.FlatAppearance.BorderColor = Color.DarkGray;
            btnStats.Click += (s, e) => OpenStatsForm((int)row["event_id"]);


            Button btnEdit = new Button
            {
                Text = "Edit",
                Size = new Size(80, 30),
                Location = new Point(panel.Width - 120, panel.Height - 75),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            btnEdit.Click += (s, e) => OpenEditEventForm((int)row["event_id"]);

            Button btnDelete = new Button
            {
                Text = "Delete",
                Size = new Size(80, 30),
                Location = new Point(panel.Width - 120, panel.Height - 40),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            btnDelete.Click += (s, e) => DeleteEvent((int)row["event_id"]);

            panel.Controls.Add(lblEventName);
            panel.Controls.Add(lblEventType);
            panel.Controls.Add(lblEventDate);
            panel.Controls.Add(lblEventLocation);
            panel.Controls.Add(lblEventFee);
            panel.Controls.Add(lblAttendanceLimit);
            panel.Controls.Add(txtDescription);
            panel.Controls.Add(picEventImage);
            panel.Controls.Add(btnStats);
            panel.Controls.Add(btnEdit);
            panel.Controls.Add(btnDelete);

            return panel;
        }

        private void OpenEditEventForm(int eventId)
        {
            AdminEditEventForm editForm = new AdminEditEventForm(eventId);
            editForm.FormClosed += (s, e) => LoadEvents(); // Reload events after editing
            editForm.ShowDialog();
        }

        private void OpenStatsForm(int eventId)
        {
            AdminEventStatsForm statsForm = new AdminEventStatsForm(eventId);
            statsForm.ShowDialog();
        }

        private void btnOpenCreateEventForm_Click(object sender, EventArgs e)
        {
            CreateNewEventForm createNewEventForm = new CreateNewEventForm();
            createNewEventForm.ShowDialog();
            LoadEvents();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            ShowPage(currentPage);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            ShowPage(currentPage);

        }

        private void EditEvent(int eventId)
        {
            // Handle event edit logic
            MessageBox.Show($"Edit event with ID: {eventId}", "Edit Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteEvent(int eventId)
        {
            if (MessageBox.Show("Are you sure you want to delete this event?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (eventsService.DeleteEvent(eventId))
                {
                    MessageBox.Show("Event deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEvents();

                    // Adjust current page index if the last page no longer has posts
                    if (currentPage * postsPerPage >= eventsData.Rows.Count && currentPage > 0)
                    {
                        currentPage--;
                    }

                    ShowPage(currentPage); // Refresh the current page
                }
                else
                {
                    MessageBox.Show("Failed to delete event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void lblWhenNoEvents_Click(object sender, EventArgs e)
        {

        }

        private void EventAdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
