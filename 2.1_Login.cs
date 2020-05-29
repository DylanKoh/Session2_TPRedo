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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new AccountCreate()).ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("One or more fields are empty!");
            }
            else
            {
                using (var context = new Session2Entities())
                {
                    var user = (from x in context.Users
                                where x.userId == txtUserID.Text
                                select x).FirstOrDefault();

                    if (user == null)
                    {
                        MessageBox.Show("User does not exit!");
                    }
                    else if (user.passwd != txtPassword.Text)
                    {
                        MessageBox.Show("Password incorrect!");
                    }
                    else
                    {
                        MessageBox.Show("Login successful!");
                        if (user.userTypeIdFK == 1)
                        {

                        }
                        else
                        {

                        }
                    }
                }
            }

        }
    }
}
