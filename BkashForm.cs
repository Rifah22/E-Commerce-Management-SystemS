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
    public partial class biKashForm : Form
    {
        public biKashForm()
        {
            InitializeComponent();
        }

        private void bKashProceedBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BkashAccTxtBox.Text))
            {
                MessageBox.Show("Enter Your Account Number.");
                return;
            }

            if (string.IsNullOrEmpty(BikashPinTxtBox.Text))
            {
                MessageBox.Show("Enter Your Pin Number.");
                return;
            }


            Environment.Exit(0);
        }

        private void bKashCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
