using System;
using System.Data;
using System.Drawing;
using System.IO;
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
            LoadInsights();
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

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "AdminInsightsReport.html");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("<html><body>");
                    writer.WriteLine("<h1>Admin Insights Report</h1>");
                    writer.WriteLine($"<p>Generated On: {DateTime.Now}</p>");
                    writer.WriteLine("<hr>");

                    // New Members
                    writer.WriteLine("<h2>New Members in Last Week</h2>");
                    writer.WriteLine($"<p>Total: {_insightService.GetMembersJoinedLastWeek()}</p>");

                    // Active Members
                    writer.WriteLine("<h2>Currently Active Members</h2>");
                    writer.WriteLine($"<p>Total: {_insightService.GetActiveMembers()}</p>");

                    // User Growth Data
                    writer.WriteLine("<h2>User Growth Statistics</h2>");
                    writer.WriteLine("<table border='1'><tr><th>Date</th><th>New Users</th></tr>");
                    DataTable userGrowthStats = _insightService.GetUserGrowthStats();
                    foreach (DataRow row in userGrowthStats.Rows)
                    {
                        writer.WriteLine($"<tr><td>{row["RegistrationDate"]}</td><td>{row["UsersCount"]}</td></tr>");
                    }
                    writer.WriteLine("</table>");

                    // Membership Plan Stats
                    writer.WriteLine("<h2>Membership Plan Growth</h2>");
                    writer.WriteLine("<table border='1'><tr><th>Plan Name</th><th>Members Count</th></tr>");
                    DataTable membershipPlanStats = _insightService.GetMembershipPlanStats();
                    foreach (DataRow row in membershipPlanStats.Rows)
                    {
                        writer.WriteLine($"<tr><td>{row["plan_name"]}</td><td>{row["MembersCount"]}</td></tr>");
                    }
                    writer.WriteLine("</table>");

                    writer.WriteLine("</body></html>");
                }

                MessageBox.Show($"Report saved successfully at {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
