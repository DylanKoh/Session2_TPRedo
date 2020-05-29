namespace Session2_TPRedo
{
    partial class UpdateBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNewQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndividualValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityBooked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewQuantity)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(322, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Update Sponsorship Bookings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingID,
            this.Tier,
            this.PackageName,
            this.IndividualValue,
            this.QuantityBooked,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(909, 271);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total ($): ";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(700, 402);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(14, 13);
            this.lblTotalValue.TabIndex = 7;
            this.lblTotalValue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "New Quantity: ";
            // 
            // nudNewQuantity
            // 
            this.nudNewQuantity.Location = new System.Drawing.Point(633, 452);
            this.nudNewQuantity.Name = "nudNewQuantity";
            this.nudNewQuantity.Size = new System.Drawing.Size(120, 21);
            this.nudNewQuantity.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(759, 446);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Quantity";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(821, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BookingID
            // 
            this.BookingID.HeaderText = "BookingID";
            this.BookingID.Name = "BookingID";
            this.BookingID.ReadOnly = true;
            this.BookingID.Visible = false;
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
            // IndividualValue
            // 
            this.IndividualValue.HeaderText = "Individual Value ($)";
            this.IndividualValue.Name = "IndividualValue";
            this.IndividualValue.ReadOnly = true;
            this.IndividualValue.Width = 116;
            // 
            // QuantityBooked
            // 
            this.QuantityBooked.HeaderText = "Quantity Booked";
            this.QuantityBooked.Name = "QuantityBooked";
            this.QuantityBooked.ReadOnly = true;
            this.QuantityBooked.Width = 116;
            // 
            // Total
            // 
            this.Total.HeaderText = "Sub-Total Value ($)";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 114;
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.nudNewQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateBook";
            this.Text = "UpdateBook";
            this.Load += new System.EventHandler(this.UpdateBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNewQuantity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tier;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndividualValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityBooked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}