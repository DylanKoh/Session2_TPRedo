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
    public partial class UpdateBook : Form
    {
        User _user;
        public UpdateBook(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new SponsorMain(_user)).ShowDialog();
            this.Close(); 
        }
    }
}
