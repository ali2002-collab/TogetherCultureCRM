namespace TOGETHERCULTURECRM.Classes.Services.Search
{
    partial class SearchResultFormAdmin
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
            this.dgvSearchResultsAdmin = new System.Windows.Forms.DataGridView();
            this.btnClearSearchAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResultsAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchResultsAdmin
            // 
            this.dgvSearchResultsAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchResultsAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResultsAdmin.Location = new System.Drawing.Point(12, 12);
            this.dgvSearchResultsAdmin.Name = "dgvSearchResultsAdmin";
            this.dgvSearchResultsAdmin.Size = new System.Drawing.Size(1148, 534);
            this.dgvSearchResultsAdmin.TabIndex = 1;
            this.dgvSearchResultsAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResultsAdmin_CellContentClick);
            // 
            // btnClearSearchAdmin
            // 
            this.btnClearSearchAdmin.BackColor = System.Drawing.Color.DarkGray;
            this.btnClearSearchAdmin.FlatAppearance.BorderSize = 0;
            this.btnClearSearchAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearchAdmin.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearchAdmin.ForeColor = System.Drawing.Color.White;
            this.btnClearSearchAdmin.Location = new System.Drawing.Point(560, 552);
            this.btnClearSearchAdmin.Name = "btnClearSearchAdmin";
            this.btnClearSearchAdmin.Size = new System.Drawing.Size(89, 29);
            this.btnClearSearchAdmin.TabIndex = 3;
            this.btnClearSearchAdmin.Text = "Clear";
            this.btnClearSearchAdmin.UseVisualStyleBackColor = false;
            this.btnClearSearchAdmin.Click += new System.EventHandler(this.btnClearSearchAdmin_Click);
            // 
            // SearchResultFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 651);
            this.Controls.Add(this.btnClearSearchAdmin);
            this.Controls.Add(this.dgvSearchResultsAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchResultFormAdmin";
            this.Text = "SearchResultFormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResultsAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchResultsAdmin;
        private System.Windows.Forms.Button btnClearSearchAdmin;
    }
}