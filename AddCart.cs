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
    
    public partial class AddCart : MetroFramework.Forms.MetroForm
    {
        public static string orderedItem = "";
        public static string img,name,price;
        public static int id;
        public static int count,totalQuantity;
        public static double totalPrice;
        public static double tCost;
        public static int restartTotalPrice=0;
        public AddCart(string x,string y,string z,string v)
        {
            img = x;
            id = Int32.Parse(y);
            name = z;
            price = v;
            InitializeComponent();
        }

        private void AddCartBtn_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(orderedItem);
            //orderedItem = "Hello From AddCart";
            //////////
            if (string.IsNullOrEmpty(QuantityTxtBox.Text))
            {
                MessageBox.Show("Select Quantity.");

                return;
            }

            int minQuan = Int32.Parse(QuantityTxtBox.Text);

            if (minQuan==0)
            {
                MessageBox.Show("Select Quantity.");

                return;
            }


            orderedItem = orderedItem + (id).ToString() + ", ";
            tCost = tCost + totalPrice;

            //totalQuantity = Int32.Parse(QuantityTxtBox.Text);

            //if (totalQuantity == 0)
            //{
            //    MessageBox.Show("Select Quantity.");

            //    return;
            //}

            string query = "insert into Cart(Product_Id,Product_Name,Total_Cost,Quantity) values('" + id + "','" + name + "', '" + totalPrice + "','" + totalQuantity + "')";

            string error;
            error = DataAccess.setData(query);

            if (string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Item Added Successfully.");
            }
            else
            {
                MessageBox.Show(error);
            }

            this.Hide();

            return;
            

        }

        //public static string returnProuctId()
        //{
        //    return orderedItem;
        //}


        private void AddCart_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(img);
            // Img = ProductsList.Image;
            // MessageBox.Show(ProductsList.Image);
            ProductPictureBox.Image = new Bitmap(img);
            ProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductDesLabel.Text = name;

           // orderedItem = "Hello From AddCart Load";

            ProductPriceTxtBox.Text = price;
            count = 0;
            if(ProductsList.loadProductList == 1 && restartTotalPrice==0)
            {
                tCost = 0;
                restartTotalPrice++;

            }
           // tCost = 0;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            count = (count + 1);
            double p = Double.Parse(price);
            totalPrice = count * p;
            TotalPriceTxtBox.Text = (totalPrice).ToString();
            QuantityTxtBox.Text = Convert.ToString(count);
            
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (count >= 1)
            {
                count = (count - 1);
                double p = Double.Parse(price);
                totalPrice = count * p;
                TotalPriceTxtBox.Text = (totalPrice).ToString();
                QuantityTxtBox.Text = Convert.ToString(count);
                
            }
        }
    }
}
