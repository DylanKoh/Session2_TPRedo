namespace Session2_TPRedo
{
    partial class SponsorManagerMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewPackages = new System.Windows.Forms.Button();
            this.btnAddPackages = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnViewSummary = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 68);
            this.panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 31);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(709, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sponsor Manager Main Menu";
            // 
            // btnViewPackages
            // 
            this.btnViewPackages.Location = new System.Drawing.Point(182, 139);
            this.btnViewPackages.Name = "btnViewPackages";
            this.btnViewPackages.Size = new System.Drawing.Size(233, 68);
            this.btnViewPackages.TabIndex = 4;
            this.btnViewPackages.Text = "View Sponsorship Packages";
            this.btnViewPackages.UseVisualStyleBackColor = true;
            this.btnViewPackages.Click += new System.EventHandler(this.btnViewPackages_Click);
            // 
            // btnAddPackages
            // 
            this.btnAddPackages.Location = new System.Drawing.Point(445, 139);
            this.btnAddPackages.Name = "btnAddPackages";
            this.btnAddPackages.Size = new System.Drawing.Size(233, 68);
            this.btnAddPackages.TabIndex = 5;
            this.btnAddPackages.Text = "Add Sponsorship Packages";
            this.btnAddPackages.UseVisualStyleBackColor = true;
            this.btnAddPackages.Click += new System.EventHandler(this.btnAddPackages_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(182, 243);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(233, 68);
            this.btnApprove.TabIndex = 6;
            this.btnApprove.Text = "Approve Sponsorship Bookings";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.Location = new System.Drawing.Point(445, 243);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(233, 68);
            this.btnViewSummary.TabIndex = 7;
            this.btnViewSummary.Text = "View Sponsorship Summary";
            this.btnViewSummary.UseVisualStyleBackColor = true;
            this.btnViewSummary.Click += new System.EventHandler(this.btnViewSummary_Click);
            // 
            // SponsorManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btnViewSummary);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnAddPackages);
            this.Controls.Add(this.btnViewPackages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SponsorManagerMain";
            this.Text = "SponsorManagerMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViewPackages;
        private System.Windows.Forms.Button btnAddPackages;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnViewSummary;
    }
}