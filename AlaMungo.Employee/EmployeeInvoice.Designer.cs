namespace AlaMungo.Employee
{
    partial class EmployeeInvoice
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EmployeeInvoiceGrid = new System.Windows.Forms.DataGridView();
            this.bdsInvoice = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceSearchControl1 = new AlaMungo.Employee.Controls.InvoiceSearchControl();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeInvoiceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeInvoiceGrid
            // 
            this.EmployeeInvoiceGrid.AllowUserToAddRows = false;
            this.EmployeeInvoiceGrid.AllowUserToDeleteRows = false;
            this.EmployeeInvoiceGrid.AllowUserToResizeColumns = false;
            this.EmployeeInvoiceGrid.AllowUserToResizeRows = false;
            this.EmployeeInvoiceGrid.AutoGenerateColumns = false;
            this.EmployeeInvoiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeInvoiceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.BuyerID,
            this.UsedBooks,
            this.OrderDate,
            this.InvoiceState});
            this.EmployeeInvoiceGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeeInvoiceGrid.DataSource = this.bdsInvoice;
            this.EmployeeInvoiceGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeInvoiceGrid.Location = new System.Drawing.Point(0, 90);
            this.EmployeeInvoiceGrid.Name = "EmployeeInvoiceGrid";
            this.EmployeeInvoiceGrid.ReadOnly = true;
            this.EmployeeInvoiceGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.EmployeeInvoiceGrid.RowTemplate.Height = 23;
            this.EmployeeInvoiceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EmployeeInvoiceGrid.Size = new System.Drawing.Size(800, 360);
            this.EmployeeInvoiceGrid.StandardTab = true;
            this.EmployeeInvoiceGrid.TabIndex = 1;
            // 
            // bdsInvoice
            // 
            this.bdsInvoice.DataSource = typeof(AlaMungo.Data.Buy);
            // 
            // invoiceSearchControl1
            // 
            this.invoiceSearchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.invoiceSearchControl1.Location = new System.Drawing.Point(0, 0);
            this.invoiceSearchControl1.Name = "invoiceSearchControl1";
            this.invoiceSearchControl1.Size = new System.Drawing.Size(800, 90);
            this.invoiceSearchControl1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BuyID";
            this.Column1.HeaderText = "배송 ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "구매 일자";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // InvoiceState
            // 
            this.InvoiceState.DataPropertyName = "InvoiceState";
            this.InvoiceState.HeaderText = "배송 상태";
            this.InvoiceState.Name = "InvoiceState";
            this.InvoiceState.ReadOnly = true;
            // 
            // EmployeeInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeInvoiceGrid);
            this.Controls.Add(this.invoiceSearchControl1);
            this.Name = "EmployeeInvoice";
            this.Text = "배송관리";
            this.Load += new System.EventHandler(this.EmployeeInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeInvoiceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.InvoiceSearchControl invoiceSearchControl1;
        private System.Windows.Forms.DataGridView EmployeeInvoiceGrid;
        private System.Windows.Forms.BindingSource bdsInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceState;
    }
}