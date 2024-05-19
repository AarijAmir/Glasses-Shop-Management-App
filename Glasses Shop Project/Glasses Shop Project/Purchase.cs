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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int purchase_id_var = Int16.Parse(txtPurchaseId.Text);
            int product_id_var = Int16.Parse(txtPurchaseId.Text);
            int distributor_id_var = Int16.Parse(txtDistributorId.Text);
            int quantity_var = Int16.Parse(txtQuantity.Text);
            int amount_per_unit_var = Int16.Parse(txtAmountPerUnit.Text);
            int total_var = Int16.Parse(txtTotal.Text);
            var dateTime = DateTime.Now;
            String dateTime_var = dateTime.ToShortDateString();

            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my insert statement in which i am taking input from the user through windows forms  
                string insertCommand = $"INSERT INTO `purchase` (`purchase_id`, `product_id`, `distributor_id`, `quantity`, `amount_per_unit`, `total`, `purchase_date`) VALUES ({purchase_id_var}, {product_id_var}, {distributor_id_var}, {quantity_var}, {amount_per_unit_var}, {total_var}, '{dateTime_var}');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                string insertCommandTwo = $"INSERT INTO `stock` (`stock_in`, `date`) VALUES ({quantity_var},'{dateTime_var}');";
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
                if (result > 0 && resultTwo>0)
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
            int purchase_id_var = Int16.Parse(txtPurchaseId.Text);
            int product_id_var = Int16.Parse(txtPurchaseId.Text);
            int distributor_id_var = Int16.Parse(txtDistributorId.Text);
            int quantity_var = Int16.Parse(txtQuantity.Text);
            int amount_per_unit_var = Int16.Parse(txtAmountPerUnit.Text);
            int total_var = Int16.Parse(txtTotal.Text);
            var dateTime = DateTime.Now;
            String dateTime_var = dateTime.ToShortDateString();

            try
            {
                

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my update statement in which i am taking input from the user through windows forms  
                string updateCommand = $"UPDATE `purchase` SET `purchase_id`={purchase_id_var},`product_id`={product_id_var},`distributor_id`={distributor_id_var},`quantity`={quantity_var},`amount_per_unit`={amount_per_unit_var},`total`={total_var},`purchase_date`={dateTime_var} WHERE `purchase_id`={purchase_id_var}";

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
            int purchase_id_var = Int16.Parse(txtPurchaseId.Text);
            int product_id_var = Int16.Parse(txtPurchaseId.Text);
            int distributor_id_var = Int16.Parse(txtDistributorId.Text);
            int quantity_var = Int16.Parse(txtQuantity.Text);
            int amount_per_unit_var = Int16.Parse(txtAmountPerUnit.Text);
            int total_var = Int16.Parse(txtTotal.Text);
            var dateTime = DateTime.Now;
            String dateTime_var = dateTime.ToShortDateString();


            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my delete statement in which i am taking input from the user through windows forms  
                string deleteCommand = $"DELETE FROM `purchase` WHERE `purchase_id`={purchase_id_var}";

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
                int purchase_Id_var = Int16.Parse(txtPurchaseId.Text);
                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my select statement in which i am taking input from the user through windows forms  
                string updateCommand = $"SELECT `purchase_id`, `product_id`, `distributor_id`, `quantity`, `amount_per_unit`, `total` FROM `purchase` WHERE `purchase_id`={purchase_Id_var}";

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
                        txtProductId.Text = reader.GetString("purchase_id");
                        txtDistributorId.Text = reader.GetString("distributor_id");
                        txtQuantity.Text = reader.GetString("quantity");
                        txtAmountPerUnit.Text = reader.GetString("amount_per_unit");
                        txtTotal.Text = reader.GetString("total");
                        
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
