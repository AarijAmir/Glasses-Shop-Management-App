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
    public partial class Distributor : Form
    {
        public Distributor()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int distributorId_var = Int16.Parse(txt_distributor_id.Text);
            string distributor_phone_no_var = txt_distributor_phone_no.Text;
            string distributor_address_var = txt_address.Text;
            string distributor_description_var = txt_description.Text;
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my insert statement in which i am taking input from the user through windows forms  
                string insertCommand = $"INSERT INTO `distributor`(`distributor_id`, `distributor_description`, `address`, `phone` ) VALUES ({distributorId_var},'{distributor_description_var}','{distributor_address_var}','{distributor_phone_no_var}')";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the insert statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = insertCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lbl_message.Text = "Record Saved Successfully!";
                }
                else
                {
                    lbl_message.Text = "Record cannot be Saved!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lbl_message.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int distributorId_var = Int16.Parse(txt_distributor_id.Text);
            string phone_no_var = txt_distributor_phone_no.Text;
            string address_var = txt_address.Text;
            string description_var = txt_description.Text;
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my update statement in which i am taking input from the user through windows forms  
                string updateCommand = $"UPDATE `distributor` SET `distributor_description`='{description_var}',`phone`='{phone_no_var}',`address`='{address_var}' WHERE `distributor_id`={distributorId_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the update statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = updateCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lbl_message.Text = "Record Updated Successfully!";
                }
                else
                {
                    lbl_message.Text = "Record cannot be Updated!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lbl_message.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int distributor_id_var = Int16.Parse(txt_distributor_id.Text);
            string distributor_phone_no_var = txt_distributor_phone_no.Text;
            string distributor_address_var = txt_address.Text;
            string distributor_description_var = txt_description.Text;
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my delete statement in which i am taking input from the user through windows forms  
                string deleteCommand = $"DELETE FROM `distributor` WHERE `distributor_id`={distributor_id_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the delete statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = deleteCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lbl_message.Text = "Record Deleted Successfully!";
                }
                else
                {
                    lbl_message.Text = "Record cannot be Deleted!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lbl_message.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int distributor_Id_var = Int16.Parse(txt_distributor_id.Text);

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my select statement in which i am taking input from the user through windows forms  
                string updateCommand = $"SELECT `distributor_id`, `distributor_description`, `phone`, `address` FROM `distributor` WHERE `distributor_id`={distributor_Id_var}";

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
                        txt_address.Text = reader.GetString("address");
                        txt_distributor_phone_no.Text = reader.GetString("phone");
                        txt_description.Text = reader.GetString("distributor_description");
                    }

                    lbl_message.Text = "Record Loaded Succesfully!";
                }
                else
                {
                    lbl_message.Text = "No Record Found!";
                }

                conn.Close();

            }
            catch (Exception ex)
            {

                lbl_message.Text = ex.Message;
            }
        }
    }
}
