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
    public partial class reports : UserControl
    {
        private SqlConnection con1;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private OpenFileDialog openFileDialog1;
        private byte[] imageData;
        private string imagePath;


        internal FormBorderStyle FormBorderStyle;
        public reports()
        {
            InitializeComponent();
            int red = 113;
            int green = 72;
            int blue = 61;
            Color customcolor = Color.FromArgb(red, green, blue);
            report_dataGrid.ColumnHeadersDefaultCellStyle.BackColor = customcolor;
            con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
            adapter = new SqlDataAdapter();
            dataSet = new DataSet();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(.jpg; *.jpeg; *.png)|.jpg; *.jpeg; *.png";
            DataTable dataTable = new DataTable();
            report_dataGrid.DataSource = dataTable;

        }
        public bool TopLevel { get; internal set; }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reports_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            report_dataGrid.DataSource = dataTable;


            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            SqlConnection con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
            con1.Open();
            SqlCommand cmd = new SqlCommand("Select * from [Oder]", con1);
            SqlDataAdapter
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            report_dataGrid.DataSource = dt;
        }

 

        private void bttnSearch_Click_1(object sender, EventArgs e)
        {
            string searchText = SearchText.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                try
                {
                    if (con1 == null)
                    {
                        con1 = new SqlConnection(@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");
                    }

                    string query = "SELECT * FROM [Oder] WHERE OrderID = @SearchText OR Name LIKE @SearchText";

                    SqlCommand cmd = new SqlCommand(query, con1);

                    if (int.TryParse(searchText, out int OrderID))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", OrderID);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }

                    con1.Open();
                    adapter.SelectCommand = cmd;
                    dataSet.Clear();
                    adapter.Fill(dataSet, "Oder");
                    report_dataGrid.DataSource = dataSet.Tables["Oder"];

                    if (report_dataGrid.Rows.Count == 0)
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
                MessageBox.Show("Please enter a search term.");
            }

        }

    }
    }

    
