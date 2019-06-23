using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlaMungo.Data;

namespace AlaMungo.Employee.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string pw = txbPassword.Text;

            if (DB.Employee.Check(id, pw))
            {
                EmployeeMainForm employeeMain = new EmployeeMainForm();
                employeeMain.FormClosed += new FormClosedEventHandler(EmployeeMainFormClosed);
                employeeMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ID 및 비밀번호가 맞지 않습니다.", "알림");
            }

        }

        private void EmployeeMainFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
