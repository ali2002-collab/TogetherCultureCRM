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
using TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Member.Booked;
using TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Member.Initiate_Booking;

namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Member
{
    public partial class SpaceMemberForm : Form
    {
        private readonly SpaceService _spaceService;
        private DataTable _spacesData;
        private int _currentPage = 0; // Track current page
        private const int PostsPerPage = 3;
        public SpaceMemberForm()
        {
            InitializeComponent();
            _spaceService = new SpaceService();
            LoadSpaces(); // Load spaces on form initialization
        }

        private void LoadSpaces()
        {
            try
            {
                // Fetch available spaces from the database
                _spacesData = _spaceService.GetSpaces();

                if (_spacesData.Rows.Count == 0)
                {
                    lblNoSpaces.Visible = true;
                    pnlMemberSpacePosts.Visible = false;
                }
                else
                {
                    lblNoSpaces.Visible = false;
                    pnlMemberSpacePosts.Visible = true;
                    ShowPage(_currentPage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading spaces: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ShowPage(int page)
        {
            pnlMemberSpacePosts.Controls.Clear(); // Clear existing posts

            // Calculate start and end indices for the current page
            int startIndex = page * PostsPerPage;
            int endIndex = Math.Min(startIndex + PostsPerPage, _spacesData.Rows.Count);

            int verticalOffset = 10; // Initial vertical offset
            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow row = _spacesData.Rows[i];
                Panel spacePost = CreateSpacePost(row);
                spacePost.Location = new Point(10, verticalOffset);
                pnlMemberSpacePosts.Controls.Add(spacePost);

                verticalOffset += spacePost.Height + 10; // Adjust for the next post
            }

            // Enable/disable navigation buttons
            btnPreviousPage.Enabled = _currentPage > 0;
            btnNextPage.Enabled = endIndex < _spacesData.Rows.Count;
        }



        private Panel CreateSpacePost(DataRow row)
        {
            Panel panel = new Panel
            {
                Size = new Size(pnlMemberSpacePosts.Width - 40, 200), // Adjust width and height
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(254, 26, 55),
                Padding = new Padding(10)
            };

            Label lblLocation = new Label
            {
                Text = $"Location: {row["location"]}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblSpaceType = new Label
            {
                Text = $"Type: {row["space_type"]}",
                Font = new Font("Arial", 10),
                ForeColor = Color.White,
                Location = new Point(10, 40),
                AutoSize = true
            };

            Label lblCapacity = new Label
            {
                Text = $"Capacity: {row["capacity"]}",
                Font = new Font("Arial", 10),
                ForeColor = Color.White,
                Location = new Point(10, 70),
                AutoSize = true
            };
            // Parse opening time safely
            string openingTimeText = row["opening_time"] is TimeSpan openingTime
                ? openingTime.ToString(@"hh\:mm")
                : row["opening_time"].ToString();
            Label lblOpeningTime = new Label
            {
                Text = $"Opening Time: {openingTimeText}",
                Font = new Font("Arial", 10),
                ForeColor = Color.White,
                Location = new Point(10, 100),
                AutoSize = true
            };

            // Parse closing time safely
            string closingTimeText = row["closing_time"] is TimeSpan closingTime
                ? closingTime.ToString(@"hh\:mm")
                : row["closing_time"].ToString();
            Label lblClosingTime = new Label
            {
                Text = $"Closing Time: {closingTimeText}",
                Font = new Font("Arial", 10),
                ForeColor = Color.White,
                Location = new Point(10, 130),
                AutoSize = true
            };

            Label lblDescription = new Label
            {
                Text = $"Description: {row["description"]}",
                Font = new Font("Arial", 10),
                ForeColor = Color.White,
                Location = new Point(10, 160),
                AutoSize = true
            };

            // Add Book Button
            Button btnBook = new Button
            {
                Text = "Book",
                Size = new Size(80, 30),
                Location = new Point(panel.Width - 100, panel.Height - 50),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            btnBook.Click += (s, e) => OpenBookingForm((int)row["space_id"]);

            panel.Controls.Add(lblLocation);
            panel.Controls.Add(lblSpaceType);
            panel.Controls.Add(lblCapacity);
            panel.Controls.Add(lblOpeningTime);
            panel.Controls.Add(lblClosingTime);
            panel.Controls.Add(lblDescription);
            panel.Controls.Add(btnBook);

            return panel;
        }


        private void OpenBookingForm(int spaceId)
        {
            MakeBookingSpaceForm bookingForm = new MakeBookingSpaceForm(spaceId);
            bookingForm.ShowDialog();
        }


        private void pnlMemberSpacePosts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMemberOpenBookedSpaceForm_Click(object sender, EventArgs e)
        {
            BookedSpacesMemberForm bookedSpacesMemberForm = new BookedSpacesMemberForm(LoggedInUser.UserId);
            bookedSpacesMemberForm.ShowDialog();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            _currentPage--;
            ShowPage(_currentPage);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _currentPage++;
            ShowPage(_currentPage);
        }
    }
}
