using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlaMungo.Customer.Controls;
using AlaMungo.Data;

namespace AlaMungo.Customer.Forms
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.InvoiceSearchControl.SearchButtonClickedEventArgs e)
        {
           List<Buy> buys = DB.Buy.Search(e.Title, e.FromDate, e.ToDate);
           uscList.SetDateSource(buys);
        }
    }
}
