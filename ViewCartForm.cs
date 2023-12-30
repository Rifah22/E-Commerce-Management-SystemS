using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserPanel
{
    public partial class ViewCartForm : MetroFramework.Forms.MetroForm
    {
        public static string orderIdList;
        public static int uId;
        public static double tCost;
        public static int oId;
        public static int permitNo; ///

        public ViewCartForm(int i)
        {
            InitializeComponent();

            orderIdList = AddCart.orderedItem;
            uId = i;
            tCost = AddCart.tCost;
        }

        private void ViewCartForm_Load(object sender, EventArgs e)
        {
            //AddCartPanel.Hide();


            // MessageBox.Show(x);

            /*
            string query = "select sum(Total_Cost) from Cart;";
 
            string error;

            DataTable dt = DataAccess.getData(query, out error);


            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Total Cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tCost = Double.Parse(dt.Rows[0][0].ToString());

            //MessageBox.Show(orderIdList);

            //MessageBox.Show(tCost.ToString());


            //MessageBox.Show(uId.ToString());

    */


            if (tCost == 0)
            {
                PamentOptLabel.Hide();

                BkashOptBtn.Hide();
                NogodOptBtn.Hide();
                RoketOptBtn.Hide();

                MessageBox.Show("You Did Not Choose Any Item.");
                return;
            }












            /*



            string query1 = "insert into [Order](Product_Id,UserId,Total_Cost) values('" + orderIdList + "', '" + uId + "','" + tCost + "')";

            string error1;
            error1 = DataAccess.setData(query1);

            if (string.IsNullOrEmpty(error1))
            {
                MessageBox.Show("Show Data InTo Card.");

                BackToProductListBtn.Hide();
            }
            else
            {
                MessageBox.Show(error1);
            }

           // "insert into [Order](Product_Id,UserId,Total_Cost) values('" + orderIdList + "', '" + uId + "','" + tCost + "') SELECT SCOPE_IDENTITY();";
    */

            string query5 = "insert into [Order](Product_Id,UserId,Total_Cost) values('" + orderIdList + "', '" + uId + "','" + tCost + "') SELECT SCOPE_IDENTITY();";

            string error5;

            DataTable dt5 = DataAccess.getData(query5, out error5);


            if (string.IsNullOrEmpty(error5) == false)
            {
                MessageBox.Show(error5, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dt5.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Last Order Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            oId =Int32.Parse(dt5.Rows[0][0].ToString());
           // MessageBox.Show(oId.ToString());
            
           




            /////////////////////////////////////////////////////////////////////////////////SELECT SCOPE_IDENTITY();


            string query2 = "select * from [Order] where UserId ='" + uId + "' and Order_Id ='" + oId + "';";


           // string query2 = "select * from [Order] where UserId ='" + uId + "';";


            // select Product_Id, Product_Name, Product_Type, Product_Price from Product;
            //select * from Product;

            string error2;

            DataTable dt1 = DataAccess.getData(query2, out error2);


            if (string.IsNullOrEmpty(error2) == false)
            {
                MessageBox.Show(error2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("No Product Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OrderGridView.AutoGenerateColumns = false;
            OrderGridView.DataSource = dt1;
            OrderGridView.Refresh();
            OrderGridView.ClearSelection();

    
        }

        private void ProListExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BkashOptBtn_Click(object sender, EventArgs e)
        {
            new biKashForm().Show();
        }

        private void NogodOptBtn_Click(object sender, EventArgs e)
        {
            new NogodForm().Show();
        }

        private void RoketOptBtn_Click(object sender, EventArgs e)
        {
            new RoketForm().Show();
        }

      
        private void BackToProductListBtn_Click(object sender, EventArgs e)
        {
            










            this.Hide();

            ProductsList.getPermit(1, uId);

            // ProductsList.getPermit(1, uId);

           // new ProductsList().Show();
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrderHistory(uId,oId).Show();
        }
    }
}
