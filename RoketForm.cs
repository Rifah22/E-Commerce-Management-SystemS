using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserPanel
{
    public partial class RoketForm : Form
    {
        public RoketForm()
        {
            InitializeComponent();
        }

        private void RoketCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RoketProceedBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RoketAccNumTxtBox.Text))
            {
                MessageBox.Show("Enter Your Account Number.");
                return;
            }

            if (string.IsNullOrEmpty(RoketPinTxtBox.Text))
            {
                MessageBox.Show("Enter Your Pin Number.");
                return;
            }

            Environment.Exit(0);
        }
    }
}
