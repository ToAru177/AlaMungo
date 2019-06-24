using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlaMungo.Data;

namespace AlaMungo.Customer.Controls
{
    public partial class InvoiceListControl : UserControl
    {
        public InvoiceListControl()
        {
            InitializeComponent();
        }

        public void SetDateSource(List<Buy> buys)
        {
            dgvList.DataSource = buys;
        }
    }
}
