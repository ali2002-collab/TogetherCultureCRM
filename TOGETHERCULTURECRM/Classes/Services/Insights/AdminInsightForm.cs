using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TOGETHERCULTURECRM.Classes.Services.Insights
{
    public partial class AdminInsightForm : Form
    {
        private readonly InsightService _insightService;
        public AdminInsightForm()
        {
            InitializeComponent();
            _insightService = new InsightService();
        }

        private void LoadInsights()
        {
            try
            {
                // Load Members Joined Last Week
                int membersJoinedLastWeek = _insightService.GetMembersJoinedLastWeek();
                lblMembersJoinedLastWeek.Text = $"Members Joined Last Week: {membersJoinedLastWeek}";

                // Load Active Members
                int activeMembers = _insightService.GetActiveMembers();
                lblActiveMembers.Text = $"Active Members: {activeMembers}";

                // Load User Growth Chart
                DataTable userGrowthStats = _insightService.GetUserGrowthStats();
                LoadUserGrowthChart(userGrowthStats);

                // Load Membership Plan Growth Chart
                DataTable membershipPlanStats = _insightService.GetMembershipPlanStats();
                LoadMembershipPlanGrowthChart(membershipPlanStats);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading insights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadUserGrowthChart(DataTable stats)
        {
            chartUserGrowth.Series.Clear();
            chartUserGrowth.Titles.Clear();
            chartUserGrowth.Titles.Add("User Registration Growth");

            Series series = new Series
            {
                Name = "Users",
                ChartType = SeriesChartType.Line,
                Color = Color.Blue
            };

            foreach (DataRow row in stats.Rows)
            {
                series.Points.AddXY(Convert.ToDateTime(row["RegistrationDate"]), Convert.ToInt32(row["UsersCount"]));
            }

            chartUserGrowth.Series.Add(series);
        }

        private void LoadMembershipPlanGrowthChart(DataTable stats)
        {
            chartMembershipPlanGrowth.Series.Clear();
            chartMembershipPlanGrowth.Titles.Clear();
            chartMembershipPlanGrowth.Titles.Add("Membership Plan Growth");

            Series series = new Series
            {
                Name = "Plans",
                ChartType = SeriesChartType.Column,
                Color = Color.Green
            };

            foreach (DataRow row in stats.Rows)
            {
                series.Points.AddXY(row["plan_name"].ToString(), Convert.ToInt32(row["MembersCount"]));
            }

            chartMembershipPlanGrowth.Series.Add(series);
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInsights();
        }

        private void lblMembersJoinedLastWeek_Click(object sender, EventArgs e)
        {

        }

        private void lblActiveMembers_Click(object sender, EventArgs e)
        {

        }

        private void chartUserGrowth_Click(object sender, EventArgs e)
        {

        }

        private void chartMembershipPlanGrowth_Click(object sender, EventArgs e)
        {

        }

        private void AdminInsightForm_Load(object sender, EventArgs e)
        {
            LoadInsights();
        }
    }
}
