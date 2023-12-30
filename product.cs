using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace E_Commerce_Management_System_Project
{
    public partial class product : MetroFramework.Forms.MetroForm
    {
        public product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\6th Semester\Object Oriented Programming 2\Online Class\Admin database.mdf;Integrated Security=True;Connect Timeout=30");
        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DashB dash = new DashB();
            this.Hide();
            dash.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select Product_id as 'Product ID',Product_name as 'Name',Product_type as 'Product Type',Product_price as 'Product price' from Product";
            SqlDataAdapter sqldt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqldt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPN.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPP.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "Delete Documents", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                String query = "DELETE FROM Product WHERE Product_id='" + txtID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted!");
            }
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {

        }
    }
}
