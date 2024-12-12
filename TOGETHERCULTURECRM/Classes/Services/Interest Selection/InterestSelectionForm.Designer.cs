namespace TOGETHERCULTURECRM.Classes.Services.Interest_Selection
{
    partial class InterestSelectionForm
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
            this.lstAvailableTags = new System.Windows.Forms.ListBox();
            this.lstSelectedTags = new System.Windows.Forms.ListBox();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAvailableTags
            // 
            this.lstAvailableTags.FormattingEnabled = true;
            this.lstAvailableTags.Location = new System.Drawing.Point(42, 91);
            this.lstAvailableTags.Name = "lstAvailableTags";
            this.lstAvailableTags.Size = new System.Drawing.Size(304, 186);
            this.lstAvailableTags.TabIndex = 0;
            this.lstAvailableTags.SelectedIndexChanged += new System.EventHandler(this.lstAvailableTags_SelectedIndexChanged);
            // 
            // lstSelectedTags
            // 
            this.lstSelectedTags.FormattingEnabled = true;
            this.lstSelectedTags.Location = new System.Drawing.Point(471, 91);
            this.lstSelectedTags.Name = "lstSelectedTags";
            this.lstSelectedTags.Size = new System.Drawing.Size(304, 186);
            this.lstSelectedTags.TabIndex = 1;
            this.lstSelectedTags.SelectedIndexChanged += new System.EventHandler(this.lstSelectedTags_SelectedIndexChanged);
            // 
            // btnAddTag
            // 
            this.btnAddTag.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddTag.FlatAppearance.BorderSize = 0;
            this.btnAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTag.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTag.ForeColor = System.Drawing.Color.White;
            this.btnAddTag.Location = new System.Drawing.Point(140, 303);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(102, 29);
            this.btnAddTag.TabIndex = 14;
            this.btnAddTag.Text = "Add";
            this.btnAddTag.UseVisualStyleBackColor = false;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRemoveTag.FlatAppearance.BorderSize = 0;
            this.btnRemoveTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTag.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTag.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTag.Location = new System.Drawing.Point(588, 303);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(102, 29);
            this.btnRemoveTag.TabIndex = 15;
            this.btnRemoveTag.Text = "Del";
            this.btnRemoveTag.UseVisualStyleBackColor = false;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(372, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 29);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // InterestSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemoveTag);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.lstSelectedTags);
            this.Controls.Add(this.lstAvailableTags);
            this.Name = "InterestSelectionForm";
            this.Text = "InterestSelectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAvailableTags;
        private System.Windows.Forms.ListBox lstSelectedTags;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Button btnRemoveTag;
        private System.Windows.Forms.Button btnCancel;
    }
}