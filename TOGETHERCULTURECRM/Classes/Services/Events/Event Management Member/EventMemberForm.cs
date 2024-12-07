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

namespace TOGETHERCULTURECRM.Classes.Services.Events.Event_Management_Member
{
    public partial class EventMemberForm : Form
    {
        private EventsService eventsService = new EventsService();
        private DataTable eventsData = new DataTable();
        private int currentPage = 0; // Track current page
        private const int postsPerPage = 3; // Number of posts per page
        private int userId; // Member's User ID
        public EventMemberForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadEvents();
        }
        private void LoadEvents()
        {
            try
            {
                eventsData = eventsService.GetAvailableEvents(userId);

                if (eventsData.Rows.Count == 0)
                {
                    lblWhenNoEvents.Visible = true;
                    pnlMemberEventPosts.Visible = false;
                }
                else
                {
                    lblWhenNoEvents.Visible = false;
                    pnlMemberEventPosts.Visible = true;
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
            pnlMemberEventPosts.Controls.Clear();

            int startIndex = page * postsPerPage;
            int endIndex = Math.Min(startIndex + postsPerPage, eventsData.Rows.Count);

            int verticalOffset = 10;
            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow row = eventsData.Rows[i];
                Panel eventPost = CreateEventPost(row);
                eventPost.Location = new Point(10, verticalOffset);
                pnlMemberEventPosts.Controls.Add(eventPost);

                verticalOffset += eventPost.Height + 10;
            }

            btnPreviousPage.Enabled = currentPage > 0;
            btnNextPage.Enabled = endIndex < eventsData.Rows.Count;
        }



        private Panel CreateEventPost(DataRow row)
        {
            Panel panel = new Panel
            {
                Size = new Size(pnlMemberEventPosts.Width - 40, 260),
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

            Label lblEventLocation = new Label
            {
                Text = $"Location: {row["location"]}",
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

            Label lblAttendance = new Label
            {
                Text = $"Attendance: {row["attendance_count"]}/{row["attendance_limit"] ?? "Unlimited"}",
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


            Button btnAttend = new Button
            {
                Text = "Attend",
                Size = new Size(80, 30),
                Location = new Point(panel.Width - 100, panel.Height - 50),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };

            btnAttend.FlatAppearance.BorderColor = Color.DarkGray;

            if (row["attendance_limit"] != DBNull.Value &&
                Convert.ToInt32(row["attendance_count"]) >= Convert.ToInt32(row["attendance_limit"]))
            {
                btnAttend.Text = "Fully Booked";
                btnAttend.Enabled = false;
            }

            btnAttend.Click += (s, e) => AttendEvent((int)row["event_id"], panel);

            panel.Controls.Add(lblEventName);
            panel.Controls.Add(lblEventType);
            panel.Controls.Add(lblEventLocation);
            panel.Controls.Add(lblEventDate);
            panel.Controls.Add(lblAttendance);
            panel.Controls.Add(lblEventFee);
            panel.Controls.Add(txtDescription);
            panel.Controls.Add(picEventImage);
            panel.Controls.Add(btnAttend);

            return panel;
        }

        private void AttendEvent(int eventId, Panel panel)
        {
            try
            {
                if (eventsService.AttendEvent(eventId, userId))
                {
                    MessageBox.Show("You are now attending this event!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to attend the event. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error attending event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void EventMemberForm_Load(object sender, EventArgs e)
        {

        }

        private void pnlMemberEventPosts_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnOpenAttendingEventsListForm_Click(object sender, EventArgs e)
        {
            ListOfEventsPartcipating listOfEventsPartcipating = new ListOfEventsPartcipating(LoggedInUser.UserId); 
            listOfEventsPartcipating.ShowDialog();
        }

        private void lblWhenNoEvents_Click(object sender, EventArgs e)
        {

        }
    }
}
