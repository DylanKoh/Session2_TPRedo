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
    public partial class SponsorMain : Form
    {
        User _user;
        public SponsorMain(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).ShowDialog();
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new BookPackage(_user)).ShowDialog();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new UpdateBook(_user)).ShowDialog();
            this.Close();
        }
    }
}
