using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlaMungo.Customer.Controls
{
    public partial class BuySearchControl : UserControl
    {
        public BuySearchControl()
        {
            InitializeComponent();
            cbbQuality.Items.Add("A");
            cbbQuality.Items.Add("B");
            cbbQuality.Items.Add("C");
            cbbQuality.Items.Add("F");
        }

        private void ChbTitle_CheckedChanged(object sender, EventArgs e)
        {
            txbTitle.Enabled = chbTitle.Checked;
        }

        private void ChbWriter_CheckedChanged(object sender, EventArgs e)
        {
            txbWriter.Enabled = chbWriter.Checked;
        }

        private void ChbQuality_CheckedChanged(object sender, EventArgs e)
        {
            cbbQuality.Enabled = chbQuality.Checked;
        }

        public void LoadQualitys()
        {
            //bdsQuality.DataSource = DB.Quality.GetAll();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string title = txbTitle.Text;
            string writer = txbWriter.Text;
            //int qualityId = cbbQuality

            int? qualityId = cbbQuality.Enabled ?
                (int?)cbbQuality.SelectedValue : null;

            OnSearchButtonClicked(title, writer, qualityId);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string title, string writer, int? qualityId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(title, writer, qualityId);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public string Title { get; set; }
            public string Writer { get; set; }
            public int? QualityId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string title, string writer, int? qualityId)
            {
                Title = title;
                Writer = writer;
                QualityId = qualityId;
            }
        }
        #endregion
    }
}
