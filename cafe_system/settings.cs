using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace cafe_system
{
    public partial class settings : UserControl
    {
        SqlConnection con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
        internal FormBorderStyle FormBorderStyle;
        public settings()
        {
            InitializeComponent();
            int red = 113;
            int green = 72;
            int blue = 61;
            Color customcolor = Color.FromArgb(red, green, blue);
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = customcolor;
        }
        public bool TopLevel { get; internal set; }

        private void btn_addAccount_Click(object sender, EventArgs e)
        {

        }

        private void SettBtn_add_Click(object sender, EventArgs e)
        {
            addAccount f1 = new addAccount();
            f1.Show();
            // Visible = false;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settings_Load(object sender, EventArgs e)
        {
            datagridview();
        }
        public void datagridview()
        {
            string query = "SELECT * FROM users;";

            

            SqlDataAdapter adapter1 = new SqlDataAdapter(query, con1);
            DataSet dataSet = new DataSet();

            

            adapter1.Fill(dataSet, "users");
            guna2DataGridView1.DataSource = dataSet.Tables["users"];
           
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {

               
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                string username = selectedRow.Cells["username"].Value.ToString();



               

                Settxt_Username.Text = username;




            }



        }

        private void settingsBtn_update_Click(object sender, EventArgs e)
        {
            string username = Settxt_Username.Text;
            string oldPasswordInput = Settxt_password.Text;
            string newPassword = Settxt_Newpassword.Text;
            string confirmedPassword = Settxt_confirmpass.Text;

           
            string query = "SELECT password FROM users WHERE username = @username";

            SqlCommand command = new SqlCommand(query, con1);
            command.Parameters.AddWithValue("@username", username);

            con1.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string oldPasswordDB = reader["password"].ToString();
                reader.Close();

                
                if (oldPasswordInput != oldPasswordDB)
                {
                    MessageBox.Show("Password needs to match with your current password.");
                }
                else if (newPassword != confirmedPassword)
                {
                    MessageBox.Show("New password and confirmed password do not match.");
                }
                else
                {
                    
                    string updateQuery = "UPDATE users SET password = @newPassword WHERE username = @username";

                    SqlCommand updateCommand = new SqlCommand(updateQuery, con1);
                    updateCommand.Parameters.AddWithValue("@newPassword", newPassword);
                    updateCommand.Parameters.AddWithValue("@username", username);

                    try
                    {
                        
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Password update failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating password: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No user found with the provided username.");
            }


            con1.Close();
            datagridview();
        }

        private void settingsBtn_delete_Click(object sender, EventArgs e)
        {
            string username = Settxt_Username.Text;
            string oldPasswordInput = Settxt_password.Text;
            string query = "SELECT password FROM users WHERE username = @username";

            SqlCommand command = new SqlCommand(query, con1);
            command.Parameters.AddWithValue("@username", username);

            con1.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string oldPasswordDB = reader["password"].ToString();
                con1.Close();
                reader.Close();

                
                if (oldPasswordInput != oldPasswordDB)
                {
                    MessageBox.Show("Password needs to match with your current password.");
                }
                else
                {
                    string query4 = $"DELETE FROM users  WHERE username=@username";



                    SqlCommand cmd4 = new SqlCommand(query4, con1);
                    cmd4.Parameters.AddWithValue("@username", username);
                    try
                    {
                        con1.Open();
                        cmd4.ExecuteNonQuery();

                        MessageBox.Show("Data Deleted");
                    }

                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally { con1.Close(); }
                }
                datagridview();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==1 && e.Value!=null)
            {
                string password = e.Value.ToString();
                e.Value = new string('*',password.Length);
            } 
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            datagridview();

        }
    }
}


    


