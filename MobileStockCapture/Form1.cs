using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MobileStockCapture
{
    public partial class Form1 : Form
    {
        // Simulated local database table storing: Key (MobileCode) -> Value (Make and Quantity string)
        private Dictionary<string, string> tblMobilePhones = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        //1.2.1 Add Button Logic
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string make = txtMake.Text.Trim();
            string qtyInput = txtQuantity.Text.Trim();

            // Non-Functional Testing / Guard Rails: Input validation
            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(make) || string.IsNullOrEmpty(qtyInput))
            {
                lblOutput.Text = "Validation Error: All fields must be filled.";
                return;
            }

            if (!int.TryParse(qtyInput, out int quantity) || quantity < 0)
            {
                lblOutput.Text = "Validation Error: Quantity must be a valid positive number.";
                return;
            }

            // Functional Testing Logic: Check if record exists, update or insert
            string recordDetails = $"Make: {make}, Qty: {quantity}";
            if (tblMobilePhones.ContainsKey(code))
            {
                tblMobilePhones[code] = recordDetails; // Updates existing record
            }
            else
            {
                tblMobilePhones.Add(code, recordDetails); // Inserts new record
            }

            // Assignment Specified Output Requirement
            lblOutput.Text = "Record Added";
            ClearInputFields();
        }

        // 1.2.2 Delete button logic
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();

            if (string.IsNullOrEmpty(code))
            {
                lblOutput.Text = "Validation Error: Please enter a MobileCode to delete.";
                return;
            }

            // Functional Testing Logic: Check if the record is present in tblMobilePhones
            if (tblMobilePhones.ContainsKey(code))
            {
                tblMobilePhones.Remove(code);
                // Assignment Specified Output Requirement (Note: Typo from paper handled exactly)
                lblOutput.Text = "Record Found";
            }
            else
            {
                // Assignment Specified Output Requirement
                lblOutput.Text = "Record NOT Found";
            }
            ClearInputFields();
        }

        // 1.2.3 Find button logic
        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        // Helper function to clear form inputs cleanly
        private void ClearInputFields()
        {
            txtCode.Clear();
            txtMake.Clear();
            txtQuantity.Clear();
            txtCode.Focus();
        }
    }
}