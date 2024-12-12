using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Services.Interest_Selection
{
    public partial class InterestSelectionForm : Form
    {
        private readonly InterestSelection interestService = new InterestSelection();
        private int userId;
        public InterestSelectionForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.userId = userId;
            LoadTags();
            LoadSelectedTags();
        }

        // Load all available tags
        private void LoadTags()
        {
            DataTable tags = interestService.GetAllTags();
            if (tags != null)
            {
                lstAvailableTags.DataSource = tags;
                lstAvailableTags.DisplayMember = "tag_name";
                lstAvailableTags.ValueMember = "tag_id";
            }
            else
            {
                MessageBox.Show("Failed to load available tags.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Load member's selected tags
        private void LoadSelectedTags()
        {
            DataTable selectedTags = interestService.GetMemberInterests(userId);
            if (selectedTags != null)
            {
                lstSelectedTags.DataSource = selectedTags;
                lstSelectedTags.DisplayMember = "tag_name";
                lstSelectedTags.ValueMember = "tag_id";
            }
            else
            {
                MessageBox.Show("Failed to load selected tags.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstAvailableTags_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            if (lstAvailableTags.SelectedItem != null)
            {
                int tagId = Convert.ToInt32(((DataRowView)lstAvailableTags.SelectedItem)["tag_id"]);
                try
                {
                    if (interestService.AddMemberInterest(userId, tagId))
                    {
                        MessageBox.Show("Tag added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSelectedTags(); // Refresh selected tags
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lstSelectedTags_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            if (lstSelectedTags.SelectedItem != null)
            {
                int tagId = Convert.ToInt32(((DataRowView)lstSelectedTags.SelectedItem)["tag_id"]);
                string query = "DELETE FROM MemberTags WHERE user_id = @UserId AND tag_id = @TagId";
                SqlParameter[] parameters = {
                    new SqlParameter("@UserId", userId),
                    new SqlParameter("@TagId", tagId)
                };

                DbHelper dbHelper = new DbHelper();
                if (dbHelper.ExecuteNonQuery(query, parameters) > 0)
                {
                    MessageBox.Show("Tag removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSelectedTags(); // Refresh selected tags
                }
                else
                {
                    MessageBox.Show("Failed to remove tag.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
