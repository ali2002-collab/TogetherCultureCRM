using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Admin.Create;
using TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Admin.Edit;
using TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Admin.SpaceStats;

namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Admin
{
    public partial class SpaceAdminForm : Form
    {
        private readonly SpaceService _spaceService;
        private DataTable _spacesData;
        private int _currentPage = 0; 
        private const int PostsPerPage = 3; 
        


        public SpaceAdminForm()
        {
            InitializeComponent();
            _spaceService = new SpaceService();
            LoadSpaces(); // Load spaces on form initialization
        }

        private void LoadSpaces()
        {
            try
            {
                // Fetch all spaces from the database
                _spacesData = _spaceService.GetSpaces();

                if (_spacesData.Rows.Count == 0)
                {
                    lblNoSpaces.Visible = true;
                    pnlSpacePosts.Visible = false;
                }
                else
                {
                    lblNoSpaces.Visible = false;
                    pnlSpacePosts.Visible = true;
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
            pnlSpacePosts.Controls.Clear(); // Clear existing posts

            // Calculate start and end indices for the current page
            int startIndex = page * PostsPerPage;
            int endIndex = Math.Min(startIndex + PostsPerPage, _spacesData.Rows.Count);

            int verticalOffset = 10; // Initial vertical offset
            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow row = _spacesData.Rows[i];
                Panel spacePost = CreateSpacePost(row);
                spacePost.Location = new Point(10, verticalOffset);
                pnlSpacePosts.Controls.Add(spacePost);

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
                Size = new Size(pnlSpacePosts.Width - 40, 260), 
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
            // Stats Button
            Button btnStats = new Button
            {
                Text = "Stats",
                Size = new Size(80, 30),
                Location = new Point(panel.Width - 120, panel.Height - 140),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            btnStats.Click += (s, e) => OpenSpaceStatsForm((int)row["space_id"]);

            Button btnEdit = new Button
            {
                Text = "Edit",
                Size = new Size(80, 30),
                Location = new Point(panel.Width - 220, panel.Height - 50),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            btnEdit.Click += (s, e) =>
            {
                EditSpaceForm editForm = new EditSpaceForm((int)row["space_id"]);
                editForm.FormClosed += (s1, e1) => LoadSpaces(); // Reload spaces after editing
                editForm.ShowDialog();
            };
            // Delete Button
            Button btnDelete = new Button
            {
                Text = "Delete",
                Size = new Size(80, 30),
                Location = new Point(panel.Width - 120, panel.Height - 50),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            btnDelete.Click += (s, e) => DeleteSpace((int)row["space_id"]);

            // Add controls to the panel
            panel.Controls.Add(lblLocation);
            panel.Controls.Add(lblSpaceType);
            panel.Controls.Add(lblCapacity);
            panel.Controls.Add(lblOpeningTime);
            panel.Controls.Add(lblClosingTime);
            panel.Controls.Add(lblDescription);
            panel.Controls.Add(btnStats);
            panel.Controls.Add(btnEdit);
            panel.Controls.Add(btnDelete);

            return panel;
        }

        private void OpenSpaceStatsForm(int spaceId)
        {
            SpaceStatsForm statsForm = new SpaceStatsForm(spaceId);
            statsForm.ShowDialog();
        }

        


        private void DeleteSpace(int spaceId)
        {
            if (MessageBox.Show("Are you sure you want to delete this space?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_spaceService.DeleteSpace(spaceId))
                {
                    MessageBox.Show("Space deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSpaces();

                    // Adjust page index if last page no longer has posts
                    if (_currentPage * PostsPerPage >= _spacesData.Rows.Count && _currentPage > 0)
                    {
                        _currentPage--;
                    }

                    ShowPage(_currentPage); 
                }
                else
                {
                    MessageBox.Show("Failed to delete space.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pnlSpacePosts_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnOpenCreateSpaceForm_Click(object sender, EventArgs e)
        {
            AdminSpaceCreateForm adminSpaceCreateForm = new AdminSpaceCreateForm();
            adminSpaceCreateForm.ShowDialog();
        }
    }
}
