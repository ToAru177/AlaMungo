namespace AlaMungo.Customer.Controls
{
    partial class BuyListControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qulity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsBuy = new System.Windows.Forms.BindingSource(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyIDDataGridViewTextBoxColumn,
            this.BookTitle,
            this.Writer,
            this.Qulity,
            this.Price});
            this.dataGridView1.DataSource = this.bdsBuy;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(906, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // buyIDDataGridViewTextBoxColumn
            // 
            this.buyIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.buyIDDataGridViewTextBoxColumn.DataPropertyName = "BuyID";
            this.buyIDDataGridViewTextBoxColumn.HeaderText = "중고책 번호";
            this.buyIDDataGridViewTextBoxColumn.Name = "buyIDDataGridViewTextBoxColumn";
            this.buyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookTitle.DataPropertyName = "BookTitle";
            this.BookTitle.HeaderText = "책 제목";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // Writer
            // 
            this.Writer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Writer.DataPropertyName = "Writer";
            this.Writer.HeaderText = "저자";
            this.Writer.Name = "Writer";
            this.Writer.ReadOnly = true;
            this.Writer.Width = 250;
            // 
            // Qulity
            // 
            this.Qulity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Qulity.DataPropertyName = "Qulity";
            this.Qulity.HeaderText = "품질";
            this.Qulity.Name = "Qulity";
            this.Qulity.ReadOnly = true;
            this.Qulity.Width = 50;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "가격";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // bdsBuy
            // 
            this.bdsBuy.DataSource = typeof(AlaMungo.Data.Buy);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCount.Location = new System.Drawing.Point(0, 406);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(29, 12);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "대기";
            // 
            // BuyListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuyListControl";
            this.Size = new System.Drawing.Size(906, 418);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.BindingSource bdsBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qulity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
