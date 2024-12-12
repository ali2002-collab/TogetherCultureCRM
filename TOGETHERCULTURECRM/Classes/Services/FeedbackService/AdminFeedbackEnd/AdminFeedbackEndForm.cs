using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOGETHERCULTURECRM.Classes.Services.FeedbackService.AdminFeedbackEnd
{
    public partial class AdminFeedbackEndForm : Form
    {
        private readonly FeedbackService _feedbackService;
        public AdminFeedbackEndForm()
        {
            InitializeComponent();
            _feedbackService = new FeedbackService();
        }

        private void AdminFeedbackEndForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                // Load feedback from the service
                var feedbackData = _feedbackService.GetAllFeedback();
                if (feedbackData != null)
                {
                    dgvFeedbackList.DataSource = feedbackData;
                }
                else
                {
                    MessageBox.Show("No feedback available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFeedbackList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a feedback to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the feedback_id of the selected feedback
                int feedbackId = Convert.ToInt32(dgvFeedbackList.SelectedRows[0].Cells["feedback_id"].Value);

                // Delete the feedback using the service
                if (_feedbackService.DeleteFeedback(feedbackId))
                {
                    MessageBox.Show("Feedback deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLoadFeedback.PerformClick(); // Refresh feedback list
                }
                else
                {
                    MessageBox.Show("Failed to delete feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFeedbackList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
