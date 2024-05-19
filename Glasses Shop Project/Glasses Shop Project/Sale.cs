using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glasses_Shop_Project
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int saleId_var = Int16.Parse(txtSaleId.Text);
            int productId_var = Int16.Parse(txtProductId.Text);
            int customerId_var = Int16.Parse(txtCustomerId.Text);
            int quantity_var = Int16.Parse(txtQuantity.Text);
            int amount_var = Int16.Parse(txtAmount.Text);
            int total_var = Int16.Parse(txtTotal.Text);
            int discount_var = Int16.Parse(txtDiscount.Text);
            int net_var = Int16.Parse(txtNet.Text);
            int paid_var = Int16.Parse(txtPaid.Text);
            int balance_var = Int16.Parse(txtBalance.Text);
            var dateTime = DateTime.Now;
            String dateTime_var = dateTime.ToShortDateString();
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my insert statement in which i am taking input from the user through windows forms  
                string insertCommand = $"INSERT INTO `sale` (`sale_id`, `product_id`, `customer_id`, `quantity`, `amount`, `total`, `discount`, `net`, `paid`, `balance`, `sale_date`) VALUES ({saleId_var}, {productId_var}, {customerId_var}, {quantity_var}, {amount_var}, {total_var}, {discount_var}, {net_var}, {paid_var}, {balance_var}, '{dateTime_var}');";

                string insertCommandTwo = $"INSERT INTO `stock` (`stock_out`, `date`) VALUES ({quantity_var},'{dateTime_var}');";

                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlConnection connTwo = new MySqlConnection(connectionString);

                //This is command class which will handle the insert statement.
                MySqlCommand cmd = conn.CreateCommand();
                MySqlCommand cmdTwo = connTwo.CreateCommand();
                cmd.CommandText = insertCommand;
                cmdTwo.CommandText = insertCommandTwo;

                conn.Open();
                connTwo.Open();

                int result = cmd.ExecuteNonQuery();
                int resultTwo = cmdTwo.ExecuteNonQuery();
                if (result > 0 && resultTwo > 0)
                {
                    lblMessage.Text = "Record Saved Successfully!";
                }
                else
                {
                    lblMessage.Text = "Record cannot be Saved!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             int saleId_var = Int16.Parse(txtSaleId.Text);
                int productId_var = Int16.Parse(txtProductId.Text);
                int customerId_var = Int16.Parse(txtCustomerId.Text);
                int quantity_var = Int16.Parse(txtQuantity.Text);
                int amount_var = Int16.Parse(txtAmount.Text);
                int total_var = Int16.Parse(txtTotal.Text);
                int discount_var = Int16.Parse(txtDiscount.Text);
                int net_var = Int16.Parse(txtNet.Text);
                int paid_var = Int16.Parse(txtPaid.Text);
                int balance_var = Int16.Parse(txtBalance.Text);
                var dateTime = DateTime.Now;
                String dateTime_var = dateTime.ToShortDateString();
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my update statement in which i am taking input from the user through windows forms  
                string updateCommand = $"UPDATE `sale` SET `sale_id`={saleId_var},`product_id`={productId_var},`customer_id`={customerId_var},`quantity`={quantity_var}, `amount`={amount_var},`total`={total_var},`discount`={discount_var},`net`={net_var},`paid`={paid_var},`balance`={balance_var},`sale_date`='{dateTime_var}' WHERE `sale_id`={saleId_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the update statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = updateCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblMessage.Text = "Record Updated Successfully!";
                }
                else
                {
                    lblMessage.Text = "Record cannot be Updated!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int saleId_var = Int16.Parse(txtSaleId.Text);
            int productId_var = Int16.Parse(txtProductId.Text);
            int customerId_var = Int16.Parse(txtCustomerId.Text);
            int quantity_var = Int16.Parse(txtQuantity.Text);
            int amount_var = Int16.Parse(txtAmount.Text);
            int total_var = Int16.Parse(txtTotal.Text);
            int discount_var = Int16.Parse(txtDiscount.Text);
            int net_var = Int16.Parse(txtNet.Text);
            int paid_var = Int16.Parse(txtPaid.Text);
            int balance_var = Int16.Parse(txtBalance.Text);
            var dateTime = DateTime.Now;
            String dateTime_var = dateTime.ToShortDateString();

            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my delete statement in which i am taking input from the user through windows forms  
                string deleteCommand = $"DELETE FROM `user` WHERE `sale_id`={saleId_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the delete statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = deleteCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblMessage.Text = "Record Deleted Successfully!";
                }
                else
                {
                    lblMessage.Text = "Record cannot be Deleted!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }

        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                int saleId_var = Int16.Parse(txtSaleId.Text);

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my select statement in which i am taking input from the user through windows forms  
                string updateCommand = $"SELECT `sale_id`, `product_id`, `customer_id`, `quantity`, `amount`, `total`, `discount`, `net`, `paid`, `balance` FROM `sale` WHERE `sale_id`={saleId_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the select statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = updateCommand;

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtProductId.Text = reader.GetString("product_id");
                        txtCustomerId.Text = reader.GetString("customer_id");
                        txtQuantity.Text = reader.GetString("quantity");
                        txtAmount.Text = reader.GetString("amount");
                        txtTotal.Text = reader.GetString("total");
                        txtDiscount.Text = reader.GetString("discount");
                        txtNet.Text = reader.GetString("net");
                        txtPaid.Text = reader.GetString("paid");
                        txtBalance.Text = reader.GetString("balance");
                        
                    }

                    lblMessage.Text = "Record Loaded Succesfully!";
                }
                else
                {
                    lblMessage.Text = "No Record Found!";
                }

                conn.Close();

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }
    }
}
