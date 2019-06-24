using AlaMungo.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Customer.Controls
{
    public partial class SellListControl : UserControl
    {
        public SellListControl()
        {
            InitializeComponent();
        }


        public void SetDataSource(List<MetaDataBook> books)
        {
            dgvUsedBook.DataSource = books;
            lblCount.Text = $@"총 {books.Count}건이 검색 되었습니다.";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            dgvUsedBook.DataSource = DB.MetaDataBook.GetAll();
        }
    }
}
