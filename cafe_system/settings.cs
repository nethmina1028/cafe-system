using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_system
{
    public partial class settings : UserControl
    {
        internal FormBorderStyle FormBorderStyle;
        public settings()
        {
            InitializeComponent();
        }
        public bool TopLevel { get; internal set; }

        private void btn_addAccount_Click(object sender, EventArgs e)
        {
            
        }

        private void SettBtn_add_Click(object sender, EventArgs e)
        {
            addAccount f1 = new addAccount();
            f1.Show();
            // Visible = false;
        }
    }
}
