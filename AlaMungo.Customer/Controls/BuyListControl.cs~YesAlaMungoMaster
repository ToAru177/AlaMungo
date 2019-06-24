using AlaMungo.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Customer.Controls
{
    public partial class BuyListControl : UserControl
    {
        public BuyListControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<UsedBook> usedBooks)
        {
            bdsUsedBook.DataSource = usedBooks;
            lblCount.Text = $"총 {usedBooks.Count} 건 입니다.";
        }
    }
}
