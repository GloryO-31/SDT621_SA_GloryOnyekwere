using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Capture user input and remove any accidental extra spaces
            string userName = txtName.Text.Trim();

            // Verification check: Make sure they actually typed something
            if (!string.IsNullOrEmpty(userName))
            {
                // This creates that exact popup window from your image!
                MessageBox.Show($"Hello {userName}!", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
