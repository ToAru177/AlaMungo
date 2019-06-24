namespace AlaMungo.Customer.Controls
{
    partial class InvoiceListControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.buyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyIDDataGridViewTextBoxColumn,
            this.Title,
            this.buyerIDDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.subAddressDataGridViewTextBoxColumn,
            this.invoiceStateDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.buyBindingSource;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1028, 461);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvList_CellFormatting);
            // 
            // buyBindingSource
            // 
            this.buyBindingSource.DataSource = typeof(AlaMungo.Data.Buy);
            // 
            // buyIDDataGridViewTextBoxColumn
            // 
            this.buyIDDataGridViewTextBoxColumn.DataPropertyName = "BuyID";
            this.buyIDDataGridViewTextBoxColumn.HeaderText = "배송 ID";
            this.buyIDDataGridViewTextBoxColumn.Name = "buyIDDataGridViewTextBoxColumn";
            this.buyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "책 제목";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // buyerIDDataGridViewTextBoxColumn
            // 
            this.buyerIDDataGridViewTextBoxColumn.DataPropertyName = "BuyerID";
            this.buyerIDDataGridViewTextBoxColumn.HeaderText = "구매자 ID";
            this.buyerIDDataGridViewTextBoxColumn.Name = "buyerIDDataGridViewTextBoxColumn";
            this.buyerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subAddressDataGridViewTextBoxColumn
            // 
            this.subAddressDataGridViewTextBoxColumn.DataPropertyName = "SubAddress";
            this.subAddressDataGridViewTextBoxColumn.HeaderText = "SubAddress";
            this.subAddressDataGridViewTextBoxColumn.Name = "subAddressDataGridViewTextBoxColumn";
            this.subAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceStateDataGridViewTextBoxColumn
            // 
            this.invoiceStateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceState";
            this.invoiceStateDataGridViewTextBoxColumn.HeaderText = "배송 상태";
            this.invoiceStateDataGridViewTextBoxColumn.Name = "invoiceStateDataGridViewTextBoxColumn";
            this.invoiceStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InvoiceListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Name = "InvoiceListControl";
            this.Size = new System.Drawing.Size(1028, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.BindingSource buyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceStateDataGridViewTextBoxColumn;
    }
}
