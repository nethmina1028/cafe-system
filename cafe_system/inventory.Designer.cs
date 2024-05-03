namespace cafe_system
{
    partial class inventory
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Inven_btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.Inven_btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.Inven_btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.Inven_btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Inven_btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.Inven_imagebox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.inven_typebox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Inven_stock = new Guna.UI2.WinForms.Guna2TextBox();
            this.inven_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.inven_Pname = new Guna.UI2.WinForms.Guna2TextBox();
            this.inven_pId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.inven_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Inven_btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inven_dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._cafe_systemDataSet1 = new cafe_system._cafe_systemDataSet1();
            this.inventoryTableAdapter = new cafe_system._cafe_systemDataSet1TableAdapters.inventoryTableAdapter();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inven_imagebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inven_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cafe_systemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Inven_btnDelete
            // 
            this.Inven_btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Inven_btnDelete.BorderRadius = 5;
            this.Inven_btnDelete.CheckedState.Parent = this.Inven_btnDelete;
            this.Inven_btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inven_btnDelete.CustomImages.Parent = this.Inven_btnDelete;
            this.Inven_btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.Inven_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inven_btnDelete.ForeColor = System.Drawing.Color.White;
            this.Inven_btnDelete.HoverState.Parent = this.Inven_btnDelete;
            this.Inven_btnDelete.Location = new System.Drawing.Point(1068, 5);
            this.Inven_btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inven_btnDelete.Name = "Inven_btnDelete";
            this.Inven_btnDelete.ShadowDecoration.Parent = this.Inven_btnDelete;
            this.Inven_btnDelete.Size = new System.Drawing.Size(163, 47);
            this.Inven_btnDelete.TabIndex = 15;
            this.Inven_btnDelete.Text = "Delete";
            this.Inven_btnDelete.Click += new System.EventHandler(this.Inven_btnDelete_Click);
            // 
            // Inven_btnClear
            // 
            this.Inven_btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Inven_btnClear.BorderRadius = 5;
            this.Inven_btnClear.CheckedState.Parent = this.Inven_btnClear;
            this.Inven_btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inven_btnClear.CustomImages.Parent = this.Inven_btnClear;
            this.Inven_btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(100)))), ((int)(((byte)(147)))));
            this.Inven_btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inven_btnClear.ForeColor = System.Drawing.Color.White;
            this.Inven_btnClear.HoverState.Parent = this.Inven_btnClear;
            this.Inven_btnClear.Location = new System.Drawing.Point(891, 5);
            this.Inven_btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inven_btnClear.Name = "Inven_btnClear";
            this.Inven_btnClear.ShadowDecoration.Parent = this.Inven_btnClear;
            this.Inven_btnClear.Size = new System.Drawing.Size(163, 47);
            this.Inven_btnClear.TabIndex = 14;
            this.Inven_btnClear.Text = "Clear";
            this.Inven_btnClear.Click += new System.EventHandler(this.Inven_btnClear_Click);
            // 
            // Inven_btnUpdate
            // 
            this.Inven_btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Inven_btnUpdate.BorderRadius = 5;
            this.Inven_btnUpdate.CheckedState.Parent = this.Inven_btnUpdate;
            this.Inven_btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inven_btnUpdate.CustomImages.Parent = this.Inven_btnUpdate;
            this.Inven_btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.Inven_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inven_btnUpdate.ForeColor = System.Drawing.Color.White;
            this.Inven_btnUpdate.HoverState.Parent = this.Inven_btnUpdate;
            this.Inven_btnUpdate.Location = new System.Drawing.Point(715, 5);
            this.Inven_btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inven_btnUpdate.Name = "Inven_btnUpdate";
            this.Inven_btnUpdate.ShadowDecoration.Parent = this.Inven_btnUpdate;
            this.Inven_btnUpdate.Size = new System.Drawing.Size(163, 47);
            this.Inven_btnUpdate.TabIndex = 13;
            this.Inven_btnUpdate.Text = "Update";
            this.Inven_btnUpdate.Click += new System.EventHandler(this.Inven_btnUpdate_Click);
            // 
            // Inven_btnAdd
            // 
            this.Inven_btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Inven_btnAdd.BorderRadius = 5;
            this.Inven_btnAdd.CheckedState.Parent = this.Inven_btnAdd;
            this.Inven_btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inven_btnAdd.CustomImages.Parent = this.Inven_btnAdd;
            this.Inven_btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(132)))), ((int)(((byte)(156)))));
            this.Inven_btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inven_btnAdd.ForeColor = System.Drawing.Color.White;
            this.Inven_btnAdd.HoverState.Parent = this.Inven_btnAdd;
            this.Inven_btnAdd.Location = new System.Drawing.Point(539, 5);
            this.Inven_btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inven_btnAdd.Name = "Inven_btnAdd";
            this.Inven_btnAdd.ShadowDecoration.Parent = this.Inven_btnAdd;
            this.Inven_btnAdd.Size = new System.Drawing.Size(163, 47);
            this.Inven_btnAdd.TabIndex = 12;
            this.Inven_btnAdd.Text = "Add";
            this.Inven_btnAdd.Click += new System.EventHandler(this.Inven_btnAdd_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel4.Controls.Add(this.Inven_btnDelete);
            this.guna2Panel4.Controls.Add(this.Inven_btnClear);
            this.guna2Panel4.Controls.Add(this.Inven_btnUpdate);
            this.guna2Panel4.Controls.Add(this.Inven_btnAdd);
            this.guna2Panel4.Location = new System.Drawing.Point(4, 853);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(1711, 85);
            this.guna2Panel4.TabIndex = 10;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel2.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel2.Controls.Add(this.Inven_btnUpload);
            this.guna2Panel2.Controls.Add(this.Inven_imagebox);
            this.guna2Panel2.Controls.Add(this.inven_typebox);
            this.guna2Panel2.Controls.Add(this.Inven_stock);
            this.guna2Panel2.Controls.Add(this.inven_price);
            this.guna2Panel2.Controls.Add(this.inven_Pname);
            this.guna2Panel2.Controls.Add(this.inven_pId);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(20, 598);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1695, 252);
            this.guna2Panel2.TabIndex = 9;
            // 
            // Inven_btnUpload
            // 
            this.Inven_btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Inven_btnUpload.CheckedState.Parent = this.Inven_btnUpload;
            this.Inven_btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inven_btnUpload.CustomImages.Parent = this.Inven_btnUpload;
            this.Inven_btnUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Inven_btnUpload.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inven_btnUpload.ForeColor = System.Drawing.Color.White;
            this.Inven_btnUpload.HoverState.Parent = this.Inven_btnUpload;
            this.Inven_btnUpload.Location = new System.Drawing.Point(1155, 185);
            this.Inven_btnUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inven_btnUpload.Name = "Inven_btnUpload";
            this.Inven_btnUpload.ShadowDecoration.Parent = this.Inven_btnUpload;
            this.Inven_btnUpload.Size = new System.Drawing.Size(229, 25);
            this.Inven_btnUpload.TabIndex = 11;
            this.Inven_btnUpload.Text = "Upload";
            this.Inven_btnUpload.Click += new System.EventHandler(this.Inven_btnUpload_Click);
            // 
            // Inven_imagebox
            // 
            this.Inven_imagebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Inven_imagebox.Image = ((System.Drawing.Image)(resources.GetObject("Inven_imagebox.Image")));
            this.Inven_imagebox.Location = new System.Drawing.Point(1155, 14);
            this.Inven_imagebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inven_imagebox.Name = "Inven_imagebox";
            this.Inven_imagebox.ShadowDecoration.Parent = this.Inven_imagebox;
            this.Inven_imagebox.Size = new System.Drawing.Size(229, 169);
            this.Inven_imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Inven_imagebox.TabIndex = 10;
            this.Inven_imagebox.TabStop = false;
            this.Inven_imagebox.Click += new System.EventHandler(this.Inven_imagebox_Click);
            // 
            // inven_typebox
            // 
            this.inven_typebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inven_typebox.BackColor = System.Drawing.Color.Transparent;
            this.inven_typebox.BorderColor = System.Drawing.Color.Transparent;
            this.inven_typebox.BorderThickness = 0;
            this.inven_typebox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.inven_typebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inven_typebox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.inven_typebox.FocusedColor = System.Drawing.Color.Empty;
            this.inven_typebox.FocusedState.Parent = this.inven_typebox;
            this.inven_typebox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inven_typebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.inven_typebox.FormattingEnabled = true;
            this.inven_typebox.HoverState.Parent = this.inven_typebox;
            this.inven_typebox.ItemHeight = 30;
            this.inven_typebox.ItemsAppearance.Parent = this.inven_typebox;
            this.inven_typebox.Location = new System.Drawing.Point(316, 174);
            this.inven_typebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inven_typebox.Name = "inven_typebox";
            this.inven_typebox.ShadowDecoration.Parent = this.inven_typebox;
            this.inven_typebox.Size = new System.Drawing.Size(261, 36);
            this.inven_typebox.TabIndex = 9;
            // 
            // Inven_stock
            // 
            this.Inven_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Inven_stock.BorderColor = System.Drawing.Color.Transparent;
            this.Inven_stock.BorderThickness = 0;
            this.Inven_stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Inven_stock.DefaultText = "";
            this.Inven_stock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Inven_stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Inven_stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Inven_stock.DisabledState.Parent = this.Inven_stock;
            this.Inven_stock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Inven_stock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Inven_stock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Inven_stock.FocusedState.Parent = this.Inven_stock;
            this.Inven_stock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Inven_stock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Inven_stock.HoverState.Parent = this.Inven_stock;
            this.Inven_stock.Location = new System.Drawing.Point(751, 105);
            this.Inven_stock.Margin = new System.Windows.Forms.Padding(49, 44, 49, 44);
            this.Inven_stock.Name = "Inven_stock";
            this.Inven_stock.PasswordChar = '\0';
            this.Inven_stock.PlaceholderText = "";
            this.Inven_stock.SelectedText = "";
            this.Inven_stock.ShadowDecoration.Parent = this.Inven_stock;
            this.Inven_stock.Size = new System.Drawing.Size(261, 46);
            this.Inven_stock.TabIndex = 8;
            // 
            // inven_price
            // 
            this.inven_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inven_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.inven_price.BorderColor = System.Drawing.Color.Black;
            this.inven_price.BorderThickness = 0;
            this.inven_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inven_price.DefaultText = "";
            this.inven_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inven_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inven_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inven_price.DisabledState.Parent = this.inven_price;
            this.inven_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inven_price.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.inven_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inven_price.FocusedState.Parent = this.inven_price;
            this.inven_price.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inven_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inven_price.HoverState.Parent = this.inven_price;
            this.inven_price.Location = new System.Drawing.Point(751, 28);
            this.inven_price.Margin = new System.Windows.Forms.Padding(49, 44, 49, 44);
            this.inven_price.Name = "inven_price";
            this.inven_price.PasswordChar = '\0';
            this.inven_price.PlaceholderText = "";
            this.inven_price.SelectedText = "";
            this.inven_price.ShadowDecoration.Parent = this.inven_price;
            this.inven_price.Size = new System.Drawing.Size(261, 46);
            this.inven_price.TabIndex = 7;
            // 
            // inven_Pname
            // 
            this.inven_Pname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inven_Pname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.inven_Pname.BorderColor = System.Drawing.Color.Black;
            this.inven_Pname.BorderThickness = 0;
            this.inven_Pname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inven_Pname.DefaultText = "";
            this.inven_Pname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inven_Pname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inven_Pname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inven_Pname.DisabledState.Parent = this.inven_Pname;
            this.inven_Pname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inven_Pname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.inven_Pname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inven_Pname.FocusedState.Parent = this.inven_Pname;
            this.inven_Pname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inven_Pname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inven_Pname.HoverState.Parent = this.inven_Pname;
            this.inven_Pname.Location = new System.Drawing.Point(317, 105);
            this.inven_Pname.Margin = new System.Windows.Forms.Padding(21, 20, 21, 20);
            this.inven_Pname.Name = "inven_Pname";
            this.inven_Pname.PasswordChar = '\0';
            this.inven_Pname.PlaceholderText = "";
            this.inven_Pname.SelectedText = "";
            this.inven_Pname.ShadowDecoration.Parent = this.inven_Pname;
            this.inven_Pname.Size = new System.Drawing.Size(261, 46);
            this.inven_Pname.TabIndex = 6;
            // 
            // inven_pId
            // 
            this.inven_pId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inven_pId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.inven_pId.BorderColor = System.Drawing.Color.Black;
            this.inven_pId.BorderThickness = 0;
            this.inven_pId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inven_pId.DefaultText = "";
            this.inven_pId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inven_pId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inven_pId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inven_pId.DisabledState.Parent = this.inven_pId;
            this.inven_pId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inven_pId.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.inven_pId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inven_pId.FocusedState.Parent = this.inven_pId;
            this.inven_pId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inven_pId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inven_pId.HoverState.Parent = this.inven_pId;
            this.inven_pId.Location = new System.Drawing.Point(316, 28);
            this.inven_pId.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.inven_pId.Name = "inven_pId";
            this.inven_pId.PasswordChar = '\0';
            this.inven_pId.PlaceholderText = "";
            this.inven_pId.SelectedText = "";
            this.inven_pId.ShadowDecoration.Parent = this.inven_pId;
            this.inven_pId.Size = new System.Drawing.Size(261, 46);
            this.inven_pId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(659, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(659, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(216, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(125, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(164, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(305, 39);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // inven_search
            // 
            this.inven_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.inven_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.inven_search.BorderRadius = 8;
            this.inven_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inven_search.DefaultText = "";
            this.inven_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inven_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inven_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inven_search.DisabledState.Parent = this.inven_search;
            this.inven_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inven_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.inven_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inven_search.FocusedState.Parent = this.inven_search;
            this.inven_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inven_search.HoverState.Parent = this.inven_search;
            this.inven_search.Location = new System.Drawing.Point(20, 28);
            this.inven_search.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.inven_search.Name = "inven_search";
            this.inven_search.PasswordChar = '\0';
            this.inven_search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(146)))), ((int)(((byte)(142)))));
            this.inven_search.PlaceholderText = "Search using Product ID";
            this.inven_search.SelectedText = "";
            this.inven_search.ShadowDecoration.Parent = this.inven_search;
            this.inven_search.Size = new System.Drawing.Size(331, 47);
            this.inven_search.TabIndex = 0;
            this.inven_search.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.Controls.Add(this.Inven_btnSearch);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.inven_search);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1719, 106);
            this.guna2Panel1.TabIndex = 7;
            // 
            // Inven_btnSearch
            // 
            this.Inven_btnSearch.BorderRadius = 5;
            this.Inven_btnSearch.CheckedState.Parent = this.Inven_btnSearch;
            this.Inven_btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inven_btnSearch.CustomImages.Parent = this.Inven_btnSearch;
            this.Inven_btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(113)))), ((int)(((byte)(103)))));
            this.Inven_btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inven_btnSearch.ForeColor = System.Drawing.Color.White;
            this.Inven_btnSearch.HoverState.Parent = this.Inven_btnSearch;
            this.Inven_btnSearch.Location = new System.Drawing.Point(393, 28);
            this.Inven_btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inven_btnSearch.Name = "Inven_btnSearch";
            this.Inven_btnSearch.ShadowDecoration.Parent = this.Inven_btnSearch;
            this.Inven_btnSearch.Size = new System.Drawing.Size(140, 47);
            this.Inven_btnSearch.TabIndex = 3;
            this.Inven_btnSearch.Text = "Search";
            this.Inven_btnSearch.Click += new System.EventHandler(this.Inven_btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.inven_dataGrid);
            this.panel1.Location = new System.Drawing.Point(0, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1719, 379);
            this.panel1.TabIndex = 8;
            // 
            // inven_dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.inven_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.inven_dataGrid.AutoGenerateColumns = false;
            this.inven_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inven_dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.inven_dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inven_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.inven_dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(72)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inven_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.inven_dataGrid.ColumnHeadersHeight = 50;
            this.inven_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.inven_dataGrid.DataSource = this.inventoryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inven_dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.inven_dataGrid.EnableHeadersVisualStyles = false;
            this.inven_dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.inven_dataGrid.Location = new System.Drawing.Point(20, 25);
            this.inven_dataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inven_dataGrid.Name = "inven_dataGrid";
            this.inven_dataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inven_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.inven_dataGrid.RowHeadersVisible = false;
            this.inven_dataGrid.RowHeadersWidth = 51;
            this.inven_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inven_dataGrid.Size = new System.Drawing.Size(1384, 329);
            this.inven_dataGrid.TabIndex = 0;
            this.inven_dataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.inven_dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.inven_dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.inven_dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.inven_dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.inven_dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.inven_dataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.inven_dataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.inven_dataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.inven_dataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.inven_dataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.inven_dataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.inven_dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.inven_dataGrid.ThemeStyle.HeaderStyle.Height = 50;
            this.inven_dataGrid.ThemeStyle.ReadOnly = true;
            this.inven_dataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.inven_dataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.inven_dataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.inven_dataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.inven_dataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.inven_dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.inven_dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this._cafe_systemDataSet1;
            // 
            // _cafe_systemDataSet1
            // 
            this._cafe_systemDataSet1.DataSetName = "_cafe_systemDataSet1";
            this._cafe_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "inventory";
            this.Size = new System.Drawing.Size(1719, 942);
            this.Load += new System.EventHandler(this.inventory_Load);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inven_imagebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inven_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cafe_systemDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Inven_btnDelete;
        private Guna.UI2.WinForms.Guna2Button Inven_btnClear;
        private Guna.UI2.WinForms.Guna2Button Inven_btnUpdate;
        private Guna.UI2.WinForms.Guna2Button Inven_btnAdd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button Inven_btnUpload;
        private Guna.UI2.WinForms.Guna2PictureBox Inven_imagebox;
        private Guna.UI2.WinForms.Guna2ComboBox inven_typebox;
        private Guna.UI2.WinForms.Guna2TextBox Inven_stock;
        private Guna.UI2.WinForms.Guna2TextBox inven_price;
        private Guna.UI2.WinForms.Guna2TextBox inven_Pname;
        private Guna.UI2.WinForms.Guna2TextBox inven_pId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox inven_search;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button Inven_btnSearch;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView inven_dataGrid;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private _cafe_systemDataSet1 _cafe_systemDataSet1;
        private _cafe_systemDataSet1TableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}
