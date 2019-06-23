using AlaMungo.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Customer.Forms
{
    public partial class SignUpForm : Form
    {
        private bool _signUpAble = false;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbId.Text))
            {
                MessageBox.Show("아이디를 입력해주세요.", "알 림");
            }
            else if (DB.Customer.CheckId(txbId.Text))
            {
                MessageBox.Show("중복된 아이디 입니다.", "알 림");
            }
            else
            {
                MessageBox.Show("사용 가능한 아이디 입니다.", "알 림");
                _signUpAble = true;
            };
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (_signUpAble)
            {
                Data.Customer customer = new Data.Customer();
                customer.CustomerID = DB.Customer.GetCount()+1;
                customer.LoginID = txbId.Text;
                customer.PassWord = txbPw.Text;
                customer.Address = txbAddress.Text;
                customer.Email = txbEMail.Text;
                customer.PhoneNumber = txbPhone.Text;
                DB.Customer.Insert(customer);
                this.Close();
            }
            else
            {
                MessageBox.Show("중복체크를 해주세요", "알 림");
            }
        }
    }
}
