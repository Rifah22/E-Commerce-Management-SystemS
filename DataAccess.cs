using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace UserPanel
{
    class DataAccess
    {
        public static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Desktop\UserPanel\DataBase\LogInfoDB.mdf;Integrated Security=True;Connect Timeout=30";

        // public DataTable

        public static string setData(string query)
        {

            try
            {


                // string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Desktop\UserPanel\DataBase\LogInfoDB.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection con = new SqlConnection(connection);

                con.Open();

                //  string query = "insert into Registration(FullName,UserName,PhoneNum,Email,Gender,Password) values('" + FullName + "', '" + UserName + "','" + PhoneNum + "','" + Email + "','" + Gender + "','" + Pass + "')";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                con.Close();

                return null;
                // MessageBox.Show("Oparetion Completed");


            }

            catch (Exception ex)
            {
                return ex.Message;
                //  MessageBox.Show("Invalid");

            }



        }



        public static DataTable getData(string query, out string error)
        {
            try
            {


                SqlConnection con = new SqlConnection(connection);

                con.Open();


                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                
                DataTable dt = ds.Tables[0];

                // DataGridViewName.DataSource = dt;
                // DataGridViewName.Refresh();


                con.Close();
                error = "";



                return dt;



            }

            catch (Exception ex)
            {
                error = ex.Message;
                
                return null;


            }


        }




    }
}
