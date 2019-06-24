﻿using AlaMungo.Data;
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
    public partial class UsedBookForm : Form
    {
        public UsedBookForm(UsedBook usedBook)
        {
            InitializeComponent();

            _usedBook = usedBook;
        }

        private UsedBook _usedBook;

        private void UsedBookForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _usedBook.BookTitle;
            lblWriter.Text = _usedBook.BookWriter;
            lblPrice.Text = _usedBook.BookPrice.ToString() + "\\";
            lblQuality.Text = _usedBook.Quality;
            //lblCount.Text = $"{} 권";

            //pcbBookImage.Image = Image.FromFile(_usedBook.ImagePath);
            pcbBookImage.Image = Image.FromFile(@"D:\MetaBookImage\다시_태어난다면_한국에서_살겠습니까.PNG");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            UsedBook usedBook = _usedBook;

            OrderSheet form = new OrderSheet(usedBook);

            form.ShowDialog();
            Close();
        }
    }
}
