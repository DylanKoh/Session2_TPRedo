namespace Session2_TPRedo
{
    partial class BookPackage
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTier = new System.Windows.Forms.ComboBox();
            this.nudBudget = new System.Windows.Forms.NumericUpDown();
            this.cbOnline = new System.Windows.Forms.CheckBox();
            this.cbFlyers = new System.Windows.Forms.CheckBox();
            this.cbBanner = new System.Windows.Forms.CheckBox();
            this.nudDesiredQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnBook = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.packageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Online = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flyers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesiredQuantity)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 68);
            this.panel1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 31);
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
            this.label2.Location = new System.Drawing.Point(323, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Sponsorship Packages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter By Tier: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filter By Budget: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Filter By Benefit: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Desired Quantity: ";
            // 
            // cbTier
            // 
            this.cbTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTier.FormattingEnabled = true;
            this.cbTier.Location = new System.Drawing.Point(167, 112);
            this.cbTier.Name = "cbTier";
            this.cbTier.Size = new System.Drawing.Size(202, 21);
            this.cbTier.TabIndex = 9;
            this.cbTier.SelectedIndexChanged += new System.EventHandler(this.cbTier_SelectedIndexChanged);
            // 
            // nudBudget
            // 
            this.nudBudget.Location = new System.Drawing.Point(167, 145);
            this.nudBudget.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.nudBudget.Name = "nudBudget";
            this.nudBudget.Size = new System.Drawing.Size(202, 21);
            this.nudBudget.TabIndex = 10;
            this.nudBudget.ValueChanged += new System.EventHandler(this.nudBudget_ValueChanged);
            // 
            // cbOnline
            // 
            this.cbOnline.AutoSize = true;
            this.cbOnline.Location = new System.Drawing.Point(167, 179);
            this.cbOnline.Name = "cbOnline";
            this.cbOnline.Size = new System.Drawing.Size(62, 17);
            this.cbOnline.TabIndex = 11;
            this.cbOnline.Text = "Online";
            this.cbOnline.UseVisualStyleBackColor = true;
            this.cbOnline.CheckedChanged += new System.EventHandler(this.cbOnline_CheckedChanged);
            // 
            // cbFlyers
            // 
            this.cbFlyers.AutoSize = true;
            this.cbFlyers.Location = new System.Drawing.Point(235, 179);
            this.cbFlyers.Name = "cbFlyers";
            this.cbFlyers.Size = new System.Drawing.Size(60, 17);
            this.cbFlyers.TabIndex = 12;
            this.cbFlyers.Text = "Flyers";
            this.cbFlyers.UseVisualStyleBackColor = true;
            this.cbFlyers.CheckedChanged += new System.EventHandler(this.cbFlyers_CheckedChanged);
            // 
            // cbBanner
            // 
            this.cbBanner.AutoSize = true;
            this.cbBanner.Location = new System.Drawing.Point(301, 179);
            this.cbBanner.Name = "cbBanner";
            this.cbBanner.Size = new System.Drawing.Size(67, 17);
            this.cbBanner.TabIndex = 13;
            this.cbBanner.Text = "Banner";
            this.cbBanner.UseVisualStyleBackColor = true;
            this.cbBanner.CheckedChanged += new System.EventHandler(this.cbBanner_CheckedChanged);
            // 
            // nudDesiredQuantity
            // 
            this.nudDesiredQuantity.Location = new System.Drawing.Point(130, 517);
            this.nudDesiredQuantity.Name = "nudDesiredQuantity";
            this.nudDesiredQuantity.Size = new System.Drawing.Size(120, 21);
            this.nudDesiredQuantity.TabIndex = 14;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(835, 512);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(86, 27);
            this.btnBook.TabIndex = 15;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packageID,
            this.Tier,
            this.PackageName,
            this.Value,
            this.AvailableQuantity,
            this.Online,
            this.Flyers,
            this.Banner});
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(909, 304);
            this.dataGridView1.TabIndex = 16;
            // 
            // packageID
            // 
            this.packageID.HeaderText = "Package ID";
            this.packageID.Name = "packageID";
            this.packageID.ReadOnly = true;
            this.packageID.Visible = false;
            this.packageID.Width = 98;
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
            this.Value.Width = 84;
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
            // Flyers
            // 
            this.Flyers.HeaderText = "Flyers";
            this.Flyers.Name = "Flyers";
            this.Flyers.ReadOnly = true;
            this.Flyers.Width = 66;
            // 
            // Banner
            // 
            this.Banner.HeaderText = "Banner";
            this.Banner.Name = "Banner";
            this.Banner.ReadOnly = true;
            this.Banner.Width = 73;
            // 
            // BookPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.nudDesiredQuantity);
            this.Controls.Add(this.cbBanner);
            this.Controls.Add(this.cbFlyers);
            this.Controls.Add(this.cbOnline);
            this.Controls.Add(this.nudBudget);
            this.Controls.Add(this.cbTier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookPackage";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesiredQuantity)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTier;
        private System.Windows.Forms.NumericUpDown nudBudget;
        private System.Windows.Forms.CheckBox cbOnline;
        private System.Windows.Forms.CheckBox cbFlyers;
        private System.Windows.Forms.CheckBox cbBanner;
        private System.Windows.Forms.NumericUpDown nudDesiredQuantity;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tier;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Online;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flyers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banner;
    }
}