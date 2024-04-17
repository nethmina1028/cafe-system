namespace cafe_system
{
    partial class home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.sidepanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_settings = new Guna.UI2.WinForms.Guna2Button();
            this.btn_employee = new Guna.UI2.WinForms.Guna2Button();
            this.btn_reports = new Guna.UI2.WinForms.Guna2Button();
            this.btn_inventory = new Guna.UI2.WinForms.Guna2Button();
            this.btn_menu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_home = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_dateTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_home = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.guna2Panel1.Controls.Add(this.sidepanel);
            this.guna2Panel1.Controls.Add(this.btn_logout);
            this.guna2Panel1.Controls.Add(this.btn_settings);
            this.guna2Panel1.Controls.Add(this.btn_employee);
            this.guna2Panel1.Controls.Add(this.btn_reports);
            this.guna2Panel1.Controls.Add(this.btn_inventory);
            this.guna2Panel1.Controls.Add(this.btn_menu);
            this.guna2Panel1.Controls.Add(this.btn_home);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(251, 687);
            this.guna2Panel1.TabIndex = 0;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.White;
            this.sidepanel.Location = new System.Drawing.Point(0, 144);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.ShadowDecoration.Parent = this.sidepanel;
            this.sidepanel.Size = new System.Drawing.Size(13, 70);
            this.sidepanel.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_logout.CheckedState.Parent = this.btn_logout;
            this.btn_logout.CustomImages.Parent = this.btn_logout;
            this.btn_logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.HoverState.Parent = this.btn_logout;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_logout.ImageOffset = new System.Drawing.Point(30, 0);
            this.btn_logout.ImageSize = new System.Drawing.Size(24, 20);
            this.btn_logout.Location = new System.Drawing.Point(0, 605);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ShadowDecoration.Parent = this.btn_logout;
            this.btn_logout.Size = new System.Drawing.Size(251, 70);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "   Logout";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.CheckedState.Parent = this.btn_settings;
            this.btn_settings.CustomImages.Parent = this.btn_settings;
            this.btn_settings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.HoverState.Parent = this.btn_settings;
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_settings.ImageOffset = new System.Drawing.Point(30, 0);
            this.btn_settings.ImageSize = new System.Drawing.Size(22, 20);
            this.btn_settings.Location = new System.Drawing.Point(0, 524);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.ShadowDecoration.Parent = this.btn_settings;
            this.btn_settings.Size = new System.Drawing.Size(251, 70);
            this.btn_settings.TabIndex = 5;
            this.btn_settings.Text = "    Settings";
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.CheckedState.Parent = this.btn_employee;
            this.btn_employee.CustomImages.Parent = this.btn_employee;
            this.btn_employee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_employee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.HoverState.Parent = this.btn_employee;
            this.btn_employee.Image = ((System.Drawing.Image)(resources.GetObject("btn_employee.Image")));
            this.btn_employee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_employee.ImageOffset = new System.Drawing.Point(30, 0);
            this.btn_employee.ImageSize = new System.Drawing.Size(25, 20);
            this.btn_employee.Location = new System.Drawing.Point(0, 448);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.ShadowDecoration.Parent = this.btn_employee;
            this.btn_employee.Size = new System.Drawing.Size(251, 70);
            this.btn_employee.TabIndex = 4;
            this.btn_employee.Text = "       Employee";
            this.btn_employee.Click += new System.EventHandler(this.btn_empoyee_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.CheckedState.Parent = this.btn_reports;
            this.btn_reports.CustomImages.Parent = this.btn_reports;
            this.btn_reports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_reports.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.White;
            this.btn_reports.HoverState.Parent = this.btn_reports;
            this.btn_reports.Image = ((System.Drawing.Image)(resources.GetObject("btn_reports.Image")));
            this.btn_reports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_reports.ImageOffset = new System.Drawing.Point(30, 0);
            this.btn_reports.Location = new System.Drawing.Point(0, 372);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.ShadowDecoration.Parent = this.btn_reports;
            this.btn_reports.Size = new System.Drawing.Size(251, 70);
            this.btn_reports.TabIndex = 3;
            this.btn_reports.Text = "    Reports";
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.CheckedState.Parent = this.btn_inventory;
            this.btn_inventory.CustomImages.Parent = this.btn_inventory;
            this.btn_inventory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_inventory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventory.ForeColor = System.Drawing.Color.White;
            this.btn_inventory.HoverState.Parent = this.btn_inventory;
            this.btn_inventory.Image = ((System.Drawing.Image)(resources.GetObject("btn_inventory.Image")));
            this.btn_inventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_inventory.ImageOffset = new System.Drawing.Point(30, 0);
            this.btn_inventory.Location = new System.Drawing.Point(0, 296);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.ShadowDecoration.Parent = this.btn_inventory;
            this.btn_inventory.Size = new System.Drawing.Size(251, 70);
            this.btn_inventory.TabIndex = 2;
            this.btn_inventory.Text = "       Inventory";
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.CheckedState.Parent = this.btn_menu;
            this.btn_menu.CustomImages.Parent = this.btn_menu;
            this.btn_menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_menu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.HoverState.Parent = this.btn_menu;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_menu.ImageOffset = new System.Drawing.Point(30, 0);
            this.btn_menu.Location = new System.Drawing.Point(0, 220);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.ShadowDecoration.Parent = this.btn_menu;
            this.btn_menu.Size = new System.Drawing.Size(251, 70);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Text = "Menu";
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_home
            // 
            this.btn_home.CheckedState.Parent = this.btn_home;
            this.btn_home.CustomImages.Parent = this.btn_home;
            this.btn_home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.HoverState.Parent = this.btn_home;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_home.ImageOffset = new System.Drawing.Point(30, 0);
            this.btn_home.ImageSize = new System.Drawing.Size(25, 20);
            this.btn_home.Location = new System.Drawing.Point(0, 144);
            this.btn_home.Name = "btn_home";
            this.btn_home.ShadowDecoration.Parent = this.btn_home;
            this.btn_home.Size = new System.Drawing.Size(251, 70);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(72)))), ((int)(((byte)(61)))));
            this.guna2Panel2.Controls.Add(this.lbl_dateTime);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(251, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(904, 80);
            this.guna2Panel2.TabIndex = 1;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // lbl_dateTime
            // 
            this.lbl_dateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_dateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(72)))), ((int)(((byte)(61)))));
            this.lbl_dateTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateTime.ForeColor = System.Drawing.Color.White;
            this.lbl_dateTime.Location = new System.Drawing.Point(648, 27);
            this.lbl_dateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_dateTime.Name = "lbl_dateTime";
            this.lbl_dateTime.Size = new System.Drawing.Size(3, 2);
            this.lbl_dateTime.TabIndex = 0;
            this.lbl_dateTime.Text = null;
            this.lbl_dateTime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_home
            // 
            this.panel_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_home.Location = new System.Drawing.Point(251, 80);
            this.panel_home.Name = "panel_home";
            this.panel_home.ShadowDecoration.Parent = this.panel_home;
            this.panel_home.Size = new System.Drawing.Size(904, 607);
            this.panel_home.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mug & Muffin Cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.home_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btn_home;
        private Guna.UI2.WinForms.Guna2Panel panel_home;
        private Guna.UI2.WinForms.Guna2Button btn_settings;
        private Guna.UI2.WinForms.Guna2Button btn_employee;
        private Guna.UI2.WinForms.Guna2Button btn_reports;
        private Guna.UI2.WinForms.Guna2Button btn_inventory;
        private Guna.UI2.WinForms.Guna2Button btn_menu;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2HtmlLabel timer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_dateTime;
        private Guna.UI2.WinForms.Guna2Panel sidepanel;
        private System.Windows.Forms.Timer timer1;
    }
}

