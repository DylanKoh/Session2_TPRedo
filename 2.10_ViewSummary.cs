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
    public partial class ViewSummary : Form
    {
        public ViewSummary()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new SponsorManagerMain()).ShowDialog();
            this.Close();
        }
    }
}
