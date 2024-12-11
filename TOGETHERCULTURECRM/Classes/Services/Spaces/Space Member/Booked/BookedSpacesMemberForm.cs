using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOGETHERCULTURECRM.Classes.Services.Spaces.Space_Member.Booked
{
    public partial class BookedSpacesMemberForm : Form
    {
        private readonly SpaceService _spaceService;
        private readonly int _userId;
        public BookedSpacesMemberForm(int userId)
        {
            InitializeComponent();
            _spaceService = new SpaceService();
            _userId = userId;
        }

        private void dataGridViewListOfBookedSpaces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadMemberBookedSpaces_Click(object sender, EventArgs e)
        {
            try
            {
                // Load the list of spaces the member has booked
                DataTable bookedSpaces = _spaceService.GetMemberBookedSpaces(_userId);

                if (bookedSpaces.Rows.Count == 0)
                {
                    MessageBox.Show("No spaces booked yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewListOfBookedSpaces.DataSource = null;
                }
                else
                {
                    dataGridViewListOfBookedSpaces.DataSource = bookedSpaces;
                    dataGridViewListOfBookedSpaces.Columns["utilization_id"].Visible = false; // Hide internal IDs
                    dataGridViewListOfBookedSpaces.Columns["space_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading booked spaces: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMemberUnbookSpaces_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (dataGridViewListOfBookedSpaces.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a space to unbook.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected row's utilization ID
                int utilizationId = Convert.ToInt32(dataGridViewListOfBookedSpaces.SelectedRows[0].Cells["utilization_id"].Value);

                // Confirm unbooking
                if (MessageBox.Show("Are you sure you want to unbook this space?", "Confirm Unbooking", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool success = _spaceService.UnbookSpace(utilizationId);
                    if (success)
                    {
                        MessageBox.Show("Space unbooked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLoadMemberBookedSpaces.PerformClick(); // Reload the list
                    }
                    else
                    {
                        MessageBox.Show("Failed to unbook space. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error unbooking space: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
