using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOGETHERCULTURECRM.Classes.Services.Search
{

    public partial class SearchResultFormAdmin : Form
    {
        public SearchResultFormAdmin()
        {
            InitializeComponent();
        }
        public void LoadSearchResults(DataTable results)
        {
            dgvSearchResultsAdmin.DataSource = results;
            dgvSearchResultsAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Optionally format columns for better readability
            dgvSearchResultsAdmin.Columns["Category"].HeaderText = "Type";
            dgvSearchResultsAdmin.Columns["Details"].HeaderText = "Details";
            dgvSearchResultsAdmin.Columns["Date"].HeaderText = "Date";
        }
        private void dgvSearchResultsAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClearSearchAdmin_Click(object sender, EventArgs e)
        {
            dgvSearchResultsAdmin.DataSource = null;
        }
    }
}
