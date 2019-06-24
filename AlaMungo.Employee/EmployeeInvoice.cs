using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlaMungo.Employee
{
    public partial class EmployeeInvoice : Form
    {
        public EmployeeInvoice()
        {
            InitializeComponent();
        }

        private void EmployeeInvoice_Load(object sender, EventArgs e)
        {
            bdsInvoice.DataSource = Data.DB.Buy;

        }
    }
}
