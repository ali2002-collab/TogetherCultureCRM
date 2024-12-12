namespace TOGETHERCULTURECRM.Classes.Services.Insights
{
    partial class AdminInsightForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblInsights = new System.Windows.Forms.Label();
            this.lblCreateDifference = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chartUserGrowth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMembershipPlanGrowth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMembersJoinedLastWeek = new System.Windows.Forms.Label();
            this.lblActiveMembers = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartUserGrowth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMembershipPlanGrowth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInsights
            // 
            this.lblInsights.AutoSize = true;
            this.lblInsights.BackColor = System.Drawing.Color.Transparent;
            this.lblInsights.Font = new System.Drawing.Font("Poppins", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblInsights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.lblInsights.Location = new System.Drawing.Point(23, 9);
            this.lblInsights.Name = "lblInsights";
            this.lblInsights.Size = new System.Drawing.Size(138, 50);
            this.lblInsights.TabIndex = 12;
            this.lblInsights.Text = "Insights";
            // 
            // lblCreateDifference
            // 
            this.lblCreateDifference.AutoSize = true;
            this.lblCreateDifference.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateDifference.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblCreateDifference.ForeColor = System.Drawing.Color.Black;
            this.lblCreateDifference.Location = new System.Drawing.Point(414, 22);
            this.lblCreateDifference.Name = "lblCreateDifference";
            this.lblCreateDifference.Size = new System.Drawing.Size(328, 30);
            this.lblCreateDifference.TabIndex = 14;
            this.lblCreateDifference.Text = "Lets See How Business Is Progressing";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(977, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 38);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chartUserGrowth
            // 
            chartArea1.Name = "ChartArea1";
            this.chartUserGrowth.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartUserGrowth.Legends.Add(legend1);
            this.chartUserGrowth.Location = new System.Drawing.Point(32, 264);
            this.chartUserGrowth.Name = "chartUserGrowth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartUserGrowth.Series.Add(series1);
            this.chartUserGrowth.Size = new System.Drawing.Size(464, 286);
            this.chartUserGrowth.TabIndex = 16;
            this.chartUserGrowth.Text = "chart1";
            this.chartUserGrowth.Click += new System.EventHandler(this.chartUserGrowth_Click);
            // 
            // chartMembershipPlanGrowth
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMembershipPlanGrowth.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMembershipPlanGrowth.Legends.Add(legend2);
            this.chartMembershipPlanGrowth.Location = new System.Drawing.Point(581, 264);
            this.chartMembershipPlanGrowth.Name = "chartMembershipPlanGrowth";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMembershipPlanGrowth.Series.Add(series2);
            this.chartMembershipPlanGrowth.Size = new System.Drawing.Size(562, 286);
            this.chartMembershipPlanGrowth.TabIndex = 17;
            this.chartMembershipPlanGrowth.Text = "chart2";
            this.chartMembershipPlanGrowth.Click += new System.EventHandler(this.chartMembershipPlanGrowth_Click);
            // 
            // lblMembersJoinedLastWeek
            // 
            this.lblMembersJoinedLastWeek.AutoSize = true;
            this.lblMembersJoinedLastWeek.BackColor = System.Drawing.Color.Transparent;
            this.lblMembersJoinedLastWeek.Font = new System.Drawing.Font("Poppins", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblMembersJoinedLastWeek.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblMembersJoinedLastWeek.Location = new System.Drawing.Point(58, 136);
            this.lblMembersJoinedLastWeek.Name = "lblMembersJoinedLastWeek";
            this.lblMembersJoinedLastWeek.Size = new System.Drawing.Size(240, 50);
            this.lblMembersJoinedLastWeek.TabIndex = 18;
            this.lblMembersJoinedLastWeek.Text = "MemberJoined";
            this.lblMembersJoinedLastWeek.Click += new System.EventHandler(this.lblMembersJoinedLastWeek_Click);
            // 
            // lblActiveMembers
            // 
            this.lblActiveMembers.AutoSize = true;
            this.lblActiveMembers.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveMembers.Font = new System.Drawing.Font("Poppins", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblActiveMembers.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblActiveMembers.Location = new System.Drawing.Point(577, 136);
            this.lblActiveMembers.Name = "lblActiveMembers";
            this.lblActiveMembers.Size = new System.Drawing.Size(201, 50);
            this.lblActiveMembers.TabIndex = 20;
            this.lblActiveMembers.Text = "Active Users";
            this.lblActiveMembers.Click += new System.EventHandler(this.lblActiveMembers_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(957, 92);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(153, 38);
            this.btnGenerateReport.TabIndex = 21;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // AdminInsightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 651);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.lblActiveMembers);
            this.Controls.Add(this.lblMembersJoinedLastWeek);
            this.Controls.Add(this.chartMembershipPlanGrowth);
            this.Controls.Add(this.chartUserGrowth);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblCreateDifference);
            this.Controls.Add(this.lblInsights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminInsightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminInsightForm";
            this.Load += new System.EventHandler(this.AdminInsightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUserGrowth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMembershipPlanGrowth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsights;
        private System.Windows.Forms.Label lblCreateDifference;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUserGrowth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMembershipPlanGrowth;
        private System.Windows.Forms.Label lblMembersJoinedLastWeek;
        private System.Windows.Forms.Label lblActiveMembers;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}