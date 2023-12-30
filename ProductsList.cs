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
    public partial class ProductsList : MetroFramework.Forms.MetroForm
    {
        public static string image,id,name,price;
        public static int loadProductList = 0;
        public static int permit;
        public static int uId;

        private void ProListExitBtn_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }

        private void ViewCartBtn_Click(object sender, EventArgs e)
        {


            ////////////////////////////////////////////////////////////////////////////////
           // MessageBox.Show(permit.ToString());

            if (permit == 0)
            {

                this.Hide();
                new logIN().Show();


            }



            // if (permit == 1)
            //if (permit > 0)
            if (permit == 1)
            {

                //MessageBox.Show(permit.ToString());
                this.Hide();
                new ViewCartForm(uId).Show();


            }


            //loadProductList++;
            ///////////////////////////////////////////////////////////////////////////

        }

        public ProductsList()
        {
            InitializeComponent();
        }


        public static void getPermit(int x,int y)
        {
            permit = x;
            uId = y;
           // MessageBox.Show(x.ToString());
            new ProductsList().Show();
        }






        private void ProductsList_Load(object sender, EventArgs e)
        {
            //AddCartPanel.Hide();

            loadProductList = 1;

            string query = "select Product_Id,Product_Name,Product_Type,Product_Price from Product;";

            // select Product_Id, Product_Name, Product_Type, Product_Price from Product;
            //select * from Product;

            string error;

            DataTable dt = DataAccess.getData(query, out error);


            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Product Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProductListGrid.AutoGenerateColumns = false;
            ProductListGrid.DataSource = dt;
            ProductListGrid.Refresh();
            ProductListGrid.ClearSelection();
        }

        private void ProductListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                id = ProductListGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                name = ProductListGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                price = ProductListGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

                //AddCartPanel.Show();



                string query = "select * from Product where Product_Id = '" + id + "';";

                string error;

                DataTable dt = DataAccess.getData(query, out error);


                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Image Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tempImg =dt.Rows[0]["Product_Image"].ToString();
                //MessageBox.Show(tempImg);

                // pictureBox1 ob1 = new pictureBox1();

                //location of picture = C:\Users\HP\OneDrive\Desktop\UserPanel\Pictures
                //add = \
                //picture name with extension = 71KKyNg4PWL._AC_UL450_SR450,320_.jpg

                // pictureBox1.Image = new Bitmap(@"C:\Users\HP\\OneDrive\Desktop\C#_Demo\71KKyNg4PWL._AC_UL450_SR450,320_.jpg");
                //  pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


                string LocImg = @"C:\Users\HP\OneDrive\Desktop\UserPanel\Pictures\";
                image = LocImg + tempImg;
                //MessageBox.Show(image);
                new AddCart(image,id,name,price).Show();

            }
        }
    }
}
