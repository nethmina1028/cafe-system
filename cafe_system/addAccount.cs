﻿using Guna.UI2.WinForms.Suite;
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

namespace cafe_system
{
    public partial class addAccount : Form

    {
        SqlConnection con2= new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
        public addAccount()
        {
            InitializeComponent();
        }

        private void txt_empID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdAcoountBtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdAcoountBtn_add_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != txt_confirmpass.Text)
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_empID.Text) ||
                String.IsNullOrEmpty(txt_username.Text) ||
                String.IsNullOrEmpty(txt_password.Text) ||
                String.IsNullOrEmpty(txt_confirmpass.Text))
            {
                MessageBox.Show("Please Fill the in all field", "Error");
                return;

            }
            else
            {
                // Get input values
                string userName = txt_username.Text;
                string password = txt_password.Text;
                int empID = Convert.ToInt32(txt_empID.Text);

                // Create the SQL query
                string query = $"INSERT INTO users (username,password,employeeID) VALUES ('{userName}', '{password}', '{empID}');";
                SqlCommand cmd = new SqlCommand(query, con2);

                // Execute the command
                try
                {
                    con2.Open(); // Open the connection
                    cmd.ExecuteNonQuery(); // Execute the query
                    MessageBox.Show("Successful data entry!");
                    settings form = new settings();
                    form.Show();
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message);
                }
                finally
                {
                    con2.Close(); // Close the connection
                }
            }

        }

        private void addAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
