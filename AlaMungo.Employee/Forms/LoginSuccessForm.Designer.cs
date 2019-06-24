namespace AlaMungo.Employee.Forms
{
    partial class LoginSuccessForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbUsedBook = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBuy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSell = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInvoice = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblSellCount = new System.Windows.Forms.Label();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.lblBuyCount = new System.Windows.Forms.Label();
            this.lblUsedBookCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsedBook,
            this.toolStripSeparator1,
            this.tsbBuy,
            this.toolStripSeparator2,
            this.tsbSell,
            this.toolStripSeparator3,
            this.tsbInvoice,
            this.toolStripSeparator4,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(787, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbUsedBook
            // 
            this.tsbUsedBook.Image = global::AlaMungo.Employee.Properties.Resources.Book1;
            this.tsbUsedBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsedBook.Name = "tsbUsedBook";
            this.tsbUsedBook.Size = new System.Drawing.Size(55, 24);
            this.tsbUsedBook.Text = "중고";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbBuy
            // 
            this.tsbBuy.Image = global::AlaMungo.Employee.Properties.Resources.Purchase1;
            this.tsbBuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuy.Name = "tsbBuy";
            this.tsbBuy.Size = new System.Drawing.Size(55, 24);
            this.tsbBuy.Text = "구매";
            this.tsbBuy.ToolTipText = "구매";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbSell
            // 
            this.tsbSell.Image = global::AlaMungo.Employee.Properties.Resources.sale3;
            this.tsbSell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSell.Name = "tsbSell";
            this.tsbSell.Size = new System.Drawing.Size(55, 24);
            this.tsbSell.Text = "판매";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbInvoice
            // 
            this.tsbInvoice.Image = global::AlaMungo.Employee.Properties.Resources.Delivery_Truck1;
            this.tsbInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInvoice.Name = "tsbInvoice";
            this.tsbInvoice.Size = new System.Drawing.Size(55, 24);
            this.tsbInvoice.Text = "운송";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = global::AlaMungo.Employee.Properties.Resources.Exit1;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(55, 24);
            this.tsbExit.Text = "종료";
            this.tsbExit.Click += new System.EventHandler(this.TsbExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Location = new System.Drawing.Point(695, 9);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(80, 18);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "로그아웃";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // lblSellCount
            // 
            this.lblSellCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSellCount.AutoSize = true;
            this.lblSellCount.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSellCount.Location = new System.Drawing.Point(455, 240);
            this.lblSellCount.Name = "lblSellCount";
            this.lblSellCount.Size = new System.Drawing.Size(106, 27);
            this.lblSellCount.TabIndex = 14;
            this.lblSellCount.Text = "판매 수";
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCustomerCount.Location = new System.Drawing.Point(455, 185);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(106, 27);
            this.lblCustomerCount.TabIndex = 12;
            this.lblCustomerCount.Text = "고객 수";
            // 
            // lblBuyCount
            // 
            this.lblBuyCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuyCount.AutoSize = true;
            this.lblBuyCount.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBuyCount.Location = new System.Drawing.Point(455, 296);
            this.lblBuyCount.Name = "lblBuyCount";
            this.lblBuyCount.Size = new System.Drawing.Size(106, 27);
            this.lblBuyCount.TabIndex = 13;
            this.lblBuyCount.Text = "구매 수";
            // 
            // lblUsedBookCount
            // 
            this.lblUsedBookCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsedBookCount.AutoSize = true;
            this.lblUsedBookCount.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUsedBookCount.Location = new System.Drawing.Point(454, 127);
            this.lblUsedBookCount.Name = "lblUsedBookCount";
            this.lblUsedBookCount.Size = new System.Drawing.Size(134, 27);
            this.lblUsedBookCount.TabIndex = 11;
            this.lblUsedBookCount.Text = "중고책 수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(200, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "구매 대기 수    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(200, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "전체 고객 수    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(200, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "판매 대기 수    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(200, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "전체 중고책 수 :";
            // 
            // LoginSuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.lblSellCount);
            this.Controls.Add(this.lblCustomerCount);
            this.Controls.Add(this.lblBuyCount);
            this.Controls.Add(this.lblUsedBookCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LoginSuccessForm";
            this.Text = "LoginSuccessForm";
            this.Load += new System.EventHandler(this.EmployeeMainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbUsedBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBuy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSell;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbInvoice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblSellCount;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label lblBuyCount;
        private System.Windows.Forms.Label lblUsedBookCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}