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
    public partial class BookPackage : Form
    {
        User _user;
        List<DataGridViewRow> _originalSource = new List<DataGridViewRow>();
        List<DataGridViewRow> _modifiedSource = new List<DataGridViewRow>();
        public BookPackage(User user)
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

        private void Book_Load(object sender, EventArgs e)
        {
            LoadPicker();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            using (var context = new Session2Entities())
            {
                var getPackages = (from x in context.Packages
                                   where x.packageQuantity != 0
                                   select x);

                foreach (var item in getPackages)
                {
                    var newRow = new List<string>() { item.packageId.ToString(), item.packageTier, item.packageName, item.packageValue.ToString(), item.packageQuantity.ToString() };
                    var checkBenefits = (from x in context.Benefits
                                         where x.packageIdFK == item.packageId
                                         select x.benefitName).ToList();
                    if (checkBenefits.Contains("Online"))
                    {
                        newRow.Add("Yes");
                    }
                    else
                    {
                        newRow.Add("");
                    }
                    if (checkBenefits.Contains("Flyer"))
                    {
                        newRow.Add("Yes");
                    }
                    else
                    {
                        newRow.Add("");
                    }
                    if (checkBenefits.Contains("Banner"))
                    {
                        newRow.Add("Yes");
                    }
                    else
                    {
                        newRow.Add("");
                    }
                    dataGridView1.Rows.Add(newRow.ToArray());
                }
            }
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                _originalSource.Add(item);
                _modifiedSource.Clear();
            }

        }
        private void LoadPicker()
        {
            cbTier.Items.Clear();
            cbTier.Items.Add("No Filter");
            using (var context = new Session2Entities())
            {
                var tierList = (from x in context.Packages
                                select x.packageTier).Distinct().ToArray();
                cbTier.Items.AddRange(tierList);
            }
        }

        private void cbTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            _originalSource.Clear();
            LoadData();
            if (cbTier.SelectedItem.ToString() == "No Filter")
            {
                _originalSource.Clear();
                LoadData();
                if (nudBudget.Value > 0)
                {
                    nudBudget_ValueChanged(null, null);
                }
            }
            else
            {
                _modifiedSource.Clear();
                var nonFilter = (from x in _originalSource
                                 where x.Cells[1].Value.ToString() != cbTier.SelectedItem.ToString()
                                 select x).ToList();
                foreach (var item in nonFilter)
                {
                    dataGridView1.Rows.Remove(item);
                }
                if (nudBudget.Value > 0)
                {
                    nudBudget_ValueChanged(null, null);
                }
            }
        }

        private void nudBudget_ValueChanged(object sender, EventArgs e)
        {
            _originalSource.Clear();
            LoadData();
            if (nudBudget.Value != 0)
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    _modifiedSource.Add(item);
                }
                foreach (var item in _modifiedSource)
                {
                    if (Convert.ToDecimal(item.Cells[3].Value) > nudBudget.Value)
                        dataGridView1.Rows.Remove(item);
                    else
                        continue;
                }
                _modifiedSource.Clear();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    _modifiedSource.Add(item);
                }
            }
            else
            {
                _originalSource.Clear();
                LoadData();
                if (cbTier.SelectedItem != null && cbTier.SelectedItem.ToString() != "No Filter")
                {
                    cbTier_SelectedIndexChanged(null, null);
                }
            }

        }

        private void cbOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnline.Checked)
            {

            }
            else
            {

            }
        }

        private void cbFlyers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbBanner_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select your package you wish to book!");
            }
            else
            {
                using (var context = new Session2Entities())
                {
                    var packageID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var checkQuantity = (from x in context.Packages
                                         where x.packageId == packageID
                                         select x).FirstOrDefault();
                    if (checkQuantity.packageQuantity < nudDesiredQuantity.Value)
                    {
                        MessageBox.Show("Not enough package quantity!");
                    }
                    else
                    {
                        context.Bookings.Add(new Booking() { packageIdFK = packageID, quantityBooked = Convert.ToInt32(nudDesiredQuantity.Value), status = "Pending", userIdFK = _user.userId });
                        context.SaveChanges();
                        MessageBox.Show("Package booked successfully!");
                    }
                }
            }
        }
    }


}

