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
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bttnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cafeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new cafe_system.Database1DataSet();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.bttnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.imagebox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.typebox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtstock = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.bttnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.bttnClear = new Guna.UI2.WinForms.Guna2Button();
            this.bttnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.bttnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.cafeTableAdapter = new cafe_system.Database1DataSetTableAdapters.cafeTableAdapter();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.Parent = this.search;
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.FocusedState.Parent = this.search;
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.HoverState.Parent = this.search;
            this.search.Location = new System.Drawing.Point(15, 31);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(146)))), ((int)(((byte)(142)))));
            this.search.PlaceholderText = "Search using Product ID";
            this.search.SelectedText = "";
            this.search.ShadowDecoration.Parent = this.search;
            this.search.Size = new System.Drawing.Size(375, 58);
            this.search.TabIndex = 0;
            this.search.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(348, 48);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(22, 22);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.bttnSearch);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.search);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1289, 92);
            this.guna2Panel1.TabIndex = 2;
            // 
            // bttnSearch
            // 
            this.bttnSearch.CheckedState.Parent = this.bttnSearch;
            this.bttnSearch.CustomImages.Parent = this.bttnSearch;
            this.bttnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(113)))), ((int)(((byte)(103)))));
            this.bttnSearch.Font = new System.Drawing.Font("Montserrat", 17F);
            this.bttnSearch.ForeColor = System.Drawing.Color.White;
            this.bttnSearch.HoverState.Parent = this.bttnSearch;
            this.bttnSearch.Location = new System.Drawing.Point(419, 42);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.ShadowDecoration.Parent = this.bttnSearch;
            this.bttnSearch.Size = new System.Drawing.Size(138, 47);
            this.bttnSearch.TabIndex = 3;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 236);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 37;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cafeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.dataGridView1.Location = new System.Drawing.Point(15, 14);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1252, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // cafeBindingSource
            // 
            this.cafeBindingSource.DataMember = "cafe";
            this.cafeBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.bttnUpload);
            this.guna2Panel2.Controls.Add(this.imagebox);
            this.guna2Panel2.Controls.Add(this.typebox);
            this.guna2Panel2.Controls.Add(this.txtstock);
            this.guna2Panel2.Controls.Add(this.txtprice);
            this.guna2Panel2.Controls.Add(this.txtpname);
            this.guna2Panel2.Controls.Add(this.txtpid);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(3, 353);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1283, 211);
            this.guna2Panel2.TabIndex = 4;
            // 
            // bttnUpload
            // 
            this.bttnUpload.CheckedState.Parent = this.bttnUpload;
            this.bttnUpload.CustomImages.Parent = this.bttnUpload;
            this.bttnUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnUpload.Font = new System.Drawing.Font("Montserrat", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpload.ForeColor = System.Drawing.Color.White;
            this.bttnUpload.HoverState.Parent = this.bttnUpload;
            this.bttnUpload.Location = new System.Drawing.Point(877, 160);
            this.bttnUpload.Name = "bttnUpload";
            this.bttnUpload.ShadowDecoration.Parent = this.bttnUpload;
            this.bttnUpload.Size = new System.Drawing.Size(138, 47);
            this.bttnUpload.TabIndex = 11;
            this.bttnUpload.Text = "Upload";
            this.bttnUpload.Click += new System.EventHandler(this.bttnUpload_Click);
            // 
            // imagebox
            // 
            this.imagebox.Image = ((System.Drawing.Image)(resources.GetObject("imagebox.Image")));
            this.imagebox.Location = new System.Drawing.Point(857, 0);
            this.imagebox.Name = "imagebox";
            this.imagebox.ShadowDecoration.Parent = this.imagebox;
            this.imagebox.Size = new System.Drawing.Size(173, 154);
            this.imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagebox.TabIndex = 10;
            this.imagebox.TabStop = false;
            this.imagebox.Click += new System.EventHandler(this.imagebox_Click);
            // 
            // typebox
            // 
            this.typebox.BackColor = System.Drawing.Color.Transparent;
            this.typebox.BorderColor = System.Drawing.Color.Transparent;
            this.typebox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typebox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.typebox.FocusedColor = System.Drawing.Color.Empty;
            this.typebox.FocusedState.Parent = this.typebox;
            this.typebox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.typebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.typebox.FormattingEnabled = true;
            this.typebox.HoverState.Parent = this.typebox;
            this.typebox.ItemHeight = 30;
            this.typebox.ItemsAppearance.Parent = this.typebox;
            this.typebox.Location = new System.Drawing.Point(225, 141);
            this.typebox.Name = "typebox";
            this.typebox.ShadowDecoration.Parent = this.typebox;
            this.typebox.Size = new System.Drawing.Size(197, 36);
            this.typebox.TabIndex = 9;
            // 
            // txtstock
            // 
            this.txtstock.BorderColor = System.Drawing.Color.Transparent;
            this.txtstock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstock.DefaultText = "";
            this.txtstock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstock.DisabledState.Parent = this.txtstock;
            this.txtstock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtstock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstock.FocusedState.Parent = this.txtstock;
            this.txtstock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstock.HoverState.Parent = this.txtstock;
            this.txtstock.Location = new System.Drawing.Point(550, 73);
            this.txtstock.Margin = new System.Windows.Forms.Padding(37, 36, 37, 36);
            this.txtstock.Name = "txtstock";
            this.txtstock.PasswordChar = '\0';
            this.txtstock.PlaceholderText = "";
            this.txtstock.SelectedText = "";
            this.txtstock.ShadowDecoration.Parent = this.txtstock;
            this.txtstock.Size = new System.Drawing.Size(196, 49);
            this.txtstock.TabIndex = 8;
            // 
            // txtprice
            // 
            this.txtprice.BorderColor = System.Drawing.Color.Transparent;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.DefaultText = "";
            this.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.DisabledState.Parent = this.txtprice;
            this.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.FocusedState.Parent = this.txtprice;
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.HoverState.Parent = this.txtprice;
            this.txtprice.Location = new System.Drawing.Point(550, 9);
            this.txtprice.Margin = new System.Windows.Forms.Padding(37, 36, 37, 36);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "";
            this.txtprice.SelectedText = "";
            this.txtprice.ShadowDecoration.Parent = this.txtprice;
            this.txtprice.Size = new System.Drawing.Size(196, 49);
            this.txtprice.TabIndex = 7;
            // 
            // txtpname
            // 
            this.txtpname.BorderColor = System.Drawing.Color.Transparent;
            this.txtpname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpname.DefaultText = "";
            this.txtpname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpname.DisabledState.Parent = this.txtpname;
            this.txtpname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtpname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpname.FocusedState.Parent = this.txtpname;
            this.txtpname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpname.HoverState.Parent = this.txtpname;
            this.txtpname.Location = new System.Drawing.Point(226, 73);
            this.txtpname.Margin = new System.Windows.Forms.Padding(16);
            this.txtpname.Name = "txtpname";
            this.txtpname.PasswordChar = '\0';
            this.txtpname.PlaceholderText = "";
            this.txtpname.SelectedText = "";
            this.txtpname.ShadowDecoration.Parent = this.txtpname;
            this.txtpname.Size = new System.Drawing.Size(196, 49);
            this.txtpname.TabIndex = 6;
            // 
            // txtpid
            // 
            this.txtpid.BorderColor = System.Drawing.Color.Transparent;
            this.txtpid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpid.DefaultText = "";
            this.txtpid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpid.DisabledState.Parent = this.txtpid;
            this.txtpid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtpid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpid.FocusedState.Parent = this.txtpid;
            this.txtpid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpid.HoverState.Parent = this.txtpid;
            this.txtpid.Location = new System.Drawing.Point(226, 9);
            this.txtpid.Margin = new System.Windows.Forms.Padding(7);
            this.txtpid.Name = "txtpid";
            this.txtpid.PasswordChar = '\0';
            this.txtpid.PlaceholderText = "";
            this.txtpid.SelectedText = "";
            this.txtpid.ShadowDecoration.Parent = this.txtpid;
            this.txtpid.Size = new System.Drawing.Size(196, 49);
            this.txtpid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.label5.Location = new System.Drawing.Point(456, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.label4.Location = new System.Drawing.Point(456, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.label3.Location = new System.Drawing.Point(137, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(80, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.bttnDelete);
            this.guna2Panel4.Controls.Add(this.bttnClear);
            this.guna2Panel4.Controls.Add(this.bttnUpdate);
            this.guna2Panel4.Controls.Add(this.bttnAdd);
            this.guna2Panel4.Location = new System.Drawing.Point(3, 570);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(1283, 192);
            this.guna2Panel4.TabIndex = 6;
            // 
            // bttnDelete
            // 
            this.bttnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDelete.CheckedState.Parent = this.bttnDelete;
            this.bttnDelete.CustomImages.Parent = this.bttnDelete;
            this.bttnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.bttnDelete.Font = new System.Drawing.Font("Montserrat", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelete.ForeColor = System.Drawing.Color.White;
            this.bttnDelete.HoverState.Parent = this.bttnDelete;
            this.bttnDelete.Location = new System.Drawing.Point(840, 3);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.ShadowDecoration.Parent = this.bttnDelete;
            this.bttnDelete.Size = new System.Drawing.Size(138, 47);
            this.bttnDelete.TabIndex = 15;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnClear.CheckedState.Parent = this.bttnClear;
            this.bttnClear.CustomImages.Parent = this.bttnClear;
            this.bttnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(100)))), ((int)(((byte)(147)))));
            this.bttnClear.Font = new System.Drawing.Font("Montserrat", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClear.ForeColor = System.Drawing.Color.White;
            this.bttnClear.HoverState.Parent = this.bttnClear;
            this.bttnClear.Location = new System.Drawing.Point(682, 3);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.ShadowDecoration.Parent = this.bttnClear;
            this.bttnClear.Size = new System.Drawing.Size(138, 47);
            this.bttnClear.TabIndex = 14;
            this.bttnClear.Text = "Clear";
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnUpdate.CheckedState.Parent = this.bttnUpdate;
            this.bttnUpdate.CustomImages.Parent = this.bttnUpdate;
            this.bttnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.bttnUpdate.Font = new System.Drawing.Font("Montserrat", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdate.ForeColor = System.Drawing.Color.White;
            this.bttnUpdate.HoverState.Parent = this.bttnUpdate;
            this.bttnUpdate.Location = new System.Drawing.Point(517, 3);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.ShadowDecoration.Parent = this.bttnUpdate;
            this.bttnUpdate.Size = new System.Drawing.Size(138, 47);
            this.bttnUpdate.TabIndex = 13;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnAdd.CheckedState.Parent = this.bttnAdd;
            this.bttnAdd.CustomImages.Parent = this.bttnAdd;
            this.bttnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(132)))), ((int)(((byte)(156)))));
            this.bttnAdd.Font = new System.Drawing.Font("Montserrat", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdd.ForeColor = System.Drawing.Color.White;
            this.bttnAdd.HoverState.Parent = this.bttnAdd;
            this.bttnAdd.Location = new System.Drawing.Point(358, 3);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.ShadowDecoration.Parent = this.bttnAdd;
            this.bttnAdd.Size = new System.Drawing.Size(138, 47);
            this.bttnAdd.TabIndex = 12;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // cafeTableAdapter
            // 
            this.cafeTableAdapter.ClearBeforeFill = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product Id";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "inventory";
            this.Size = new System.Drawing.Size(1289, 765);
            this.Load += new System.EventHandler(this.inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox search;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button bttnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtpid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtstock;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private Guna.UI2.WinForms.Guna2TextBox txtpname;
        private Guna.UI2.WinForms.Guna2ComboBox typebox;
        private Guna.UI2.WinForms.Guna2Button bttnUpload;
        private Guna.UI2.WinForms.Guna2PictureBox imagebox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button bttnDelete;
        private Guna.UI2.WinForms.Guna2Button bttnClear;
        private Guna.UI2.WinForms.Guna2Button bttnUpdate;
        private Guna.UI2.WinForms.Guna2Button bttnAdd;
        private System.Windows.Forms.BindingSource cafeBindingSource;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.cafeTableAdapter cafeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}
