using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Management_System
{
    static class DataAccess
    {
        public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\SellerDB\SellerDB\SellerDB.mdf;Integrated Security=True;Connect Timeout=30";

        public static DataTable GetData(string query,out string error)
        {
            try
            {

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();


                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                con.Close();
                error = " ";
                return dt;
                
            }

            catch (Exception exception)

            {
                error = exception.Message;
                return null;
                
            }

        }
        public static void ExecuteData(string query, out string error)
        {
            try
            {

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();


                con.Close();
                error = " ";

            }

            catch (Exception exception)

            {
                error = exception.Message;

            }

        }

    }

}