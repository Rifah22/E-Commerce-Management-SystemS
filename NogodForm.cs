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
    public partial class NogodForm : Form
    {
        public NogodForm()
        {
            InitializeComponent();
        }

        private void NagodProceedBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NagodAccNumTxtBox.Text))
            {
                MessageBox.Show("Enter Your Account Number.");
                return;
            }

            if (string.IsNullOrEmpty(NagodPinTxtBox.Text))
            {
                MessageBox.Show("Enter Your Pin Number.");
                return;
            }

            Environment.Exit(0);
        }

        private void NagodCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
