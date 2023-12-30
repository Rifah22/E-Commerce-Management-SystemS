using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace E_Commerce_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Password_Changed(object sender, EventArgs e)
        {
           /* if (string.IsNullOrEmpty(txtPas.Text) || string.IsNullOrEmpty(txtCpass.Text))
            {
                lblerror.Visible = false;

            }
            else if (txtPas.Text != txtCpass.Text)
            {
                lblerror.Visible = true;
            }
            else
            {
                lblerror.Visible = false;
            }*/

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSN.Text != "" && txtCon.Text != "" && txtCpass.Text != "" && txtPas.Text != "" && txtAdd.Text != "")
                //!string.IsNullOrEmpty(txtSN.Text) && !string.IsNullOrEmpty(txtPas.Text) && !string.IsNullOrEmpty(txtCpass.Text) && !string.IsNullOrEmpty(txtCon.Text) && !string.IsNullOrEmpty(txtAdd.Text)
                {
                    if (txtPas.Text == txtCpass.Text)
                    {
                        // string sid = txtId.Text;
                        string sname = txtSN.Text;
                        string spass = txtPas.Text;
                        string scontact = txtCon.Text;
                        string saddress = txtAdd.Text;

                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\SellerDB\SellerDB\SellerDB.mdf;Integrated Security=True;Connect Timeout=30");
                        con.Open();



                        String query1 = "insert into Seller_Reg(Seller_name,Seller_address,Seller_pass,Seller_phone_no) values ('" + txtSN.Text + "','" + txtAdd.Text + "','" + txtPas.Text + "','" + txtCon.Text + "')";
                        SqlCommand cmd = new SqlCommand(query1, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show(text: "Operation Completed");
                        con.Close();
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match");
                    }
                }
                else
                {

                    MessageBox.Show("Please fill all the box");
                }
            }
            catch ( Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void lblerror_Click(object sender, EventArgs e)
        {

        }
    }
}
