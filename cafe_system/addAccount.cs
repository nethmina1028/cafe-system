using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Guna.UI2.Native.WinApi;

namespace cafe_system
{

    public partial class addAccount : Form

    {

        SqlConnection con2 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
        public addAccount()
        {
            InitializeComponent();
          
        }

        private void txt_empID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdAcoountBtn_close_Click(object sender, EventArgs e)
        {

            settings settings = new settings();
            settings.datagridview();
            settings.Show();
            this.Hide();

        }


        private void AdAcoountBtn_add_Click(object sender, EventArgs e)
        {
            string employeeID = txt_empID.Text;
            string userName = txt_username.Text;
            string password = txt_password.Text;
            string confirmPassword = txt_confirmpass.Text;

            // Perform validation checks for input fields
            if (String.IsNullOrEmpty(employeeID) ||
                String.IsNullOrEmpty(userName) ||
                String.IsNullOrEmpty(password) ||
                String.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields", "Error");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EmployeeExists(employeeID))
            {
                MessageBox.Show("Employee ID does not exist. Please enter a valid Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert the user account into the database
            try
            {
                con2.Open();
                string query = $"INSERT INTO users (username, password, employeeID) VALUES (@UserName, @Password, @EmployeeID)";
                SqlCommand cmd = new SqlCommand(query, con2);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful data entry!");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        private bool EmployeeExists(string employeeID)
        {
            // Query to check if the employee ID exists in the employee table
            string query = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @employeeID";

            // Create a SqlCommand object
            SqlCommand command = new SqlCommand(query, con2);
            // Add parameters to the command
            command.Parameters.AddWithValue("@employeeID", employeeID);

            // Execute the query
            con2.Open();
            int count = (int)command.ExecuteScalar();
            con2.Close();

            // If count is greater than 0, the employee ID exists
            return count > 0;
        }
        private void addAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
