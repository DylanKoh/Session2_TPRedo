namespace Session2_TPRedo
{
    partial class ViewPackages
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
            this.label3 = new System.Windows.Forms.Label();
            this.rbTier = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbvalue = new System.Windows.Forms.RadioButton();
            this.rbQuantity = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PackageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Online = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.TabIndex = 3;
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
            this.label2.Location = new System.Drawing.Point(317, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "View Sponsorship Packages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sort By: ";
            // 
            // rbTier
            // 
            this.rbTier.AutoSize = true;
            this.rbTier.Location = new System.Drawing.Point(169, 130);
            this.rbTier.Name = "rbTier";
            this.rbTier.Size = new System.Drawing.Size(47, 17);
            this.rbTier.TabIndex = 6;
            this.rbTier.TabStop = true;
            this.rbTier.Text = "Tier";
            this.rbTier.UseVisualStyleBackColor = true;
            this.rbTier.CheckedChanged += new System.EventHandler(this.rbTier_CheckedChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(222, 130);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(58, 17);
            this.rbName.TabIndex = 7;
            this.rbName.TabStop = true;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbvalue
            // 
            this.rbvalue.AutoSize = true;
            this.rbvalue.Location = new System.Drawing.Point(169, 159);
            this.rbvalue.Name = "rbvalue";
            this.rbvalue.Size = new System.Drawing.Size(128, 17);
            this.rbvalue.TabIndex = 8;
            this.rbvalue.TabStop = true;
            this.rbvalue.Text = "Value (Ascending)";
            this.rbvalue.UseVisualStyleBackColor = true;
            this.rbvalue.CheckedChanged += new System.EventHandler(this.rbvalue_CheckedChanged);
            // 
            // rbQuantity
            // 
            this.rbQuantity.AutoSize = true;
            this.rbQuantity.Location = new System.Drawing.Point(303, 159);
            this.rbQuantity.Name = "rbQuantity";
            this.rbQuantity.Size = new System.Drawing.Size(153, 17);
            this.rbQuantity.TabIndex = 9;
            this.rbQuantity.TabStop = true;
            this.rbQuantity.Text = "Quantity (Descending)";
            this.rbQuantity.UseVisualStyleBackColor = true;
            this.rbQuantity.CheckedChanged += new System.EventHandler(this.rbQuantity_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageID,
            this.Tier,
            this.PackageName,
            this.Value,
            this.AvailableQuantity,
            this.Online,
            this.Flyer,
            this.Banner});
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(909, 256);
            this.dataGridView1.TabIndex = 10;
            // 
            // PackageID
            // 
            this.PackageID.HeaderText = "PackageID";
            this.PackageID.Name = "PackageID";
            this.PackageID.ReadOnly = true;
            this.PackageID.Visible = false;
            this.PackageID.Width = 94;
            // 
            // Tier
            // 
            this.Tier.HeaderText = "Tier";
            this.Tier.Name = "Tier";
            this.Tier.ReadOnly = true;
            this.Tier.Width = 54;
            // 
            // PackageName
            // 
            this.PackageName.HeaderText = "Name";
            this.PackageName.Name = "PackageName";
            this.PackageName.ReadOnly = true;
            this.PackageName.Width = 65;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value ($)";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 78;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.HeaderText = "Available Quantity";
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.ReadOnly = true;
            this.AvailableQuantity.Width = 124;
            // 
            // Online
            // 
            this.Online.HeaderText = "Online";
            this.Online.Name = "Online";
            this.Online.ReadOnly = true;
            this.Online.Width = 68;
            // 
            // Flyer
            // 
            this.Flyer.HeaderText = "Flyer";
            this.Flyer.Name = "Flyer";
            this.Flyer.ReadOnly = true;
            this.Flyer.Width = 60;
            // 
            // Banner
            // 
            this.Banner.HeaderText = "Banner";
            this.Banner.Name = "Banner";
            this.Banner.ReadOnly = true;
            this.Banner.Width = 73;
            // 
            // ViewPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbQuantity);
            this.Controls.Add(this.rbvalue);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.rbTier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewPackages";
            this.Text = "ViewPackages";
            this.Load += new System.EventHandler(this.ViewPackages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbTier;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbvalue;
        private System.Windows.Forms.RadioButton rbQuantity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tier;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Online;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banner;
    }
}