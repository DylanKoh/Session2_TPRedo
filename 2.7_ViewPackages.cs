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
    public partial class ViewPackages : Form
    {
        public ViewPackages()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new SponsorManagerMain()).ShowDialog();
            this.Close();
        }

        private void ViewPackages_Load(object sender, EventArgs e)
        {
            using (var context = new Session2Entities())
            {
                dataGridView1.Rows.Clear();
                var getPackages = (from x in context.Packages
                                   select x);
                if (rbTier.Checked)
                {
                    var sortedTiers = getPackages.OrderByDescending(x => x.packageTier == "Gold").ThenByDescending(x => x.packageTier == "Silver").ThenByDescending(x => x.packageTier == "Bronze");

                    foreach (var item in sortedTiers)
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
                else if (rbName.Checked)
                {
                    var sortedName = getPackages.OrderBy(x => x.packageName);

                    foreach (var item in sortedName)
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
                else if (rbvalue.Checked)
                {
                    var sortedValue = getPackages.OrderBy(x => x.packageValue);

                    foreach (var item in sortedValue)
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
                else if (rbQuantity.Checked)
                {
                    var sortedQuantity = getPackages.OrderByDescending(x => x.packageQuantity);

                    foreach (var item in sortedQuantity)
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
                else
                {
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
                

            }
        }

        private void rbTier_CheckedChanged(object sender, EventArgs e)
        {
            ViewPackages_Load(null, null);
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            ViewPackages_Load(null, null);
        }

        private void rbvalue_CheckedChanged(object sender, EventArgs e)
        {
            ViewPackages_Load(null, null);
        }

        private void rbQuantity_CheckedChanged(object sender, EventArgs e)
        {
            ViewPackages_Load(null, null);
        }
    }
}
