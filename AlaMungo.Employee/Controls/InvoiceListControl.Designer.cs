namespace AlaMungo.Employee.Controls
{
    partial class InvoiceListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdsBuy = new System.Windows.Forms.BindingSource(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            this.buyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyIDDataGridViewTextBoxColumn,
            this.BuyerID,
            this.UsedBooks,
            this.orderDateDataGridViewTextBoxColumn,
            this.invoiceStateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdsBuy;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(589, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // bdsBuy
            // 
            this.bdsBuy.DataSource = typeof(AlaMungo.Data.Buy);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCount.Location = new System.Drawing.Point(0, 372);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(29, 12);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "대기";
            // 
            // buyIDDataGridViewTextBoxColumn
            // 
            this.buyIDDataGridViewTextBoxColumn.DataPropertyName = "BuyID";
            this.buyIDDataGridViewTextBoxColumn.HeaderText = "배송번호";
            this.buyIDDataGridViewTextBoxColumn.Name = "buyIDDataGridViewTextBoxColumn";
            this.buyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BuyerID
            // 
            this.BuyerID.DataPropertyName = "BuyerID";
            this.BuyerID.HeaderText = "구매자 ID";
            this.BuyerID.Name = "BuyerID";
            this.BuyerID.ReadOnly = true;
            // 
            // UsedBooks
            // 
            this.UsedBooks.DataPropertyName = "UsedBooks";
            this.UsedBooks.HeaderText = "책 이름";
            this.UsedBooks.Name = "UsedBooks";
            this.UsedBooks.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "구매일자";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceStateDataGridViewTextBoxColumn
            // 
            this.invoiceStateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceState";
            this.invoiceStateDataGridViewTextBoxColumn.HeaderText = "배송상태";
            this.invoiceStateDataGridViewTextBoxColumn.Name = "invoiceStateDataGridViewTextBoxColumn";
            this.invoiceStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InvoiceListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InvoiceListControl";
            this.Size = new System.Drawing.Size(589, 384);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bdsBuy;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceStateDataGridViewTextBoxColumn;
    }
}
