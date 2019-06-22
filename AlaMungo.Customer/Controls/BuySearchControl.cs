using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlaMungo.Customer.Controls
{
    public partial class BuySearchControl : UserControl
    {
        public BuySearchControl()
        {
            InitializeComponent();
        }

        private void ChbTitle_CheckedChanged(object sender, EventArgs e)
        {
            txbTitle.Enabled = chbTitle.Checked;
        }

        private void ChbWriter_CheckedChanged(object sender, EventArgs e)
        {
            txbWriter.Enabled = chbWriter.Checked;
        }

        private void ChbQuality_CheckedChanged(object sender, EventArgs e)
        {
            cbbQuality.Enabled = chbQuality.Checked;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
