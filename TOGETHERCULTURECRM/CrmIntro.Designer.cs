namespace TOGETHERCULTURECRM
{
    partial class CrmIntro
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
            this.LoginNavigator = new System.Windows.Forms.Button();
            this.RegisterNavigator = new System.Windows.Forms.Button();
            this.introLabelCrmIntro = new System.Windows.Forms.Label();
            this.TC_LOGO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TC_LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginNavigator
            // 
            this.LoginNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.LoginNavigator.FlatAppearance.BorderSize = 0;
            this.LoginNavigator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginNavigator.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginNavigator.ForeColor = System.Drawing.Color.White;
            this.LoginNavigator.Location = new System.Drawing.Point(482, 217);
            this.LoginNavigator.Name = "LoginNavigator";
            this.LoginNavigator.Size = new System.Drawing.Size(197, 40);
            this.LoginNavigator.TabIndex = 1;
            this.LoginNavigator.Text = "Login";
            this.LoginNavigator.UseVisualStyleBackColor = false;
            this.LoginNavigator.Click += new System.EventHandler(this.LoginNavigator_Click);
            // 
            // RegisterNavigator
            // 
            this.RegisterNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.RegisterNavigator.FlatAppearance.BorderSize = 0;
            this.RegisterNavigator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterNavigator.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNavigator.ForeColor = System.Drawing.Color.White;
            this.RegisterNavigator.Location = new System.Drawing.Point(482, 280);
            this.RegisterNavigator.Name = "RegisterNavigator";
            this.RegisterNavigator.Size = new System.Drawing.Size(197, 40);
            this.RegisterNavigator.TabIndex = 2;
            this.RegisterNavigator.Text = "Register";
            this.RegisterNavigator.UseVisualStyleBackColor = false;
            this.RegisterNavigator.Click += new System.EventHandler(this.RegisterNavigator_Click);
            // 
            // introLabelCrmIntro
            // 
            this.introLabelCrmIntro.AutoSize = true;
            this.introLabelCrmIntro.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabelCrmIntro.ForeColor = System.Drawing.Color.White;
            this.introLabelCrmIntro.Location = new System.Drawing.Point(436, 137);
            this.introLabelCrmIntro.Name = "introLabelCrmIntro";
            this.introLabelCrmIntro.Size = new System.Drawing.Size(293, 48);
            this.introLabelCrmIntro.TabIndex = 3;
            this.introLabelCrmIntro.Text = "Lets Grow Together ";
            // 
            // TC_LOGO
            // 
            this.TC_LOGO.Image = global::TOGETHERCULTURECRM.Properties.Resources.TC_Logos_01;
            this.TC_LOGO.Location = new System.Drawing.Point(50, 119);
            this.TC_LOGO.Name = "TC_LOGO";
            this.TC_LOGO.Size = new System.Drawing.Size(249, 219);
            this.TC_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TC_LOGO.TabIndex = 0;
            this.TC_LOGO.TabStop = false;
            // 
            // CrmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.introLabelCrmIntro);
            this.Controls.Add(this.RegisterNavigator);
            this.Controls.Add(this.LoginNavigator);
            this.Controls.Add(this.TC_LOGO);
            this.Name = "CrmIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrmIntro";
            this.Load += new System.EventHandler(this.CrmIntro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TC_LOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TC_LOGO;
        private System.Windows.Forms.Button LoginNavigator;
        private System.Windows.Forms.Button RegisterNavigator;
        private System.Windows.Forms.Label introLabelCrmIntro;
    }
}

