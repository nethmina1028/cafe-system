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
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System.Drawing.Printing;


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

        private string GenerateReceipt(int orderID, DataTable orderItems, decimal totalAmount)
        {
            StringBuilder receiptBuilder = new StringBuilder();

            receiptBuilder.AppendLine("----- Receipt -----");
            receiptBuilder.AppendLine($"Order ID: {orderID}");
            receiptBuilder.AppendLine("Items:");

            foreach (DataRow row in orderItems.Rows)
            {
                string itemName = row["Name"].ToString();
                int quantity = Convert.ToInt32(row["Qty"]);
                decimal amount = Convert.ToDecimal(row["Amount"]);

                receiptBuilder.AppendLine($"{itemName} x {quantity}  ${amount}");
            }

            receiptBuilder.AppendLine($"Total Amount: ${totalAmount}");
            receiptBuilder.AppendLine("--------------------");

            return receiptBuilder.ToString();
        }


        private void SaveReceiptAsPdf(string receiptText, string filePath)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 12);

            // Draw receipt text on the PDF
            XRect rect = new XRect(40, 40, page.Width.Point - 80, page.Height.Point - 80);
            gfx.DrawString(receiptText, font, XBrushes.Black, rect, XStringFormats.TopLeft);

            // Save the PDF document
            document.Save(filePath);
            document.Close();
        }

        private void PrintPdf(string filePath)
        {
            try
            {
                // Print the PDF 
                using (PrintDocument pd = new PrintDocument())
                {
                    pd.PrintPage += (sender, e) =>
                    {
                        e.Graphics.DrawImage(Image.FromFile(filePath), e.MarginBounds);
                    };

                    pd.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing receipt: {ex.Message}");
            }
        }


        private void btn_pay_Click(object sender, EventArgs e)
      

        {
            ClassBLL2 objBLL2 = new ClassBLL2();


            int latestOrderID = objBLL2.GetLatestOrderID();


            int newOrderID = objBLL2.IncrementOrderID(latestOrderID);

            DateTime orderDateTime = DateTime.Now;

            decimal totalAmount = CalculateTotalAmount(guna2DataGridView1.DataSource as DataTable);

            // Check if there are any items in the DataGridView
            if (guna2DataGridView1.Rows.Count > 0)
            {
                try
                {


                    foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                    {
                        if (row.Cells["Name"] != null && row.Cells["Name"].Value != null)
                        {
                            string productName = row.Cells["Name"].Value.ToString();
                            int quantity = Convert.ToInt32(row.Cells["Qty"].Value);
                            decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);


                            objBLL2.SaveOrder(orderDateTime, productName, quantity, amount, newOrderID);
                        }
                    }

                   // MessageBox.Show("Order saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving order: {ex.Message}");
                }
                finally
                {

                  
                    DataTable orderItems = guna2DataGridView1.DataSource as DataTable;
               //     decimal totalAmount = CalculateTotalAmount(orderItems);

                    string receipt = GenerateReceipt(newOrderID, orderItems, totalAmount);

                    
                    MessageBox.Show(receipt, "Receipt");

                    
                    string receiptFilePath = "receipt.pdf";
                    SaveReceiptAsPdf(receipt, receiptFilePath);

                    
                    PrintPdf(receiptFilePath);

                    btn_clear_Click(sender, e);


                    oder_Id.Text = newOrderID.ToString();
                }
            }
            else
            {
                MessageBox.Show("No items selected to process.");
            }
        }








    }

}
