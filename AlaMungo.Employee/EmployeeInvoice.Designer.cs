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
            this.invoiceSearchControl1 = new AlaMungo.Employee.Controls.InvoiceSearchControl();
            this.invoiceListControl1 = new AlaMungo.Employee.Controls.InvoiceListControl();
            this.bdsInvoice = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceSearchControl1
            // 
            this.invoiceSearchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.invoiceSearchControl1.Location = new System.Drawing.Point(0, 0);
            this.invoiceSearchControl1.Name = "invoiceSearchControl1";
            this.invoiceSearchControl1.Size = new System.Drawing.Size(800, 90);
            this.invoiceSearchControl1.TabIndex = 0;
            // 
            // invoiceListControl1
            // 
            this.invoiceListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceListControl1.Location = new System.Drawing.Point(0, 90);
            this.invoiceListControl1.Name = "invoiceListControl1";
            this.invoiceListControl1.Size = new System.Drawing.Size(800, 360);
            this.invoiceListControl1.TabIndex = 1;
            // 
            // EmployeeInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invoiceListControl1);
            this.Controls.Add(this.invoiceSearchControl1);
            this.Name = "EmployeeInvoice";
            this.Text = "배송관리";
            this.Load += new System.EventHandler(this.EmployeeInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.InvoiceSearchControl invoiceSearchControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceStateDataGridViewTextBoxColumn;
        private Controls.InvoiceListControl invoiceListControl1;
        private System.Windows.Forms.BindingSource bdsInvoice;
    }
}