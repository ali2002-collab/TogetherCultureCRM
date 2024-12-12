using System;
using System.Data;
using System.Windows.Forms;

namespace TOGETHERCULTURECRM.Classes.Services.Search
{
    public partial class SearchResultForm : Form
    {
        public SearchResultForm()
        {
            InitializeComponent();
        }
        public void LoadSearchResults(DataTable results)
        {
            dgvSearchResults.DataSource = results;
            dgvSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSearchResults.Columns["Category"].HeaderText = "Type";
            dgvSearchResults.Columns["Location"].HeaderText = "Details";
            dgvSearchResults.Columns["Date"].HeaderText = "Event Date";
        }

        private void dgvSearchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            dgvSearchResults.DataSource = null;
        }
    }
}
