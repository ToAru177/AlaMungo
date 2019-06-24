using AlaMungo.Customer.Properties;
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

namespace AlaMungo.Customer.Forms
{
    public partial class OrderSheet : Form
    {
        public OrderSheet(UsedBook usedBook)
        {
            InitializeComponent(); _usedBook = usedBook;
            Icon = Resources.Purchase1;
        }

        private UsedBook _usedBook;

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderSheet_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _usedBook.BookTitle;
            lblPrice.Text = _usedBook.BookPrice.ToString() + "\\";
            lblTotalPrice.Text = _usedBook.BookPrice.ToString() + "\\";
        }

        private void ReadFromEntity()
        {
            lblTitle.Text = _usedBook.BookTitle;
            lblPrice.Text = _usedBook.BookPrice.ToString() + "\\";
            lblTotalPrice.Text = _usedBook.BookPrice.ToString() + "\\";
        }

        private void WriterToEntity()
        {
            _buy.Address = txbAddress.Text;
            _buy.SubAddress = txbSubAddress.Text;
            _buy.OrderDate = DateTime.Now;
            _buy.InvoiceState = 0;
            _buy.BuyID = 2;
            _buy.BuyerID = 1;

            //_usedBook.IsSell = true;
        }

        private Buy _buy = new Buy();

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            WriterToEntity();
            //if(_buy.BuyID == 0)
                DB.Buy.Insert(_buy);
            //else
            //    DB.Buy.Update(_buy);

            //DB.UsedBook.Update(_usedBook);

            Close();
        }
    }
}
