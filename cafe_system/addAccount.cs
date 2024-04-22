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
    public partial class addAccount : Form
    {
        public addAccount()
        {
            InitializeComponent();
        }

        private void txt_empID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdAcoountBtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
