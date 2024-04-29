namespace cafe_system
{
    partial class product
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.prodName = new System.Windows.Forms.Label();
            this.img = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.prodName);
            this.guna2Panel1.Controls.Add(this.img);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(173, 180);
            this.guna2Panel1.TabIndex = 0;
            // 
            // prodName
            // 
            this.prodName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prodName.AutoSize = true;
            this.prodName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodName.Location = new System.Drawing.Point(41, 140);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(62, 28);
            this.prodName.TabIndex = 1;
            this.prodName.Text = "apple\r\n";
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.SystemColors.Control;
            this.img.BorderRadius = 40;
            this.img.Location = new System.Drawing.Point(-3, -3);
            this.img.Name = "img";
            this.img.ShadowDecoration.Parent = this.img;
            this.img.Size = new System.Drawing.Size(179, 136);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.click_use);
            // 
            // product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "product";
            this.Size = new System.Drawing.Size(179, 186);
            this.Click += new System.EventHandler(this.product_Click);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label prodName;
        public Guna.UI2.WinForms.Guna2PictureBox img;
    }
}
