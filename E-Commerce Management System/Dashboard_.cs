using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce_Management_System
{
    public partial class Dashboard_ : Form
    {
        public Dashboard_()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            All_View av = new All_View();
            this.Hide();
            av.Show();
        }

        private void Dashboard__Load(object sender, EventArgs e)
        {

        }

        private void BPL_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            this.Hide();
            p.Show();
        }

        private void Log_Out_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
