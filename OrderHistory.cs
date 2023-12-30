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
    public partial class OrderHistory : MetroFramework.Forms.MetroForm
    {
        public static int uId;
        public static int oId;
        public OrderHistory(int x,int y)
        {
            uId = x;
            oId = y;
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {

            int historyOrderId = (oId - 1);

            if (historyOrderId == 0)
            {
                MessageBox.Show("No Order Yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string query2 = "select * from [Order] where UserId ='" + uId + "' and Order_Id between 1 and'" + historyOrderId + "' ;";

            
            string error2;

            DataTable dt1 = DataAccess.getData(query2, out error2);


            if (string.IsNullOrEmpty(error2) == false)
            {
                MessageBox.Show(error2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("No Order History Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
