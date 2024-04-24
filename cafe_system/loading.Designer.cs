namespace cafe_system
{
    partial class loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.longbar = new Guna.UI2.WinForms.Guna2Panel();
            this.smallbar = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.close = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel2.SuspendLayout();
            this.longbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(358, 420);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(69)))), ((int)(((byte)(50)))));
            this.guna2Panel2.Controls.Add(this.longbar);
            this.guna2Panel2.Controls.Add(this.lbl_loading);
            this.guna2Panel2.Controls.Add(this.close);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(358, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(382, 420);
            this.guna2Panel2.TabIndex = 2;
            // 
            // longbar
            // 
            this.longbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.longbar.Controls.Add(this.smallbar);
            this.longbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longbar.Location = new System.Drawing.Point(0, 405);
            this.longbar.Name = "longbar";
            this.longbar.ShadowDecoration.Parent = this.longbar;
            this.longbar.Size = new System.Drawing.Size(382, 15);
            this.longbar.TabIndex = 2;
            // 
            // smallbar
            // 
            this.smallbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.smallbar.Location = new System.Drawing.Point(0, 0);
            this.smallbar.Name = "smallbar";
            this.smallbar.ShadowDecoration.Parent = this.smallbar;
            this.smallbar.Size = new System.Drawing.Size(120, 15);
            this.smallbar.TabIndex = 0;
            // 
            // lbl_loading
            // 
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.ForeColor = System.Drawing.Color.White;
            this.lbl_loading.Location = new System.Drawing.Point(6, 381);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(84, 20);
            this.lbl_loading.TabIndex = 1;
            this.lbl_loading.Text = "LOADING....";
            // 
            // close
            // 
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Location = new System.Drawing.Point(339, 12);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(31, 32);
            this.close.TabIndex = 0;
            this.close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 420);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "loading";
            this.Text = "loading";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.longbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel close;
        private System.Windows.Forms.Label lbl_loading;
        private Guna.UI2.WinForms.Guna2Panel longbar;
        private Guna.UI2.WinForms.Guna2Panel smallbar;
        private System.Windows.Forms.Timer timer1;
    }
}