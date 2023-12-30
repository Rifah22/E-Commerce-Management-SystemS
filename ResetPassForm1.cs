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
    public partial class ForgetPassForm1 : Form
    {
        public static string UserName,PhoneNum,Pass;
        public ForgetPassForm1()
        {
            InitializeComponent();
        }

        

        private void PrevForgetPassBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logIN().Show();
        }

        private void NextForgetPassBtn_Click(object sender, EventArgs e)
        {
            //hello

            if (string.IsNullOrEmpty(ResetUserNameTxtBox.Text))
            {
                MessageBox.Show("Enter Your User Name.");
                return;
            }



            UserName = ResetUserNameTxtBox.Text;
            


            string query = "select * from Registration where UserName = '" + UserName + "';";

            string error;

            DataTable dt = DataAccess.getData(query, out error);


            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            this.ResetPhnNumPanel.Show();
        }

        private void ForgetPassForm1_Load(object sender, EventArgs e)
        {
           
            this.ResetPhnNumPanel.Hide();
            this.NewPassPanel.Hide();

        }

        private void ExitForgetPassBtn_Click_1(object sender, EventArgs e)
        {

            Environment.Exit(0);

        }

        private void NewPassBtn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(NewPassTextBox.Text))
            {
                MessageBox.Show("Enter Your New PassWord.");
                return;
            }

            Pass = NewPassTextBox.Text;



            string query = "update Registration set [Password] = '" + Pass + "' where PhoneNum = '" + PhoneNum + "' and UserName = '" + UserName + "' ";

            string error;
            error = DataAccess.setData(query);

            if (string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Password Update Successfully.");
            }
            else
            {
                MessageBox.Show(error);
            }

            this.Hide();
            new logIN().Show();

            // string UN = "Welcome " + dt.Rows[0]["UserName"].ToString();
            // MessageBox.Show(UN, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);








        }

        private void ResetPhnNumNxtBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(ResetPhnNumTxtBox.Text))
            {
                MessageBox.Show("Enter Your Registered Phone Number.");
                return;
            }


            PhoneNum = ResetPhnNumTxtBox.Text;



            string query = "select * from Registration where PhoneNum = '" + PhoneNum + "';";

            string error;

            DataTable dt = DataAccess.getData(query, out error);


            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // string UN = "Welcome " + dt.Rows[0]["UserName"].ToString();
            // MessageBox.Show(UN, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



            this.NewPassPanel.Show();
        }
    }
}
