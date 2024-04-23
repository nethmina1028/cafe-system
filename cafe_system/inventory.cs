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
using Guna.UI2.HtmlRenderer.Adapters;
using System.IO;
using Guna.UI2.WinForms.Suite;

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
            con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
            adapter = new SqlDataAdapter();
            dataSet = new DataSet();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(.jpg; *.jpeg; *.png)|.jpg; *.jpeg; *.png";

            DataTable dataTable = new DataTable();
            inven_dataGrid.DataSource = dataTable;
        }
        public bool TopLevel { get; internal set; }

        private void inventory_Load(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Image Files(.jpg; *.jpeg; *.png)|.jpg; *.jpeg; *.png";



            DataTable dataTable = new DataTable();
            inven_dataGrid.DataSource = dataTable;
            inven_typebox.Items.Add("Snacks");
            inven_typebox.Items.Add("Drinks");
            inven_typebox.Items.Add("Salads");
            inven_typebox.Items.Add("Pizza");
            inven_typebox.Items.Add("Soups");

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            SqlConnection con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
            con1.Open();
            SqlCommand cmd = new SqlCommand("Select * from [inventory]", con1);
            SqlDataAdapter
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            inven_dataGrid.DataSource = dt;
            
        }

        private void Inven_btnAdd_Click(object sender, EventArgs e)
        {
            int ProductId = int.Parse(inven_pId.Text);
            string ProductName = inven_Pname.Text;
            decimal Price = decimal.Parse(inven_price.Text);
            int Stock = int.Parse(Inven_stock.Text);
            string Type = inven_typebox.Text;

            byte[] imageData = File.ReadAllBytes(imagePath);

            string query = "INSERT INTO [inventory] (ProductId, ProductName, Price, Stock, Type, Image) VALUES (@ProductId, @ProductName, @Price, @Stock, @Type, @ImageData)";

            SqlCommand cmd = new SqlCommand(query, con1);

            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@ImageData", imageData);

            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");

                adapter.SelectCommand = new SqlCommand("SELECT * FROM [inventory]", con1);
                dataSet.Clear();
                adapter.Fill(dataSet, "inventory");
                inven_dataGrid.DataSource = dataSet.Tables["inventory"];
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

        private void Inven_btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                imageData = File.ReadAllBytes(imagePath);

                Inven_imagebox.Image = Image.FromFile(imagePath);

                this.imagePath = imagePath;
            }
        }

        private void Inven_imagebox_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");


            int ProductId = int.Parse(inven_pId.Text);
            string ProductName = inven_Pname.Text;
            double Price = double.Parse(inven_price.Text);
            int Stock = int.Parse(Inven_stock.Text);
            string Type = inven_typebox.Text;

            byte[] imageData = File.ReadAllBytes(imagePath);

            string query = "INSERT INTO [inventory] (ProductId, ProductName, Price, Stock, Type, Image) VALUES (@ProductId, @ProductName, @Price, @Stock, @Type, @ImageData)";

            SqlCommand cmd = new SqlCommand(query, con1);

            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@Image", imageData);

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
                    inven_dataGrid.DataSource = dataSet.Tables["inventory"];
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

        private void ProcessSelectedImage(string imagePath)
        {
            Inven_imagebox.Image = Image.FromFile(imagePath);
        }

        private void Inven_btnUpdate_Click(object sender, EventArgs e)
        {
            int ProductId = int.Parse(inven_pId.Text);
            string ProductName = inven_Pname.Text;
            double Price = double.Parse(inven_price.Text);
            int Stock = int.Parse(Inven_stock.Text);
            string Type = inven_typebox.Text;

            string query = "UPDATE [inventory] SET ProductName = @ProductName, Price = @Price, Stock = @Stock, Type = @Type WHERE ProductId = @ProductId";

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
                int secondRowsAffected = cmd.ExecuteNonQuery();
                con1.Close();

                if (rowsAffected > 0 && secondRowsAffected > 0)
                {
                    MessageBox.Show("Successfully Updated");

                    dataSet.Clear();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM [inventory]", con1);
                    adapter.Fill(dataSet, "inventory");
                    inven_dataGrid.DataSource = dataSet.Tables["inventory"];
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

        private void Inven_btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        public void clearField()
        {
            inven_pId.Text = "";
            inven_Pname.Text = "";
            inven_price.Text = "";
            Inven_stock.Text = "";
            inven_typebox.SelectedIndex = -1;
            inven_search.Text = "";
            Inven_imagebox.Image = null;
        }

        private void Inven_btnDelete_Click(object sender, EventArgs e)
        {
            if (inven_dataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = inven_dataGrid.SelectedRows[0].Index;

                int productId = Convert.ToInt32(inven_dataGrid.Rows[selectedRowIndex].Cells[0].Value);

                Console.WriteLine("Deleting product with ID: " + productId);

                string query = "DELETE FROM [inventory] WHERE ProductId = @ProductId";

                SqlCommand cmd = new SqlCommand(query, con1);
                cmd.Parameters.AddWithValue("@ProductId", productId);

                try
                {
                    con1.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con1.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Deleted ");

                        dataSet.Clear();
                        adapter.SelectCommand = new SqlCommand("SELECT * FROM [inventory]", con1);
                        adapter.Fill(dataSet, "inventory");
                        inven_dataGrid.DataSource = dataSet.Tables["inventory"];
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

        private void Inven_btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = inven_search.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                try
                {

                    if (con1 == null)
                    {
                        con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
                    }

                    string query = "SELECT * FROM [inventory] WHERE ProductId = @SearchText OR ProductName LIKE @SearchText";

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
                    adapter.Fill(dataSet, "inventory");
                    inven_dataGrid.DataSource = dataSet.Tables["inventory"];

                    if (inven_dataGrid.Rows.Count == 0)
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

    }

}
