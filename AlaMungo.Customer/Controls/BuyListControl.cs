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
    public partial class BuyListControl : UserControl
    {
        public BuyListControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Buy> buys)
        {
            bdsBuy.DataSource = buys;
            lblCount.Text = $"총 {buys.Count} 건 입니다.";
        }
    }
}
