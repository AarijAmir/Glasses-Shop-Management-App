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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = "Aarij Amir";
            int customerId_var = Int16.Parse(txtCustomerId.Text);
            String customerName_var = txtCustomerName.Text;
            String phoneNo_var = txtPhoneNumber.Text;
            String address_var = txtAddress.Text;
          
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my insert statement in which i am taking input from the user through windows forms  
                string insertCommand = $"INSERT INTO `customer`(`customer_id`, `customer_name`, `address`, `phone`) VALUES ({customerId_var},'{customerName_var}','{address_var}','{phoneNo_var}')";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the insert statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = insertCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
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
            int customerId_var = Int16.Parse(txtCustomerId.Text);
            String customerName_var = txtCustomerName.Text;
            String phoneNo_var = txtPhoneNumber.Text;
            String address_var = txtAddress.Text;
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my update statement in which i am taking input from the user through windows forms  
                string updateCommand = $"UPDATE `customer` SET `customer_id`='{customerId_var}',`customer_name`='{customerName_var}' ,`address`='{address_var}' ,`phone`='{phoneNo_var}' WHERE `customer_id`={customerId_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the update statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = updateCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblMessage.Text = "Customer Updated Successfully!";
                }
                else
                {
                    lblMessage.Text = "Customer cannot be Updated!";
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
            int customerId_var = Int16.Parse(txtCustomerId.Text);
            
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = customer; uid = root; ";

                //This is my delete statement in which i am taking input from the user through windows forms  
                string deleteCommand = $"DELETE FROM `customer` WHERE `customer_id`={customerId_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the delete statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = deleteCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblMessage.Text = "Customer Deleted Successfully!";
                }
                else
                {
                    lblMessage.Text = "Customer cannot be Deleted!";
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
            int customerId_var = Int16.Parse(txtCustomerId.Text);
           
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my select statement in which i am taking input from the user through windows forms  
                string updateCommand = $"SELECT `customer_id`, `customer_name`, `address`, `phone` FROM `customer` WHERE `customer_id`={customerId_var}";

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
                        txtCustomerId.Text = reader.GetString("customer_id");
                        txtCustomerName.Text = reader.GetString("customer_name");
                        txtAddress.Text = reader.GetString("address");
                        txtPhoneNumber.Text = reader.GetString("address");
                        
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
