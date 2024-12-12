using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOGETHERCULTURECRM.Classes.Services.FeedbackService.MemberFeedbackEnd
{
    public partial class MemberFeedbackEndForm : Form
    {
        private readonly FeedbackService _feedbackService;
        private readonly int _userId;
        public MemberFeedbackEndForm(int userId)
        {
            InitializeComponent();
            _feedbackService = new FeedbackService();
            _userId = userId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from the form
                string entityType = cmbEntityType.SelectedItem?.ToString();
                string feedbackText = txtFeedbackText.Text.Trim();
                int rating = (int)numRating.Value;

                if (string.IsNullOrEmpty(entityType) || string.IsNullOrEmpty(feedbackText))
                {
                    MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Save feedback using the service
                _feedbackService.SaveFeedback(_userId, entityType, feedbackText, rating);

                MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numRating_ValueChanged(object sender, EventArgs e)
        {

        }

        private void feedback_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEntityType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
