using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserPanel
{
    public partial class logIN : Form
    {

        public static string UserName,Pass;
        public static int uId;
        public logIN()
        {
            InitializeComponent();
        }

        //private void ExitBtn_Click(object sender, EventArgs e)
        //{
        //    new ForgetPassForm1().Show();
        //}

        private void ForgetPassBtn_Click(object sender, EventArgs e)
        {
             this.Hide();
            new ForgetPassForm1().Show();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            // Environment.Exit(0);
            //this.Hide();
            // count++;
            // this.Hide();
            // new CartOrBill().Show();

            UserName = UserNameTextBox.Text;
            Pass = PasswordTextBox.Text;


            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("Enter Your User Name.");
                return;
            }

            if (string.IsNullOrEmpty(Pass))
            {
                MessageBox.Show("Enter Your Password.");
                return;
            }



            string query = "select * from Registration where UserName = '"+UserName+"' and [password] = '"+Pass+"';";

            string error;

            DataTable dt = DataAccess.getData(query,out error);


            if (string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid User Name Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string UN = "Welcome " + dt.Rows[0]["UserName"].ToString();
            MessageBox.Show(UN, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uId = Int32.Parse(dt.Rows[0]["UserId"].ToString());

            this.Hide();

            new ViewCartForm(uId).Show();




        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void GoToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductsList().Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }
    }
}
