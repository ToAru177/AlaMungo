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

namespace AlaMungo.Customer.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string pw = txbPassword.Text;

            if (DB.Customer.Check(id, pw))
            {
                CustomerMainForm customerMain = new CustomerMainForm();
                customerMain.FormClosed += new FormClosedEventHandler(CustomerMainFormClosed);
                customerMain.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ID 및 비밀번호가 맞지 않습니다. \n 다시 입력해주십시오.", "알 림");
            }
        }

        private void CustomerMainFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
        }
    }
}
