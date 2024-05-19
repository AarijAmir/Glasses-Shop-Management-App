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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int userId_var = Int16.Parse(txtProductId.Text);

            int category_Id_var = Int16.Parse(cmbProductCategory.SelectedValue.ToString());

            string description_var = txtDescription.Text;
            string sale_price_var = txtSalePrice.Text;
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my insert statement in which i am taking input from the user through windows forms  
                string insertCommand = $"INSERT INTO `product`(`product_id`, `category_id`, `description`, `sale_price`) VALUES ({userId_var},{category_Id_var},'{description_var}','{sale_price_var}')";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the insert statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = insertCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lbl_msg.Text = "Record Saved Successfully!";
                }
                else
                {
                    lbl_msg.Text = "Record cannot be Saved!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                int product_Id_var = Int16.Parse(txtProductId.Text);

                int category_Id_var = Int16.Parse(cmbProductCategory.SelectedValue.ToString());

                string description_var = txtDescription.Text;
                string sale_price_var = txtSalePrice.Text;
                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my update statement in which i am taking input from the user through windows forms  
                string updateCommand = $"UPDATE `product` SET `product_id`='{product_Id_var}', `description`='{description_var}', `sale_price`='{sale_price_var}' WHERE `product_id`={product_Id_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the update statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = updateCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lbl_msg.Text = "Record Updated Successfully!";
                }
                else
                {
                    lbl_msg.Text = "Record cannot be Updated!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                int product_Id_var = Int16.Parse(txtProductId.Text);

                int category_Id_var = Int16.Parse(cmbProductCategory.SelectedValue.ToString());

                string description_var = txtDescription.Text;
                string sale_price_var = txtSalePrice.Text;

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my delete statement in which i am taking input from the user through windows forms  
                string deleteCommand = $"DELETE FROM `product` WHERE `product_id`={product_Id_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the delete statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = deleteCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lbl_msg.Text = "Record Deleted Successfully!";
                }
                else
                {
                    lbl_msg.Text = "Record cannot be Deleted!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message;
            }
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
           
            try
            {
                int product_Id_var = Int16.Parse(txtProductId.Text);
                int category_Id_var = Int16.Parse(cmbProductCategory.SelectedValue.ToString());
               
                string description_var = txtDescription.Text;
                string sale_price_var = txtSalePrice.Text;

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my select statement in which i am taking input from the user through windows forms  
                string updateCommand = $"SELECT `product_id`, `category_id`, `description`, `sale_price` FROM `product` WHERE `product_id`={product_Id_var}";

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
                       
                        txtDescription.Text = reader.GetString("description");
                        txtSalePrice.Text = reader.GetString("sale_price");
                    }

                    lbl_msg.Text = "Record Loaded Succesfully!";
                }
                else
                {
                    lbl_msg.Text = "No Record Found!";
                }

                conn.Close();

            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message;
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityprojectDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.universityprojectDataSet.product);
            // TODO: This line of code loads data into the 'productCategory.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productCategory.product);

        }
    }
}
