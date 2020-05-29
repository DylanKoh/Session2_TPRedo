using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2_TPRedo
{
    public partial class SponsorManagerMain : Form
    {
        public SponsorManagerMain()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).ShowDialog();
            this.Close();
        }

        private void btnViewPackages_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new ViewPackages()).ShowDialog();
            this.Close();
        }

        private void btnAddPackages_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new AddPackages()).ShowDialog();
            this.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new ApproveBookings()).ShowDialog();
            this.Close();
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new ViewSummary()).ShowDialog();
            this.Close();
        }
    }
}
