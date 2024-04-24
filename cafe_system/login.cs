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

namespace cafe_system
{
    public partial class login : Form
    {
        SqlConnection connect = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");

        public login()
        {
            InitializeComponent();

            // change place holder text size in here
            txt_user.Font = new Font(txt_user.Font.FontFamily, 12, FontStyle.Regular);

            txt_password.Font = new Font(txt_password.Font.FontFamily, 12,FontStyle.Regular);
        }




        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void user_login_Click(object sender, EventArgs e)
        {
            if(txt_user.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("please fill all blank", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                if(connect.State  == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM users WHERE username =@username AND password =@password";

                        using(SqlCommand cmd = new SqlCommand(selectData,connect))
                        {
                            cmd.Parameters.AddWithValue("@username",txt_user.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", txt_password.Text.Trim());
                             
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Sucess!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                home ho = new home();
                                ho.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Incorrect user name or password", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:"+ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
           
           
            

        }

        private void close_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
