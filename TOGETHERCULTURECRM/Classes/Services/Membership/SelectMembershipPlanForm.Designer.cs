namespace TOGETHERCULTURECRM.Classes.Services.Membership
{
    partial class SelectMembershipPlanForm
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
            this.PlanSelection = new System.Windows.Forms.ComboBox();
            this.selectMembership = new System.Windows.Forms.Label();
            this.payNowAndInterest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanSelection
            // 
            this.PlanSelection.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanSelection.FormattingEnabled = true;
            this.PlanSelection.Location = new System.Drawing.Point(313, 341);
            this.PlanSelection.Name = "PlanSelection";
            this.PlanSelection.Size = new System.Drawing.Size(197, 31);
            this.PlanSelection.TabIndex = 1;
            this.PlanSelection.SelectedIndexChanged += new System.EventHandler(this.PlanSelection_SelectedIndexChanged);
            // 
            // selectMembership
            // 
            this.selectMembership.AutoSize = true;
            this.selectMembership.BackColor = System.Drawing.Color.Transparent;
            this.selectMembership.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMembership.ForeColor = System.Drawing.Color.White;
            this.selectMembership.Location = new System.Drawing.Point(349, 315);
            this.selectMembership.Name = "selectMembership";
            this.selectMembership.Size = new System.Drawing.Size(129, 23);
            this.selectMembership.TabIndex = 2;
            this.selectMembership.Text = "Select Your Plan";
            // 
            // payNowAndInterest
            // 
            this.payNowAndInterest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.payNowAndInterest.FlatAppearance.BorderSize = 0;
            this.payNowAndInterest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payNowAndInterest.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payNowAndInterest.ForeColor = System.Drawing.Color.White;
            this.payNowAndInterest.Location = new System.Drawing.Point(313, 381);
            this.payNowAndInterest.Name = "payNowAndInterest";
            this.payNowAndInterest.Size = new System.Drawing.Size(197, 40);
            this.payNowAndInterest.TabIndex = 3;
            this.payNowAndInterest.Text = "Pay Now";
            this.payNowAndInterest.UseVisualStyleBackColor = false;
            this.payNowAndInterest.Click += new System.EventHandler(this.payNowAndInterest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TOGETHERCULTURECRM.Properties.Resources.Beige_Minimal_Pricing_Plan_Brainstorm;
            this.pictureBox1.Location = new System.Drawing.Point(121, -69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SelectMembershipPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.payNowAndInterest);
            this.Controls.Add(this.selectMembership);
            this.Controls.Add(this.PlanSelection);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SelectMembershipPlanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectMembershipPlanForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox PlanSelection;
        private System.Windows.Forms.Label selectMembership;
        private System.Windows.Forms.Button payNowAndInterest;
    }
}