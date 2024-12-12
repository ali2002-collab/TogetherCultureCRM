namespace TOGETHERCULTURECRM.Classes.Services.DigitalContent
{
    partial class DemoForm
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
            this.lblDemoSection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDemoSection
            // 
            this.lblDemoSection.AutoSize = true;
            this.lblDemoSection.BackColor = System.Drawing.Color.Transparent;
            this.lblDemoSection.Font = new System.Drawing.Font("Poppins", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblDemoSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.lblDemoSection.Location = new System.Drawing.Point(474, 287);
            this.lblDemoSection.Name = "lblDemoSection";
            this.lblDemoSection.Size = new System.Drawing.Size(220, 50);
            this.lblDemoSection.TabIndex = 2;
            this.lblDemoSection.Text = "Demo Section";
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 651);
            this.Controls.Add(this.lblDemoSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DemoForm";
            this.Text = "DemoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDemoSection;
    }
}