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
    public partial class saller : Form
    {
        public saller()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\6th Semester\Object Oriented Programming 2\Online Class\Admin database.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            DashB db = new DashB();
            db.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAdd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCn.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtApprove.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void saller_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select seller_id as 'Seller ID',Seller_name as 'Name',Seller_address as 'Address',seller_phone_no as'Seller contact number',approve_status as'Approve Status'  from Seller_Registration";
            SqlDataAdapter sqldt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqldt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(txtID.Text!=null)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Documents", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    String query = "DELETE FROM Seller_Registration WHERE Seller_id='" + txtID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select seller_id as 'Seller ID',Seller_name as 'Name',Seller_address as 'Address',seller_phone_no as'Seller contact number',Approve_status as 'Approve Status' from Seller_Registration where Approve_status like '%No%'";
            SqlDataAdapter sqldt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqldt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Update seller_registration set Approve_status='Yes'  WHERE Seller_id='" + txtID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Seller Approved!");
        }
    }
}

