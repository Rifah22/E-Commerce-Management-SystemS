using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Commerce_Management_System_Project
{
    public partial class Login : Form
    {
        // string cs = ConfigarationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;

            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\6th Semester\Object Oriented Programming 2\Online Class\Admin database.mdf;Integrated Security=True;Connect Timeout=30");
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                string query = "Select * from tblAdmin where Admin_id='" + textBox1.Text + "' and password='" + textBox2.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                /* cmd.Parameters.AddWithValue("@user", textBox1.Text);
                 cmd.Parameters.AddWithValue("@pass", textBox2.Text);*/
                //con.Open();
                //cmd.ExecuteNonQuery();
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                //SqlDataReader dr = cmd.ExecuteReader();
                if (dtable.Rows.Count > 0)
                {
                    // MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    DashB db = new DashB();
                    db.Show();
                    this.Hide();
                    // MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            //this.Hide(); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashB db = new DashB();
            db.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
