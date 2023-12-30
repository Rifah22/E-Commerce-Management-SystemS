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
    public partial class All_View : Form
    {
        public All_View()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\SellerDB\SellerDB\SellerDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sqlDt = new SqlDataAdapter("SELECT * from Customer_List", con);
            DataTable dt = new DataTable();
            sqlDt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sqlDt = new SqlDataAdapter("SELECT * from Order_List", con);
            DataTable dt = new DataTable();
            sqlDt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void bBackV_Click(object sender, EventArgs e)
        {
            Dashboard_ d = new Dashboard_();
            this.Hide();
            d.Show(); 
        }
    }
}
