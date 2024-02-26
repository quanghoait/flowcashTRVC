using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flowcashTRVC
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void btnCode_Click(object sender, EventArgs e)
        {
           Code code = new Code();
           code.Show();
         }

        private void btnCashBook1_Click(object sender, EventArgs e)
        {
            Cashbook cbook = new Cashbook();
            cbook.Show();
        }
    }
}
