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
        private string _cusId;

        public InvoiceForm()
        {
            InitializeComponent();
        }
        public InvoiceForm(string customerId)
        {
            InitializeComponent();
            _cusId = customerId;
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.InvoiceSearchControl.SearchButtonClickedEventArgs e)
        {
           List<Buy> buys = DB.Buy.Search(_cusId,e.Title, e.FromDate, e.ToDate);
           uscList.SetDateSource(buys);
        }
    }
}
