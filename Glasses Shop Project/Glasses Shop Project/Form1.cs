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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
         
            string username_var = txtUsername.Text;
            string password_var = txtPassword.Text;
            string firstname_var = txtFirstname.Text;
            string lastname_var = txtLastName.Text;
            string phoneno_var = txtPhoneNum.Text;
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = universityproject; uid = root; ";

                //This is my insert statement in which i am taking input from the user through windows forms  
                //    string insertCommand = $"INSERT INTO `user`(`username`, `password`, `first_name`, `last_name`,`phone_no`) VALUES ('{username_var}','{password_var},{firstname_var}','{lastname_var},{phoneno_var}')";
                string insertCommand = $"INSERT INTO `user`(`username`, `password`, `first_name`, `last_name`, `phone_no`) VALUES ('{username_var}','{password_var}','{firstname_var}','{lastname_var}','{phoneno_var}')";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the insert statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = insertCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblMessage.Text = "SignUp Successfully! Enter Login";
                }
                else
                {
                    lblMessage.Text = "SignUp did not completed successfully";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user_name_var = txtUsername.Text;   // name of your username textbox
            string password_var = txtPassword.Text;     // name of your password textbox

            try
            {
                string myConnectionString = "server = localhost; database = universityproject; uid = root; ";
                MySqlConnection conn = new MySqlConnection(myConnectionString);
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"Select * from user where username='{user_name_var}' and password='{password_var}'";
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    lblMessage.Text = "Login Successful";
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    lblMessage.Text = "Login Failed";
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
