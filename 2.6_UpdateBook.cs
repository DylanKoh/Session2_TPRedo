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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking to delete!");
            }
            else
            {
                var response = MessageBox.Show("Are you sure you want to delete this booking?", "Delete", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    var getBookingID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    using (var context = new Session2Entities())
                    {
                        var getBookingDelete = (from x in context.Bookings
                                                where x.bookingId == getBookingID
                                                select x).FirstOrDefault();
                        var updateQuantity = (from x in context.Packages
                                              where x.packageId == getBookingDelete.packageIdFK
                                              select x).FirstOrDefault();
                        updateQuantity.packageQuantity += getBookingDelete.quantityBooked;
                        context.SaveChanges();
                        context.Bookings.Remove(getBookingDelete);
                        context.SaveChanges();
                        MessageBox.Show("Booking deleted successfully!");
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    }
                }
            }
        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
           using (var context = new Session2Entities())
            {
                var getBookingsUser = (from x in context.Bookings
                                       where x.userIdFK == _user.userId
                                       where x.status != "Pending"
                                       select x);
                foreach (var item in getBookingsUser)
                {
                    var newRow = new List<string>() { item.bookingId.ToString(), item.Package.packageTier, item.Package.packageName, item.Package.packageValue.ToString(), item.quantityBooked.ToString(), (item.Package.packageValue * item.quantityBooked).ToString() };
                    dataGridView1.Rows.Add(newRow.ToArray());
                }
                int total = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    total += Convert.ToInt32(item.Cells[5].Value);
                }
                lblTotalValue.Text = total.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking to update!");
            }
            else
            {
                using (var context = new Session2Entities())
                {
                    var getBookingID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var getBookingDetails = (from x in context.Bookings
                                             where x.bookingId == getBookingID
                                             select x).FirstOrDefault();
                    if (getBookingDetails.Package.packageQuantity + getBookingDetails.quantityBooked < nudNewQuantity.Value)
                    {
                        MessageBox.Show("Package will not have enough stock for new updated quantity!");
                    }
                    else
                    {
                        var getPackage = (from x in context.Packages
                                          where x.packageId == getBookingDetails.packageIdFK
                                          select x).FirstOrDefault();
                        getPackage.packageQuantity += getBookingDetails.quantityBooked;
                        context.SaveChanges();
                        getBookingDetails.quantityBooked = Convert.ToInt32(nudNewQuantity.Value);
                        getBookingDetails.status = "Pending";
                        context.SaveChanges();
                        MessageBox.Show("Update booking completed!");
                    }

                }
            }
        }
    }
}
