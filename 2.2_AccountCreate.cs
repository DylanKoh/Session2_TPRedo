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
    public partial class AccountCreate : Form
    {
        public AccountCreate()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).ShowDialog();
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text.Trim() == string.Empty || txtUserID.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty || txtReEnterPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("One of more fields are empty!");
            }
            else if (txtPassword.TextLength < 8)
            {
                MessageBox.Show("Password must be 8 characters or more!");
            }
            else if (txtPassword.Text != txtReEnterPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
            }
            else
            {
                using (var context = new Session2Entities())
                {
                    var checkUser = (from x in context.Users
                                     where x.name == txtCompanyName.Text
                                     select x).FirstOrDefault();

                    var checkUserID = (from x in context.Users
                                       where x.userId == txtUserID.Text
                                       select x).FirstOrDefault();

                    if (checkUser != null)
                    {
                        MessageBox.Show("Company sponsor account already exist!");
                    }
                    else if (checkUserID != null)
                    {
                        MessageBox.Show("User ID has been taken!");
                    }
                    else
                    {
                        context.Users.Add(new User() { name = txtCompanyName.Text, userId = txtUserID.Text, passwd = txtReEnterPassword.Text, userTypeIdFK = 2 });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
