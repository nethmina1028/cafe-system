using Guna.UI2.HtmlRenderer.Adapters;
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
using System.IO;

namespace cafe_system
{
   
    public partial class inventory : UserControl
    {
        private SqlConnection con1;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private OpenFileDialog openFileDialog1;
        private byte[] imageData;
        private string imagePath;


        internal FormBorderStyle FormBorderStyle;

        public inventory()
        {
            InitializeComponent();
            con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\_USER_\source\repos\cafe-system\cafe_system\Database1.mdf;Integrated Security=True");
            adapter = new SqlDataAdapter();
            dataSet = new DataSet();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
        }
        public bool TopLevel { get; internal set; }

        private void bttnAdd_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\_USER_\source\repos\cafe-system\cafe_system\Database1.mdf;Integrated Security=True");

            int ProductId = int.Parse(txtpid.Text);
            string ProductName = txtpname.Text;
            double Price = double.Parse(txtprice.Text);
            int Stock = int.Parse(txtstock.Text);
            string Type = typebox.Text;

            //MessageBox.Show("Successfully Saved");

            string query = $"INSERT INTO   [cafe] (ProductId,ProductName,Price,Stock,Type) VALUES({ProductId},'{ProductName}',{Price},{Stock},'{Type}')";

            SqlCommand cmd = new SqlCommand(query, con1);

            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@Type", Type);


            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");


                adapter.SelectCommand = new SqlCommand("SELECT * FROM [cafe]", con1);


                adapter.Fill(dataSet, "cafe");
                dataGridView1.DataSource = dataSet.Tables["cafe"];

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

        private void inventory_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
            typebox.Items.Add("Breakfast");
            typebox.Items.Add("Lunch");
            typebox.Items.Add("Dinner");
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            int ProductId = int.Parse(txtpid.Text);
            string ProductName = txtpname.Text;
            double Price = double.Parse(txtprice.Text);
            int Stock = int.Parse(txtstock.Text);
            string Type = typebox.Text;

            string query = "UPDATE [cafe] SET ProductName = @ProductName, Price = @Price, Stock = @Stock, Type = @Type WHERE ProductId = @ProductId";

            SqlCommand cmd = new SqlCommand(query, con1);

            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@Type", Type);

            try
            {
                con1.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con1.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Updated");

                    // Refresh DataGridView
                    dataSet.Clear();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM [cafe]", con1);
                    adapter.Fill(dataSet, "cafe");
                    dataGridView1.DataSource = dataSet.Tables["cafe"];
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

        private void bttnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        public void clearField()
        {
            txtpid.Text = "";
            txtpname.Text = "";
            txtprice.Text = "";
            txtstock.Text = "";
            typebox.SelectedIndex = -1;

        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // Get the ProductId from the first column of the selected row
                int productId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

                string query = "DELETE FROM [cafe] WHERE ProductId = @ProductId";

                SqlCommand cmd = new SqlCommand(query, con1);
                cmd.Parameters.AddWithValue("@ProductId", productId);

                try
                {
                    con1.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con1.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Deleted");

                        // Refresh DataGridView
                        dataSet.Clear();
                        adapter.SelectCommand = new SqlCommand("SELECT * FROM [cafe]", con1);
                        adapter.Fill(dataSet, "cafe");
                        dataGridView1.DataSource = dataSet.Tables["cafe"];
                    }
                    else
                    {
                        MessageBox.Show("No rows deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void bttnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string imagePath = openFileDialog1.FileName;


                imageData = File.ReadAllBytes(imagePath);


                imagebox.Image = Image.FromFile(imagePath);
            }
        }

        private void imagebox_Click(object sender, EventArgs e)
        {
            int ProductId = int.Parse(txtpid.Text);
            string ProductName = txtpname.Text;
            double Price = double.Parse(txtprice.Text);
            int Stock = int.Parse(txtstock.Text);
            string Type = typebox.Text;

            byte[] imageData = File.ReadAllBytes(imagePath);

            string query = "INSERT INTO [cafe] (ProductId, ProductName, Price, Stock, Type, Image) VALUES (@ProductId, @ProductName, @Price, @Stock, @Type, @ImageData)";

            SqlCommand cmd = new SqlCommand(query, con1);

            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@Image", imageData); // Add image byte array parameter

            try
            {
                con1.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con1.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Saved");

                    // Refresh DataGridView
                    dataSet.Clear();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM [cafe]", con1);
                    adapter.Fill(dataSet, "cafe");
                    dataGridView1.DataSource = dataSet.Tables["cafe"];
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

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            string searchText = search.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                try
                {

                    if (con1 == null)
                    {
                        con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\_USER_\source\repos\cafe-system\cafe_system\Database1.mdf;Integrated Security=True");
                    }

                    string query = "SELECT * FROM [cafe] WHERE ProductId = @SearchText OR ProductName LIKE @SearchText";

                    SqlCommand cmd = new SqlCommand(query, con1);

                    if (int.TryParse(searchText, out int productId))
                    {

                        cmd.Parameters.AddWithValue("@SearchText", productId);
                    }

                    else
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }

                    con1.Open();
                    adapter.SelectCommand = cmd;
                    dataSet.Clear();
                    adapter.Fill(dataSet, "cafe");
                    dataGridView1.DataSource = dataSet.Tables["cafe"];

                    if (dataGridView1.Rows.Count == 0)
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
                    // Close the connection if it's open
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

    }

}
