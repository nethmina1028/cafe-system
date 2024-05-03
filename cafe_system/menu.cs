using cafe_system.Class_BLL;
using Guna.UI2.WinForms;
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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;



namespace cafe_system
{
    public partial class menu : UserControl
    {

        internal FormBorderStyle FormBorderStyle;
        public menu()
        {
            InitializeComponent();
            generateProducctCards();

            int red = 113;
            int green = 72;
            int blue = 61;
            Color customcolor = Color.FromArgb(red, green, blue);
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = customcolor;

        }

        public bool cardsAdded = false;
        public string Reservecity;
      

        public bool TopLevel { get; internal set; }

        private void product1_Load(object sender, EventArgs e)
        {
           
        }



        public void generateProducctCards()
        {
            tableLayoutPanel1.Controls.Clear();

          

            ClassBLL objBLL = new ClassBLL();
      

            DataTable dt = objBLL.GetItems(Reservecity);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    product[] cards = new product[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            cards[i] = new product();


                          

                            MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                            cards[i].img.BackgroundImage = new Bitmap(ms);

                            cards[i].prodName.Text = row["Name"].ToString();
                          
                            
                            tableLayoutPanel1.Controls.Add(cards[i]);
                            cards[i].Anchor = AnchorStyles.None;


                            //  card click event

                            cards[i].img.Click += (sender, e) =>
                            {
                               
                                PopulateDataGridView(row); // Pass the DataRow to the method
                            };


                        }
                    }
                }

                else
                {
                    MessageBox.Show("Empty Data.");
                }
            }


        }

      

        private void PopulateDataGridView(DataRow rowData)
        {

            
            // Assuming dataGridView1 is your DataGridView control
            if (guna2DataGridView1 != null && rowData != null)
            {



                DataTable dataTable = guna2DataGridView1.DataSource as DataTable;
                if (dataTable == null)
                {

                    // Create a new DataTable and add a row with the clicked card's data
                    dataTable  = new DataTable();
                    dataTable.Columns.Add("Name", typeof(string)); // Add columns as needed
                    dataTable.Columns.Add("Price", typeof(decimal));
                    dataTable.Columns.Add("Qty", typeof(int));
                    dataTable.Columns.Add("Amount", typeof(decimal));
                

                    guna2DataGridView1.DataSource = dataTable;
                 

                   
                }
                // Add the clicked card's data to the DataTable
                // dataTable.Rows.Add(rowData["Name"].ToString(), (decimal)rowData["Price"]); // Add more fields as needed

                // Set the DataTable as the DataSource for the DataGridView
                // Check if the product already exists in the DataTable


                DataRow existingRow = dataTable.AsEnumerable().FirstOrDefault(
                    row => row.Field<string>("Name") == rowData.Field<string>("Name"));

                if (existingRow != null)
                {
                    // increment Qty by 1
                    int currentQty = existingRow.Field<int>("Qty");
                    existingRow.SetField("Qty", currentQty + 1);

                    // Recalculate the Amount 
                    decimal price = existingRow.Field<decimal>("Price");
                    existingRow.SetField("Amount", price * (currentQty + 1));
                }
                else
                {

                    // Add a new row with the clicked card
                    string name = rowData["Name"].ToString();
                    decimal price = (decimal)rowData["Price"];
                    int qty = 1;
                    decimal amount = price * qty;



                    // Add a new row with the clicked card
                    DataRow newRow = dataTable.NewRow();
                    newRow["Name"] = rowData["Name"].ToString();
                    newRow["Price"] = (decimal)rowData["Price"];
                    newRow["Qty"] = 1; 
                    newRow["Amount"] = (decimal)rowData["Price"]; 

                    dataTable.Rows.Add(newRow);
                }


                guna2DataGridView1.Refresh();


                decimal totalAmount = CalculateTotalAmount(dataTable);

                // Display total amount in a label 
                lbl_total.Text = $": {totalAmount:C}";
                


            }
        }



        private decimal CalculateTotalAmount(DataTable dataTable)
        {
            decimal totalAmount = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                decimal amount = row.Field<decimal>("Amount");
                totalAmount += amount;
            }

            return totalAmount;
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
            if (guna2DataGridView1.DataSource is DataTable dataTable)
            {
                dataTable.Rows.Clear(); 

                
                guna2DataGridView1.Refresh();

                
                lbl_total.Text = ": $0.00";
                
            }
        }
       



        private void btn_pay_Click(object sender, EventArgs e)
        {
          
            ClassBLL2 objBLL2 = new ClassBLL2();

            // Get the latest OrderID from the database
            int latestOrderID = objBLL2.GetLatestOrderID();

            // Increment the latest OrderID to generate a new OrderID
            int newOrderID = objBLL2.IncrementOrderID(latestOrderID);


            DateTime orderDateTime = DateTime.Now;
            
           
            decimal totalAmount = CalculateTotalAmount(guna2DataGridView1.DataSource as DataTable);

            // Iterate through DataGridView rows to save each product as a separate order item
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
               


                if (row.Cells["Name"] != null && row.Cells["Name"].Value != null)
                {
                    string productName = row.Cells["Name"].Value.ToString();
                   
                    Console.WriteLine("Product Name: " + productName);

                    

                    // int productId = Convert.ToInt32(row.Cells["ID"].Value); // Assuming "ID" is the column name for item ID
                    int quantity = Convert.ToInt32(row.Cells["Qty"].Value);
                    decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);

                    
                    objBLL2.SaveOrder(orderDateTime, productName, quantity, amount, newOrderID);
                }
                else
                {
                    
                    Console.WriteLine("Error: The cell value is null.");
                }

               
            }

            
            MessageBox.Show("Order(s) saved successfully.");

        

            btn_clear_Click(sender, e);

            oder_Id.Text = newOrderID.ToString();
            
        }
       


    }
}
