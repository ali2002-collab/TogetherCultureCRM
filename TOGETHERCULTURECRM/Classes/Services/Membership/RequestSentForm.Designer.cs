namespace TOGETHERCULTURECRM.Classes.Services.Membership
{
    partial class RequestSentForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.requestHasBeenSentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TOGETHERCULTURECRM.Properties.Resources.Untitled_design__4_;
            this.pictureBox1.Location = new System.Drawing.Point(277, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // requestHasBeenSentLabel
            // 
            this.requestHasBeenSentLabel.AutoSize = true;
            this.requestHasBeenSentLabel.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestHasBeenSentLabel.ForeColor = System.Drawing.Color.White;
            this.requestHasBeenSentLabel.Location = new System.Drawing.Point(122, 333);
            this.requestHasBeenSentLabel.Name = "requestHasBeenSentLabel";
            this.requestHasBeenSentLabel.Size = new System.Drawing.Size(589, 23);
            this.requestHasBeenSentLabel.TabIndex = 1;
            this.requestHasBeenSentLabel.Text = "The Request Has Already Been Sent to Admin for Approval, Thanks For Waiting ";
            // 
            // RequestSentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.requestHasBeenSentLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RequestSentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestSentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label requestHasBeenSentLabel;
    }
}