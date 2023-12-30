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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\SellerDB\SellerDB\SellerDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "" && txtPass.Text != "")
                {
                    string query = "select * from Seller_Reg where Seller_name='" + txtID.Text + "' and Seller_pass='" + txtPass.Text + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    /* cmd.Parameters.AddWithValue("@sellername", textBox1.Text);
                     cmd.Parameters.AddWithValue("@pass", textBox2.Text);*/
                    //con.Open();
                    //cmd.ExecuteNonQuery();
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    //SqlDataReader dr = cmd.ExecuteReader();
                    if (dtable.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dashboard_ d = new Dashboard_();
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();

                }
                else
                {
                    MessageBox.Show("Please fill the form", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;

            switch (status)
            {
                case true:
                    txtPass.UseSystemPasswordChar = false;
                    break;
                default:
                    txtPass.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
