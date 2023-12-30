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
namespace E_Commerce_Management_System_Project
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashB db = new DashB();
            db.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\6th Semester\Object Oriented Programming 2\Online Class\Admin database.mdf;Integrated Security=True;Connect Timeout=30");
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select Customer_id as 'Customer ID',Customer_name as 'Customer Name',Customer_address as 'Customer Address',Customer_phone_no as 'Customer Phone_No',Customer_pass as 'Customer Pass' from Customer_Registration";
            SqlDataAdapter sqldt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqldt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
