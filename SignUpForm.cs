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
    public partial class Registration : Form
    {
        
        
        public Registration()
        {
            InitializeComponent();
        }

        static string FullName = null, UserName = null, PhoneNum=null, Email=null, Gender=null, ConfirmPass=null, Pass=null;

        private void AlreadyHadAccBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            new logIN().Show();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            new logIN().Show();
        }

        private void RegistrationExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PrevRegistrationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logIN().Show();
        }

        private void RagistrationPicLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            

                FullName = FullNameTxtBox.Text;
                UserName = UserNameTxtBox.Text;
                PhoneNum = PhoneNumTxtBox.Text;
                Email = EmailAddTxtBox.Text;
                Pass = PasswordTxtBox.Text;
                ConfirmPass = ConfirmPassTxtBox.Text;


            if (FullName == null || UserName == null || PhoneNum == null || Email == null || Pass == null || ConfirmPass == null)
            {

                MessageBox.Show("Please Fill UP All The Require Information.");
                return;

            }

            if (string.IsNullOrEmpty(FullName))
            {
                MessageBox.Show("Please Enter Your Full Name.");
                return;
            }


            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("Please Enter Your User Name.");
                return;
            }


            if (string.IsNullOrEmpty(PhoneNum))
            {
                MessageBox.Show("Please Enter Your Phone Number.");
                return;
            }


            if (string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Please Enter Your Email.");
                return;
            }




            if (MaleRadioBtn.Checked)
            {

                Gender = "Male";
            }
            else if (FemaleRadioBtn.Checked)
            {
                Gender = "Female";
            }
            else
            {

                MessageBox.Show("Select Gender.");

                return;
            }



            if (string.IsNullOrEmpty(Pass))
            {
                MessageBox.Show("Please Enter Your Password.");
                return;
            }


            if (string.IsNullOrEmpty(ConfirmPass))
            {
                MessageBox.Show("Please Enter Your Confirm Password.");
                return;
            }



            if (Pass != ConfirmPass)
            {
                MessageBox.Show("Incorrect Confirm Password");
                return;

            }
            




            string query = "insert into Registration(FullName,UserName,PhoneNum,Email,Gender,Password) values('" + FullName + "', '" + UserName + "','" + PhoneNum + "','" + Email + "','" + Gender + "','" + Pass + "')";

            string error;
            error = DataAccess.setData(query);

            if (string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Account Create Successfully.");
            }
            else
            {
                MessageBox.Show(error);
            }

            return;



        }
    }
}
//update Registration set UserName='Labib', PhoneNum='01305641301',Email='Labib@gmail.com',[Password]='123' where UserId=1;