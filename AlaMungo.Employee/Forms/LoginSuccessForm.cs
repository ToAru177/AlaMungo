using AlaMungo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlaMungo.Employee.Forms
{
    public partial class LoginSuccessForm : Form
    {
        public LoginSuccessForm()
        {
            InitializeComponent();
        }

        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {
            var buy = DB.Buy.GetAll().Where(x => x.InvoiceState == 0);
            var usedBook = DB.UsedBook.GetAll();
            var sell = DB.Sell.GetAll().Where(x => x.Checked == false);
            var customer = DB.Customer.GetAll();

            lblCustomerCount.Text = $"{customer.Count} 명";
            lblUsedBookCount.Text = $"{usedBook.Count} 권";
            lblSellCount.Text = $"{sell.Count()} 건";
            lblBuyCount.Text = $"{buy.Count()} 건";
        }

        private void TsbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
