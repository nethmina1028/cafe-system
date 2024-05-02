using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.HtmlRenderer.Adapters;
using System.IO;
using System.Data.SqlClient;
using Guna.UI2.WinForms.Suite;



namespace cafe_system
{
    public partial class employee : UserControl
    {
        private SqlConnection con1;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private OpenFileDialog openFileDialog1;
        private byte[] imageData;
        private string imagePath;

        internal FormBorderStyle FormBorderStyle;
        public employee()
        {
            InitializeComponent();
            int red = 113;
            int green = 72;
            int blue = 61;
            Color customcolor = Color.FromArgb(red, green, blue);
            emp_dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = customcolor;
            con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
            adapter = new SqlDataAdapter();
            dataSet = new DataSet();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(.jpg; *.jpeg; *.png)|.jpg; *.jpeg; *.png";
            DataTable dataTable = new DataTable();
            emp_dataGridView2.DataSource = dataTable;

        }
        public bool TopLevel { get; internal set; }

        

        private void empBtn_search_Click(object sender, EventArgs e)
        {
            string searchText = emp_Search.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                try
                {

                    if (con1 == null)
                    {
                        con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
                    }

                    string query = "SELECT * FROM [employee] WHERE EmployeeId = @SearchText OR EmployeeName LIKE @SearchText";

                    SqlCommand cmd = new SqlCommand(query, con1);

                    if (int.TryParse(searchText, out int employeeId))
                    {

                        cmd.Parameters.AddWithValue("@SearchText", employeeId);
                    }

                    else
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }

                    con1.Open();
                    adapter.SelectCommand = cmd;
                    dataSet.Clear();
                    adapter.Fill(dataSet, "employee");
                    emp_dataGridView2.DataSource = dataSet.Tables["employee"];

                    if (emp_dataGridView2.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching records found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    if (con1 != null && con1.State == ConnectionState.Open)
                    {
                        con1.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter search criteria.");
            }


        }

        private void empBtn_add_Click(object sender, EventArgs e)
        {
            int EmployeeId = int.Parse(txtEmp_Id.Text);
            string EmployeeName = txtEmp_Name.Text;
            string JobRole = typebEmp_jobrole.Text;
            int NIC = int.Parse(txtEmp_nic.Text);
            int PhoneNo = int.Parse(txtEmp_phoneNo.Text);
            string Address = textEmp_address.Text;
            byte[] imageData = File.ReadAllBytes(imagePath);

            string query = "INSERT INTO [Employee] (EmployeeId, EmployeeName, JobRole,  NIC, PhoneNo,Address) VALUES (@EmployeeId, @EmployeeName, @JobRole, @NIC, @PhoneNo,@Address)";



            SqlCommand cmd = new SqlCommand(query, con1);

            cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
            cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName);
            cmd.Parameters.AddWithValue("@JobRole", JobRole);
            //cmd.Parameters.AddWithValue("@Bin",Bin);
            cmd.Parameters.AddWithValue("@NIC", NIC);
            cmd.Parameters.AddWithValue("@PhoneNO", PhoneNo);
            cmd.Parameters.AddWithValue("@Address", Address);

            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");

                adapter.SelectCommand = new SqlCommand("SELECT * FROM [employee]", con1);
                dataSet.Clear();
                adapter.Fill(dataSet, "employee");
                emp_dataGridView2.DataSource = dataSet.Tables["employee"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();
            }


            datagridview1();

        }
        private void employee_Load(object sender, EventArgs e)
        {
            datagridview1();
        }

        private void datagridview1()
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(.jpg; *.jpeg; *.png)|.jpg; *.jpeg; *.png";

            DataTable dataTable = new DataTable();
            emp_dataGridView2.DataSource = dataTable;



            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            SqlConnection con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
            con1.Open();
            SqlCommand cmd = new SqlCommand("Select * from [employee]", con1);
            SqlDataAdapter
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            emp_dataGridView2.DataSource = dt;
            con1.Close();
        }   

        private void employee_Load_1(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(.jpg; *.jpeg; *.png)|.jpg; *.jpeg; *.png";

            DataTable dataTable = new DataTable();
            emp_dataGridView2.DataSource = dataTable;
            typebEmp_jobrole.Items.Add("Cashier");
            typebEmp_jobrole.Items.Add("Chief");
            typebEmp_jobrole.Items.Add("Stuart");
            typebEmp_jobrole.Items.Add("Barista");
            typebEmp_jobrole.Items.Add("Shift Supervisor");

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            SqlConnection con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
            con1.Open();
            SqlCommand cmd = new SqlCommand("Select * from [employee]", con1);
            SqlDataAdapter
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            emp_dataGridView2.DataSource = dt;
            con1.Close();
            


            }

            private void typebEmp_jobrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");

            
            int EmployeeId = int.Parse(txtEmp_Id.Text);
            string EmployeeName = txtEmp_Name.Text;
            string JobRole = typebEmp_jobrole.Text;
            int NIC = int.Parse(txtEmp_nic.Text);
            int PhoneNo = int.Parse(txtEmp_phoneNo.Text);
            string Address = textEmp_address.Text;

            byte[] imageData = File.ReadAllBytes(imagePath);

            string query = "INSERT INTO [Employee] (EmployeeId, EmployeeName, JobRole,  NIC, PhoneNo,Address) VALUES (@EmployeeId, @EmployeeName, @JobRole,  @NIC, @PhoneNo,@Address)";

            SqlCommand cmd = new SqlCommand(query, con1);

            cmd.Parameters.AddWithValue("@EmployeeId",EmployeeId);
            cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName);
            cmd.Parameters.AddWithValue("@JobRole", JobRole);
            //cmd.Parameters.AddWithValue("@Bin",Bin);
            cmd.Parameters.AddWithValue("@NIC", NIC);
            cmd.Parameters.AddWithValue("@PhoneNO", PhoneNo);
            cmd.Parameters.AddWithValue("@Address", Address);

            try
            {
                con1.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con1.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Saved");


                    dataSet.Clear();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM [employee]", con1);
                    adapter.Fill(dataSet, "employee");
                    emp_dataGridView2.DataSource = dataSet.Tables["employee"];
                }
                else
                {
                    MessageBox.Show("No rows inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void empBtn_update_Click(object sender, EventArgs e)
        {
            int EmployeeId = int.Parse(txtEmp_Id.Text);
            string EmployeeName = txtEmp_Name.Text;
            string JobRole = typebEmp_jobrole.Text;
            int NIC = int.Parse(txtEmp_nic.Text);
            int PhoneNo = int.Parse(txtEmp_phoneNo.Text);
            string Address = textEmp_address.Text;
            byte[] imageData = File.ReadAllBytes(imagePath);

            string query = "UPDATE [employee] SET EmployeeName = @EmployeeName, JobRole = @JobRole, NIC = @NIC,PhoneNo=@PhoneNo,Address=@Address  WHERE EmployeeId = @EmployeeId";

            SqlCommand cmd = new SqlCommand(query, con1);

            cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
            cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName);
            cmd.Parameters.AddWithValue("@JobRole", JobRole);
            //cmd.Parameters.AddWithValue("@Bin",Bin);
            cmd.Parameters.AddWithValue("@NIC", NIC);
            cmd.Parameters.AddWithValue("@PhoneNO", PhoneNo);
            cmd.Parameters.AddWithValue("@Address", Address);

            try
            {
                con1.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                int secondRowsAffected = cmd.ExecuteNonQuery();
                con1.Close();

                if (rowsAffected > 0 && secondRowsAffected > 0)
                {
                    MessageBox.Show("Successfully Updated");

                    dataSet.Clear();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM [employee]", con1);
                    adapter.Fill(dataSet, "employee");
                    emp_dataGridView2.DataSource = dataSet.Tables["employee"];
                }
                else
                {
                    MessageBox.Show("No rows updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void empBtn_clear_Click(object sender, EventArgs e)
        {

            {
                clearField();
            }

            

        }
        public void clearField()
        {
            txtEmp_Id.Text = "";
            txtEmp_Name.Text = "";
            txtEmp_nic.Text = "";
            textEmp_address.Text = "";
            typebEmp_jobrole.SelectedIndex = -1;
            txtEmp_phoneNo.Text = "";
            pictureBox1.Image = null;
        }

        private void empBtn_delete_Click(object sender, EventArgs e)
        {
            if (emp_dataGridView2.SelectedRows.Count > 0)
            {
                int selectedRowIndex = emp_dataGridView2.SelectedRows[0].Index;

                int EmployeeId = Convert.ToInt32(emp_dataGridView2.Rows[selectedRowIndex].Cells[0].Value);

                Console.WriteLine("Deleting employee with ID: " + EmployeeId);

                string query = "DELETE FROM [employee] WHERE EmployeeId = @employeeId";

                SqlCommand cmd = new SqlCommand(query, con1);
                cmd.Parameters.AddWithValue("@employeeId", EmployeeId);

                try
                {
                    con1.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con1.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Deleted ");

                        dataSet.Clear();
                        adapter.SelectCommand = new SqlCommand("SELECT * FROM [employee]", con1);
                        adapter.Fill(dataSet, "employee");
                        emp_dataGridView2.DataSource = dataSet.Tables["employee"];
                    }
                    else
                    {
                        MessageBox.Show("No rows deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting row: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }




        }

        private void img_bttn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                imageData = File.ReadAllBytes(imagePath);

                pictureBox1.Image = Image.FromFile(imagePath);

                this.imagePath = imagePath;
            }

        }

        private void emp_dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

