namespace cafe_system
{
    partial class employee
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Emp_Add = new Guna.UI2.WinForms.Guna2Button();
            this.Emp_Serach = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Emp_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Emp_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.Emp_Update = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new cafe_system.Database2DataSet();
            this.employeeTableAdapter = new cafe_system.Database2DataSetTableAdapters.employeeTableAdapter();
            this.TxtEmpID = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtNIC = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtJobRol = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtEmpNam = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPhoNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.Emp_Add);
            this.guna2Panel1.Controls.Add(this.Emp_Serach);
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(991, 106);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Emp_Add
            // 
            this.Emp_Add.BorderRadius = 8;
            this.Emp_Add.CheckedState.Parent = this.Emp_Add;
            this.Emp_Add.CustomImages.Parent = this.Emp_Add;
            this.Emp_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(132)))), ((int)(((byte)(156)))));
            this.Emp_Add.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Emp_Add.ForeColor = System.Drawing.Color.White;
            this.Emp_Add.HoverState.Parent = this.Emp_Add;
            this.Emp_Add.Location = new System.Drawing.Point(619, 30);
            this.Emp_Add.Name = "Emp_Add";
            this.Emp_Add.ShadowDecoration.Parent = this.Emp_Add;
            this.Emp_Add.Size = new System.Drawing.Size(172, 45);
            this.Emp_Add.TabIndex = 2;
            this.Emp_Add.Text = "Add";
            // 
            // Emp_Serach
            // 
            this.Emp_Serach.BorderRadius = 8;
            this.Emp_Serach.CheckedState.Parent = this.Emp_Serach;
            this.Emp_Serach.CustomImages.Parent = this.Emp_Serach;
            this.Emp_Serach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(113)))), ((int)(((byte)(103)))));
            this.Emp_Serach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Emp_Serach.ForeColor = System.Drawing.Color.White;
            this.Emp_Serach.HoverState.Parent = this.Emp_Serach;
            this.Emp_Serach.Location = new System.Drawing.Point(405, 30);
            this.Emp_Serach.Name = "Emp_Serach";
            this.Emp_Serach.ShadowDecoration.Parent = this.Emp_Serach;
            this.Emp_Serach.Size = new System.Drawing.Size(171, 45);
            this.Emp_Serach.TabIndex = 1;
            this.Emp_Serach.Text = "Serach";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 8;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconRight = global::cafe_system.Properties.Resources.search;
            this.guna2TextBox1.Location = new System.Drawing.Point(16, 30);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(350, 55);
            this.guna2TextBox1.TabIndex = 0;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.TxtPhoNo);
            this.guna2Panel3.Controls.Add(this.TxtAdd);
            this.guna2Panel3.Controls.Add(this.TxtEmpNam);
            this.guna2Panel3.Controls.Add(this.TxtJobRol);
            this.guna2Panel3.Controls.Add(this.TxtNIC);
            this.guna2Panel3.Controls.Add(this.TxtEmpID);
            this.guna2Panel3.Controls.Add(this.pictureBox1);
            this.guna2Panel3.Controls.Add(this.Emp_Delete);
            this.guna2Panel3.Controls.Add(this.Emp_Clear);
            this.guna2Panel3.Controls.Add(this.Emp_Update);
            this.guna2Panel3.Controls.Add(this.label7);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Location = new System.Drawing.Point(7, 483);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1709, 433);
            this.guna2Panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox1.Location = new System.Drawing.Point(1156, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 138);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Emp_Delete
            // 
            this.Emp_Delete.BorderRadius = 8;
            this.Emp_Delete.CheckedState.Parent = this.Emp_Delete;
            this.Emp_Delete.CustomImages.Parent = this.Emp_Delete;
            this.Emp_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.Emp_Delete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Emp_Delete.ForeColor = System.Drawing.Color.White;
            this.Emp_Delete.HoverState.Parent = this.Emp_Delete;
            this.Emp_Delete.Location = new System.Drawing.Point(1414, 288);
            this.Emp_Delete.Name = "Emp_Delete";
            this.Emp_Delete.ShadowDecoration.Parent = this.Emp_Delete;
            this.Emp_Delete.Size = new System.Drawing.Size(180, 45);
            this.Emp_Delete.TabIndex = 9;
            this.Emp_Delete.Text = "Delete";
            // 
            // Emp_Clear
            // 
            this.Emp_Clear.BorderRadius = 8;
            this.Emp_Clear.CheckedState.Parent = this.Emp_Clear;
            this.Emp_Clear.CustomImages.Parent = this.Emp_Clear;
            this.Emp_Clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(100)))), ((int)(((byte)(147)))));
            this.Emp_Clear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Emp_Clear.ForeColor = System.Drawing.Color.White;
            this.Emp_Clear.HoverState.Parent = this.Emp_Clear;
            this.Emp_Clear.Location = new System.Drawing.Point(1147, 288);
            this.Emp_Clear.Name = "Emp_Clear";
            this.Emp_Clear.ShadowDecoration.Parent = this.Emp_Clear;
            this.Emp_Clear.Size = new System.Drawing.Size(180, 45);
            this.Emp_Clear.TabIndex = 8;
            this.Emp_Clear.Text = "Clear";
            this.Emp_Clear.Click += new System.EventHandler(this.Emp_Clear_Click);
            // 
            // Emp_Update
            // 
            this.Emp_Update.BorderRadius = 8;
            this.Emp_Update.CheckedState.Parent = this.Emp_Update;
            this.Emp_Update.CustomImages.Parent = this.Emp_Update;
            this.Emp_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.Emp_Update.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Update.ForeColor = System.Drawing.Color.White;
            this.Emp_Update.HoverState.Parent = this.Emp_Update;
            this.Emp_Update.Location = new System.Drawing.Point(890, 288);
            this.Emp_Update.Name = "Emp_Update";
            this.Emp_Update.ShadowDecoration.Parent = this.Emp_Update;
            this.Emp_Update.Size = new System.Drawing.Size(180, 45);
            this.Emp_Update.TabIndex = 7;
            this.Emp_Update.Text = "Update";
            this.Emp_Update.Click += new System.EventHandler(this.Emp_Update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1193, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(485, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Job Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.database2DataSet;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // TxtEmpID
            // 
            this.TxtEmpID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmpID.DefaultText = "";
            this.TxtEmpID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEmpID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEmpID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmpID.DisabledState.Parent = this.TxtEmpID;
            this.TxtEmpID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmpID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmpID.FocusedState.Parent = this.TxtEmpID;
            this.TxtEmpID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmpID.HoverState.Parent = this.TxtEmpID;
            this.TxtEmpID.Location = new System.Drawing.Point(292, 72);
            this.TxtEmpID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmpID.Name = "TxtEmpID";
            this.TxtEmpID.PasswordChar = '\0';
            this.TxtEmpID.PlaceholderText = "";
            this.TxtEmpID.SelectedText = "";
            this.TxtEmpID.ShadowDecoration.Parent = this.TxtEmpID;
            this.TxtEmpID.Size = new System.Drawing.Size(163, 42);
            this.TxtEmpID.TabIndex = 4;
            // 
            // TxtNIC
            // 
            this.TxtNIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNIC.DefaultText = "";
            this.TxtNIC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNIC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNIC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNIC.DisabledState.Parent = this.TxtNIC;
            this.TxtNIC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNIC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNIC.FocusedState.Parent = this.TxtNIC;
            this.TxtNIC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNIC.HoverState.Parent = this.TxtNIC;
            this.TxtNIC.Location = new System.Drawing.Point(292, 157);
            this.TxtNIC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNIC.Name = "TxtNIC";
            this.TxtNIC.PasswordChar = '\0';
            this.TxtNIC.PlaceholderText = "";
            this.TxtNIC.SelectedText = "";
            this.TxtNIC.ShadowDecoration.Parent = this.TxtNIC;
            this.TxtNIC.Size = new System.Drawing.Size(163, 42);
            this.TxtNIC.TabIndex = 11;
            // 
            // TxtJobRol
            // 
            this.TxtJobRol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtJobRol.DefaultText = "";
            this.TxtJobRol.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtJobRol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtJobRol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtJobRol.DisabledState.Parent = this.TxtJobRol;
            this.TxtJobRol.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtJobRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtJobRol.FocusedState.Parent = this.TxtJobRol;
            this.TxtJobRol.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtJobRol.HoverState.Parent = this.TxtJobRol;
            this.TxtJobRol.Location = new System.Drawing.Point(292, 249);
            this.TxtJobRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtJobRol.Name = "TxtJobRol";
            this.TxtJobRol.PasswordChar = '\0';
            this.TxtJobRol.PlaceholderText = "";
            this.TxtJobRol.SelectedText = "";
            this.TxtJobRol.ShadowDecoration.Parent = this.TxtJobRol;
            this.TxtJobRol.Size = new System.Drawing.Size(163, 42);
            this.TxtJobRol.TabIndex = 12;
            // 
            // TxtEmpNam
            // 
            this.TxtEmpNam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmpNam.DefaultText = "";
            this.TxtEmpNam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEmpNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEmpNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmpNam.DisabledState.Parent = this.TxtEmpNam;
            this.TxtEmpNam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmpNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmpNam.FocusedState.Parent = this.TxtEmpNam;
            this.TxtEmpNam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmpNam.HoverState.Parent = this.TxtEmpNam;
            this.TxtEmpNam.Location = new System.Drawing.Point(687, 61);
            this.TxtEmpNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmpNam.Name = "TxtEmpNam";
            this.TxtEmpNam.PasswordChar = '\0';
            this.TxtEmpNam.PlaceholderText = "";
            this.TxtEmpNam.SelectedText = "";
            this.TxtEmpNam.ShadowDecoration.Parent = this.TxtEmpNam;
            this.TxtEmpNam.Size = new System.Drawing.Size(163, 42);
            this.TxtEmpNam.TabIndex = 13;
            // 
            // TxtAdd
            // 
            this.TxtAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAdd.DefaultText = "";
            this.TxtAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAdd.DisabledState.Parent = this.TxtAdd;
            this.TxtAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAdd.FocusedState.Parent = this.TxtAdd;
            this.TxtAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAdd.HoverState.Parent = this.TxtAdd;
            this.TxtAdd.Location = new System.Drawing.Point(687, 157);
            this.TxtAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.PasswordChar = '\0';
            this.TxtAdd.PlaceholderText = "";
            this.TxtAdd.SelectedText = "";
            this.TxtAdd.ShadowDecoration.Parent = this.TxtAdd;
            this.TxtAdd.Size = new System.Drawing.Size(163, 42);
            this.TxtAdd.TabIndex = 14;
            // 
            // TxtPhoNo
            // 
            this.TxtPhoNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPhoNo.DefaultText = "";
            this.TxtPhoNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPhoNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPhoNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPhoNo.DisabledState.Parent = this.TxtPhoNo;
            this.TxtPhoNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPhoNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPhoNo.FocusedState.Parent = this.TxtPhoNo;
            this.TxtPhoNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPhoNo.HoverState.Parent = this.TxtPhoNo;
            this.TxtPhoNo.Location = new System.Drawing.Point(687, 249);
            this.TxtPhoNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPhoNo.Name = "TxtPhoNo";
            this.TxtPhoNo.PasswordChar = '\0';
            this.TxtPhoNo.PlaceholderText = "";
            this.TxtPhoNo.SelectedText = "";
            this.TxtPhoNo.ShadowDecoration.Parent = this.TxtPhoNo;
            this.TxtPhoNo.Size = new System.Drawing.Size(163, 42);
            this.TxtPhoNo.TabIndex = 15;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "employee";
            this.Size = new System.Drawing.Size(1719, 942);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button Emp_Serach;
        private Guna.UI2.WinForms.Guna2Button Emp_Add;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button Emp_Delete;
        private Guna.UI2.WinForms.Guna2Button Emp_Clear;
        private Guna.UI2.WinForms.Guna2Button Emp_Update;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database2DataSet database2DataSet;
        private Database2DataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox TxtPhoNo;
        private Guna.UI2.WinForms.Guna2TextBox TxtAdd;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmpNam;
        private Guna.UI2.WinForms.Guna2TextBox TxtJobRol;
        private Guna.UI2.WinForms.Guna2TextBox TxtNIC;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmpID;
    }
}
