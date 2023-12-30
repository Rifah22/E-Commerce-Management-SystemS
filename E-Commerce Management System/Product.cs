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
    public partial class Product : MetroFramework.Forms.MetroForm
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Add_Opening(object sender, CancelEventArgs e)
        {

        }
        


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\SellerDB\SellerDB\SellerDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        

        private void bAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (t_P_Name.Text != "" && t_P_Type.Text != "" && t_P_Price.Text != "")
                {

                    string pname = t_P_Name.Text;
                    string ptype = t_P_Type.Text;
                    decimal price = decimal.Parse(t_P_Price.Text);
                    //string pprice = price.ToString();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Product_List(Seller_id,Product_Name,Product_Type,Product_Price) values ('2','" + pname + "','" + ptype + "','" + price + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(text: "Saved");

                    SqlDataAdapter sqlDt = new SqlDataAdapter("SELECT * from Product_List", con);
                    DataTable dt = new DataTable();
                    sqlDt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please fill all the box");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }


        private void bDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (t_P_Id.Text != "")
                {

                    if (MessageBox.Show("Are you sure to delete?", "Delete Documents", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        con.Open();
                        String query = "DELETE FROM Product_List where Product_Id='" + t_P_Id.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Successfully Deleted!");
                    }
                }
            }
            catch( Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void bRefresh_Click_1(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sqlDt = new SqlDataAdapter("SELECT * from Product_List", con);
            DataTable dt = new DataTable();
            sqlDt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            t_P_Id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            t_P_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            t_P_Type.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            t_P_Price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Dashboard_ db = new Dashboard_();
            db.Show();
            this.Hide();
            
        }

        private void mV_Click(object sender, EventArgs e)
        {
            All_View av = new All_View();
            av.Show();
            this.Hide();
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

    

