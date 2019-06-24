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
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
        }

        private void uscSearch_SearchButtonClicked(object sender, Controls.SellSearchControl.SearchButtonClickedEventArgs e)
        {
            List<MetaDataBook> metaDataBooks = DB.MetaDataBook.Search(e.Title, e.Writer, e.Publisher);

            uscList.SetDataSource(metaDataBooks);
        }
    }
}
