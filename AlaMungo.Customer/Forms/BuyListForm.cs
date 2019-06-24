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

namespace AlaMungo.Customer
{
    public partial class BuyListForm : Form
    {
        public BuyListForm()
        {
            InitializeComponent();
        }

        private void BuyListForm_Load(object sender, EventArgs e)
        {
            //uscSearch.LoadQualitys();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.BuySearchControl.SearchButtonClickedEventArgs e)
        {
            var usedBooks = DB.UsedBook.Search(e.Title, e.Writer, e.Quality);
            uscList.SetDataSource(usedBooks);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
