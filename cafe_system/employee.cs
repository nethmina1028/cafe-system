using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


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
        }
        public bool TopLevel { get; internal set; }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void empBtn_search_Click(object sender, EventArgs e)
        {


        }

        private void empBtn_add_Click(object sender, EventArgs e)
        {
            int EmployeeId = int.Parse(txtEmp_Id.Text);
            string EmployeeName = txtEmp_Name.Text;


            string JobRole = typebEmp_jobrole.Text;
            int NIC = int.Parse(txtEmp_nic.Text);
            int Phone = int.Parse(txtEmp_phoneNo.Text);
            string Address = textEmp_address.Text;

            //byte[] imageData = File.ReadAllBytes(imagePath);

            string query = "INSERT INTO [Employee] (EmployeeId, EmployeeName, JobRole, NIC, Phone, Address) VALUES (@EmployeetId, @EmployeeName, @JobRole, @NIC, @Phone, @Address)";
            SqlCommand cmd = new SqlCommand(query, con1);

            cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
            cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName);
            cmd.Parameters.AddWithValue("@JobRole", JobRole);
            cmd.Parameters.AddWithValue("@NIC", NIC);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);

            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");

                adapter.SelectCommand = new SqlCommand("SELECT * FROM [employee]", con1);
                dataSet.Clear();
                adapter.Fill(dataSet, "employee");
                emp_datagridview.DataSource = dataSet.Tables["employee"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();
            }
        }
        private void employee_Load(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(.jpg; *.jpeg; *.png)|.jpg; *.jpeg; *.png";

            DataTable dataTable = new DataTable();
            emp_datagridview.DataSource = dataTable;



            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            SqlConnection con1 = new SqlConnection(@"Data");
            con1.Open();
            SqlCommand cmd = new SqlCommand("Select * from [employee]", con1);
            SqlDataAdapter
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            emp_datagridview.DataSource = dt;
        }

        private void employee_Load_1(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Image Files(.jpg; *.jpeg; *.png)|.jpg; *.jpeg; *.png";

            DataTable dataTable = new DataTable();
            emp_datagridview.DataSource = dataTable;
            typebEmp_jobrole.Items.Add("Snacks");
            typebEmp_jobrole.Items.Add("Drinks");
            typebEmp_jobrole.Items.Add("Salads");
            typebEmp_jobrole.Items.Add("Pizza");
            typebEmp_jobrole.Items.Add("Soups");

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            SqlConnection con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
            con1.Open();
            SqlCommand cmd = new SqlCommand("Select * from [employee]", con1);
            SqlDataAdapter
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            emp_datagridview.DataSource = dt;

        }

        private void typebEmp_jobrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");

            
            int EmployeeId = int.Parse(txtEmp_Id.Text);
            string EmployeeName = txtEmp_Name.Text;
            double JobRole = double.Parse(typebEmp_jobrole.Text);
            int NIC = int.Parse(txtEmp_nic.Text);
            int PhoneNo = int.Parse(txtEmp_phoneNo.Text);
            string Address = textEmp_address.Text;

            byte[] imageData = File.ReadAllBytes(imagePath);

            string query = "INSERT INTO [inventory] (EmployeetId, EmployeeName, JobRole, Bin, NIC, Phone No) VALUES (@EmployeetId, @EmployeeName, @JobRole, @Bin, @NIC, @Phone No)";

            SqlCommand cmd = new SqlCommand(query, con1);

            cmd.Parameters.AddWithValue("@EmployeeId",EmployeeId);
            cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName);
            cmd.Parameters.AddWithValue("@JobRole", JobRole);
            //cmd.Parameters.AddWithValue("@Bin",Bin);
            cmd.Parameters.AddWithValue("@NIC", NIC);
            cmd.Parameters.AddWithValue("@PhoneNO", PhoneNo);

            try
            {
                con1.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con1.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Saved");


                    dataSet.Clear();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM [inventory]", con1);
                    adapter.Fill(dataSet, "inventory");
                    emp_datagridview.DataSource = dataSet.Tables["inventory"];
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
    }
}

